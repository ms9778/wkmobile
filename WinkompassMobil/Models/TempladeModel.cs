using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;

namespace Winkompass_Mobil.Models
{
    public class TemplateModel
    {
        
        public Journal Template { get; set; }
        public Boolean Created { get; set; }
        private string error="";
        public string Error { get { return error; } set { error = value; } }
        public TemplateModel()
        {
            Created = false;
        }
    }
}