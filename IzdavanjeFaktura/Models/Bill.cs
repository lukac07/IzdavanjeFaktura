using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IzdavanjeFaktura.Models
{
    public class Bill
    {
        public int BillID { get; set; }

        //public int ItemID { get; set; }

        public virtual List<Item> Items { get; set; }

        [Display(Name = "Broj računa: ")]
        public int Bill_Number { get; set; }    //broj računa

        [Display(Name = "Datum kreiranja: ")]
        public DateTime Bill_Created_Date { get; set; } //datum kreiranja računa

        [Display(Name = "Datum dospjeća: ")]
        public DateTime Bill_Due_Date { get; set; } //datum naplate računa

        [Display(Name = "Cijena stavke bez poreza: ")]
        public float Price_Item_NonTax { get; set; }    //ukupna cijena za stavku bez poreza (broj stavki * jedinicna cijena bez poreza)

        [Display(Name = "Ukupna cijena bez poreza: ")]
        public float Price_NonTax { get; set; } //ukupna cijena bez poreza (zbroj ukupnih cijena svih stavki)

        [Display(Name = "Ukupna cijena s porezom: ")]
        public float Price_Final { get; set; }  //Ukupna cijena s porezom

       

    }
}