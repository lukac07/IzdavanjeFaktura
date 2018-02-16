using IzdavanjeFaktura.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IzdavanjeFaktura.ViewModels
{
    public class ItemViewModel
    {
        public int ItemID { get; set; }

        [Display(Name = "Proizvod: ")]
        public string Item_Description { get; set; }    

        [Display(Name = "Cijena (bez pdv-a)")]
        public float Price_Item { get; set; }

        public virtual List<Asset> Asset { get; set; }
    }
}