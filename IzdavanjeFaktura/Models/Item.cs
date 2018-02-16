using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IzdavanjeFaktura.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        [Display(Name = "Proizvod: ")]
        public string Item_Description { get; set; }    //opis prodane stavke

        //public int Item_Amount { get; set; }    //količina prodane stavke

        [Display(Name = "Cijena (bez pdv-a)")]
        public float Price_Item { get; set; }     //jedinična cijena stavke bez poreza

        public virtual List<Asset> Asset { get; set; }



    }
}