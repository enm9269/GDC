using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GDC.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        [Display(Name = "Nom")]
        public string? name { get; set; }

        public ICollection<Contact>? contacts { get; set; }
    }
}
