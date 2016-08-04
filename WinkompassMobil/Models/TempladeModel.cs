using BE;

namespace Winkompass_Mobil.Models
{
    public class TemplateModel
    {
        public TemplateModel()
        {
            Created = false;
        }

        public Journal Template { get; set; }
        public bool Created { get; set; }
        public string Error { get; set; } = "";
    }
}