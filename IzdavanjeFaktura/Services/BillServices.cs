using IzdavanjeFaktura.Models;
using IzdavanjeFaktura.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzdavanjeFaktura.Services
{
    public class BillServices
    {
        private IzdavanjeFakturaContext db = new IzdavanjeFakturaContext();
        private Mappers.BillMapper mapper = new Mappers.BillMapper();

        public List<BillViewModel> GetAllBills()
        {
            var bills = db.Bills.ToList();
            var viewModels = mapper.MappBillListToViewModel(bills);

            return viewModels;
        }


        public BillViewModel GetBillViewModel(int id)
        {
            var dbModel = db.Bills.FirstOrDefault(x => x.BillID == id);
            var viewModel = mapper.MappBillToViewModel(dbModel);
            return viewModel;
        }
    }
}