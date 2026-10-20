using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo_ASPMVC_03.Models
{
    public class Product
    {
        [DisplayName("Identifiant")]
        public int Id { get; set; }

        [DisplayName("Nom du produit")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string? Desc { get; set; }

        [DisplayName("Prix")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DisplayName("Code barre")]
        public string Gtin { get; set; }

        [DisplayName("Quantité")]
        public int Quantity { get; set; }
    }
}
