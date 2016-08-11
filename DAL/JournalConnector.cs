using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;
using BE;

namespace DAL
{
    public class JournalConnector : DbConnecter
    {
        public const string StdJournalSource = "LagerOptælling";
        public const short StdJournalType = 3;
        public const short StdJournalModule = 3;
        public const string NotExists = "<NotExist>!";
        public const string NotExistsItem = "<Item>";
        public const string NotExistsLocation = "<Location>";
        public const string ItemNotExistsMessage = "Varen \"{0}\" eksisterer ikke";
        public const string LocationNotExistsMessage = "Placeringen \"{0}\" eksisterer ikke";
        public const string UnrecognizedError = "der opstod en uventet fejl";

        /// <summary>
        /// create a new journal
        /// </summary>
        /// <param name="journal">the journal objet that is to be created</param>
        /// <returns>true if object is made</returns>
        public bool CreateJournal(Journal journal)
        {
            var delivered = false;
            try
            {
                Db.Public_Journal_AddNew(null, null, null, null, null, null, null, null,
                    journal.Journal1, journal.JournalType, null, null, null, null, null,
                    null, StdJournalModule, null, null, null, null, null, null, journal.Source, true, null, null, null);
            }
            catch (EntityCommandExecutionException)
            {
                //midlertidig løsning, hvis ef ikke virker skal dette ikke rulles ud!
                delivered = true;
            }
            return delivered;
        }

        /// <summary>
        /// get all the journals that are currently in the database
        /// </summary>
        /// <returns>a list of all the journals</returns>
        public List<Journal> GetAllStockJournals()
        {
            return
                Db.Journals.Where(x => x.JournalType == StdJournalType && x.Module == StdJournalModule)
                    .Select(x => x)
                    .ToList();
        }

        /// <summary>
        /// get all the locations, that a journal can have, that are currently in the database
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllLocations()
        {
            return Db.Locations.Select(s => s.Name).ToList();
        }

        /// <summary>
        /// used when you scan a barcode
        /// </summary>
        /// <param name="item">the scanend item</param>
        /// <returns>a 0 if no scan and 1 if scan valid and 2 if scan invalid</returns>
        public int ScanBarcodeItem(ScanItem item)
        {
            try
            {
                ObjectResult<string> result;
                if (string.IsNullOrEmpty(item.Location))
                {
                    result = Db.EW_Mobil_AddInventoryCount(item.Journal, "", "", item.BarCode, item.Count, item.Par1,
                        item.Par2);
                }
                else
                {
                    result = Db.EW_Mobil_AddInventoryCount(item.Journal, item.Location, "", "", item.BarCode, item.Count,
                        item.Par1, item.Par2);
                }
                var error = result.FirstOrDefault();
                if (!string.IsNullOrEmpty(item.Location))
                {
                    var parResult1 = "";
                    if (!string.IsNullOrEmpty(item.Par1))
                        parResult1 =
                            Db.InventoryParameters.Where(
                                x => x.Item == item.BarCode && x.ParamNo == 0 && x.SortIndex == short.Parse(item.Par1))
                                .Select(y => y.Parameter)
                                .FirstOrDefault();
                    var parResult2 = "";
                    if (!string.IsNullOrEmpty(item.Par2))
                        parResult2 =
                            Db.InventoryParameters.Where(
                                x => x.Item == item.BarCode && x.ParamNo == 1 && x.SortIndex == short.Parse(item.Par2))
                                .Select(y => y.Parameter)
                                .FirstOrDefault();
                    item.Difference =
                        Db.OnHands.Where(
                            x =>
                                x.Item == item.BarCode && x.Location == item.Location && x.Parameter1 == parResult1 &&
                                x.Parameter2 == parResult2).Select(x => x.OnHandPhys).FirstOrDefault() - item.Count;
                    item.ShowDifference = true;
                }
                if (string.IsNullOrEmpty(error))
                {
                    return ScanItem.SCAN_VALID;
                }
                if (error.Contains(NotExists) && error.Contains(NotExistsItem))
                {
                    item.ItemError = string.Format(ItemNotExistsMessage, item.BarCode);
                    return ScanItem.SCAN_INVALID;
                }
                if (error.Contains(NotExists) && error.Contains(NotExistsLocation))
                {
                    item.ItemError = string.Format(LocationNotExistsMessage, item.Location);
                    item.Location = null;
                    return ScanItem.SCAN_INVALID;
                }
                item.ItemError = UnrecognizedError;
                return ScanItem.SCAN_INVALID;
            }
            catch (Exception)
            {
                item.ItemError = UnrecognizedError;
                return ScanItem.SCAN_INVALID;
            }
        }

        /// <summary>
        /// returns the last (n) records that was put on a record
        /// </summary>
        /// <param name="journal">the journal whose records you want to see</param>
        /// <param name="number">the number of records to get</param>
        /// <returns></returns>
        public List<InventoryCount> RetrieveLastRecords(string journal, int number = 5)
        {
            return Db.InventoryCounts.Where(x => x.Journal == journal)
                .OrderByDescending(y => y.RecordId)
                .Take(number)
                .ToList();
        }


        public bool IsValidTemplate(string id, short module, short type)
        {
            var tmplt =
                Db.Journals.Where(x => x.Journal1 == id && x.Module == module && x.JournalType == type)
                    .Select(x => x)
                    .SingleOrDefault();
            return tmplt != null;
        }
    }
}