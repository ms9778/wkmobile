using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace Winkompass_Mobil.Models
{
    public class ListModelModel
    {
        TemplateList List = new TemplateList() { Journals = StorageWorker.GetAllStockJournals() };
        TemplateModel kModel = new TemplateModel();
    }
}