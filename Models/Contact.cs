using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GDC.Models
{
    public class Contact
    {
        public int contactID { get; set; } //Primary Key

        [Required]
        [Display(Name = "Premier Nom")]
        public string? firstname { get; set; }

        [Required]
        [Display(Name = "Nom de Famille")]
        public string? lastname { get; set; }

        [Display(Name = "Addresse")]
        public string? address { get; set; }

        [Display(Name = "Ville")]
        public string? city { get; set; }

        [Display(Name = "Province")]
        public string? province { get; set; }

        [Display(Name = "Code Postal")]
        public string? postalCode { get; set; }

        [Display(Name = "Email")]
        public string? email { get; set; }

        [Display(Name = "Numero de Telephone")]
        public string? phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date de Creation")]
        public DateTime creationDate { get; set; }

        [Required]
        [Display(Name = "Categorie")]
        public int categoryID { get; set; } //Foreign Key

        [Required]
        public string? username { get; set; }

        /***********************
         * NAVIGATION PROPERTIES 
        ***********************/
        public Category? category { get; set; }
    }
}
