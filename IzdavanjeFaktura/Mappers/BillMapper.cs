using IzdavanjeFaktura.Models;
using IzdavanjeFaktura.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzdavanjeFaktura.Mappers
{
    public class BillMapper
    {
        public BillViewModel MappBillToViewModel(Bill model)
        {
            var viewModel = new BillViewModel
            {
                BillID = model.BillID,
                Bill_Created_Date = model.Bill_Created_Date,
                Bill_Due_Date = model.Bill_Due_Date,
                Price_Item_NonTax = model.Price_Item_NonTax,
                Price_NonTax = model.Price_NonTax,
                Price_Final = model.Price_Final
            };
            return viewModel;
        }

        public List<BillViewModel> MappBillListToViewModel(List<Bill> models)
        {
            var viewModels = new List<BillViewModel>();
            models.ForEach(x => {
                var viewModel = MappBillToViewModel(x);
                viewModels.Add(viewModel);
            }
            );
            return viewModels;
        }
    }
}