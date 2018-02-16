using IzdavanjeFaktura.Models;
using IzdavanjeFaktura.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzdavanjeFaktura.Services
{
    public class ItemServices
    {
        private IzdavanjeFakturaContext db = new IzdavanjeFakturaContext();
        private Mappers.ItemMappers mapper = new Mappers.ItemMappers();

        public List<ItemViewModel> GetAllItems()
        {
            var items = db.Items.ToList();
            var viewModels = mapper.MappItemListToViewModel(items);

            return viewModels;
        }


        public ItemViewModel GetItemViewModel(int id)
        {
            var dbModel = db.Items.FirstOrDefault(x => x.ItemID == id);
            var viewModel = mapper.MappItemToViewModel(dbModel);
            return viewModel;
        }

    }
}