using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class StorageWorker
    {
        
        public static Boolean CreateJournal(Journal journal)
        {
            if(journal.Journal1==null || journal.Journal1==string.Empty)
            {
                DateTime now = DateTime.UtcNow;
                journal.Journal1 = "J" + now.Year + now.Month + now.Date + now.Hour + now.Minute + now.Second;
                }
            if (journal.JournalType == 0)
                journal.JournalType = JournalConnector.STD_JOURNAL_TYPE;
            if(journal.Module==0)
            {
                journal.Module = JournalConnector.STD_JOURNAL_MODULE;
            }
            if(journal.Source==null || journal.Journal1==string.Empty)
            {
                journal.Source = JournalConnector.STD_JOURNAL_SOURCE;
            }
            var jc = new JournalConnector();
           return jc.CreateJournal(journal);
        }

        public static List<Journal> GetAllStockJournals()
        {
            var jc = new JournalConnector();
            return jc.GetAllStockJournals();
        }
        public static List<InventoryCount> retrieveLastRecords(string journal)
        {
            var jc = new JournalConnector();
            return jc.RetrieveLastRecords(journal);
        }
       
        public static int ScanItem(ScanItem item)
        {
            BarcodeSplitter.extractParameters(item);
            var jc = new JournalConnector();
            return jc.ScanBarcodeItem(item);
        }

        public static bool IsValidTemplate(string id)
        {
            var jc = new JournalConnector();
            return jc.IsValidTemplate(id, JournalConnector.STD_JOURNAL_MODULE, JournalConnector.STD_JOURNAL_TYPE);
        }
    }
}
