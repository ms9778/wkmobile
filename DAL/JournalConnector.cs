using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity.Core.Objects;

namespace DAL
{
    public class JournalConnector : DBConnecter
    {
        public const string STD_JOURNAL_SOURCE = "LagerOptælling";
        public const short STD_JOURNAL_TYPE=3;
        public const short STD_JOURNAL_MODULE = 3;
        public const string NOT_EXISTS = "<NotExist>!";
        public const string NOT_EXISTS_Item = "<Item>";
        public const string NOT_EXISTS_Location = "<Location>";
        public const string ITEM_NOT_EXISTS_MESSAGE = "Varen \"{0}\" eksisterer ikke";
        public const string LOCATION_NOT_EXISTS_MESSAGE = "Placeringen \"{0}\" eksisterer ikke";
        public const string UNRECOGNIZED_ERROR="der opstod en uventet fejl";
        public Boolean CreateJournal(Journal journal)
        {
            Boolean delivered = false;           
            try { 
            db.Public_Journal_AddNew(null, null, null, null, null, null, null, null,
                journal.Journal1, journal.JournalType, null, null, null, null, null,
                null, STD_JOURNAL_MODULE, null, null, null, null, null, null, journal.Source, true, null, null, null);
            }
            catch(System.Data.Entity.Core.EntityCommandExecutionException e)
            {

                //midlertidig løsning, hvis ef ikke virker skal dette ikke rulles ud!
                delivered = true;
            }
            return delivered;
        }

        public List<Journal> GetAllStockJournals()
        {
            return db.Journals.Where(x => x.JournalType == STD_JOURNAL_TYPE && x.Module == STD_JOURNAL_MODULE).Select(x => x).ToList();
        }

        public int ScanBarcodeItem(ScanItem item)
        {
            try
            {
                ObjectResult<string> result = null;
                if (string.IsNullOrEmpty(item.location))
                {  result = db.EW_Mobil_AddInventoryCount(item.Journal, "", "", item.barCode, item.count, item.par1, item.par2); }
                else {  result = db.EW_Mobil_AddInventoryCount(item.Journal,item.location, "", "", item.barCode, item.count, item.par1, item.par2); }
                string error = result.FirstOrDefault();
                if(!string.IsNullOrEmpty(item.location))
                {
                    
                    string parResult1 ="";
                    if(!string.IsNullOrEmpty(item.par1))
                    parResult1= db.InventoryParameters.Where(x=>x.Item==item.barCode && x.ParamNo == 0 && x.SortIndex==short.Parse(item.par1)).Select(y=>y.Parameter).FirstOrDefault();
                    string parResult2 = "";
                    if(!string.IsNullOrEmpty(item.par2))
                   parResult2 = db.InventoryParameters.Where(x=>x.Item==item.barCode && x.ParamNo == 1 && x.SortIndex==short.Parse(item.par2)).Select(y=>y.Parameter).FirstOrDefault();
                    item.difference= db.OnHands.Where(x => x.Item == item.barCode && x.Location == item.location && x.Parameter1 == parResult1 && x.Parameter2 == parResult2).Select(x => x.OnHandPhys).FirstOrDefault() -item.count;
                    item.showDifference = true;
                }
                if (string.IsNullOrEmpty(error))
                { return ScanItem.SCAN_VALID; }
                else if (error.Contains(NOT_EXISTS) && error.Contains(NOT_EXISTS_Item))
                {
                    item.ItemError = string.Format(ITEM_NOT_EXISTS_MESSAGE, item.barCode);
                    return ScanItem.SCAN_INVALID;
                }
                else if (error.Contains(NOT_EXISTS) && error.Contains(NOT_EXISTS_Location))
                {
                    item.ItemError = string.Format(LOCATION_NOT_EXISTS_MESSAGE, item.location);
                    item.location = null;
                    return ScanItem.SCAN_INVALID;
                }
                else
                {
                    item.ItemError = UNRECOGNIZED_ERROR;
                    return ScanItem.SCAN_INVALID;
                }
            }
            catch(Exception e)
            {
                item.ItemError = UNRECOGNIZED_ERROR;
                return ScanItem.SCAN_INVALID;
            }
        }

        public List<InventoryCount> RetrieveLastRecords(string journal,int number=5)
        {
            return db.InventoryCounts.Where(x => x.Journal == journal)
                .OrderByDescending(y => y.RecordId)
                .Take(number)
                .ToList();
        }

        public bool IsValidTemplate(string id, short module, short type)
        {
            var tmplt = db.Journals.Where(x => x.Journal1 == id && x.Module == module && x.JournalType == type).Select(x=>x).SingleOrDefault();
            return tmplt != null;
        }
    }
}
