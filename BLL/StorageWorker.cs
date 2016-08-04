using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class StorageWorker
    {
        public static bool CreateJournal(Journal journal)
        {
            if (string.IsNullOrEmpty(journal.Journal1))
            {
                var now = DateTime.UtcNow;
                journal.Journal1 = "J" + now.Year + now.Month + now.Date + now.Hour + now.Minute + now.Second;
            }
            if (journal.JournalType == 0)
                journal.JournalType = JournalConnector.StdJournalType;
            if (journal.Module == 0)
            {
                journal.Module = JournalConnector.StdJournalModule;
            }
            if (journal.Source == null || journal.Journal1 == string.Empty)
            {
                journal.Source = JournalConnector.StdJournalSource;
            }
            var jc = new JournalConnector();
            return jc.CreateJournal(journal);
        }

        public static List<Journal> GetAllStockJournals()
        {
            var jc = new JournalConnector();
            return jc.GetAllStockJournals();
        }

        public static List<InventoryCount> RetrieveLastRecords(string journal)
        {
            var jc = new JournalConnector();
            return jc.RetrieveLastRecords(journal);
        }

        public static int ScanItem(ScanItem item)
        {
            BarcodeSplitter.ExtractParameters(item);
            var jc = new JournalConnector();
            return jc.ScanBarcodeItem(item);
        }

        public static bool IsValidTemplate(string id)
        {
            var jc = new JournalConnector();
            return jc.IsValidTemplate(id, JournalConnector.StdJournalModule, JournalConnector.StdJournalType);
        }
    }
}