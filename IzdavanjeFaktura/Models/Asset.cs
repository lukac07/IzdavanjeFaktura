using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IzdavanjeFaktura.Models
{
    public class Asset
    {
        public int AssetID { get; set; }

        public int BillID { get; set; }

        
        public int ItemID { get; set; }

        public virtual Item Item { get; set; }

        [Display(Name = "Naziv artikla: ")]
        public string AssetName { get; set; }

        [Display(Name = "Količina: ")]
        public int Quantity { get; set; }

        [Display(Name = "Cijena po komadu: ")]
        public float Asset_Price__Per_Item { get; set; }

        [Display(Name = "Ukupno bez PDV-a: ")]
        public float Asset_Price { get; set; }

        [Display(Name = "PDV ")]
        public int Asset_Tax { get; set; }

        [Display(Name = "Ukupno s PDV-om ")]
        public float Asset_Price_With_Tax { get; set; }

        
    }
}