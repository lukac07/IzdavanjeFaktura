using IzdavanjeFaktura.Models;
using IzdavanjeFaktura.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzdavanjeFaktura.Mappers
{
    public class ItemMappers
    {
        public ItemViewModel MappItemToViewModel(Item model)
        {
            var viewModel = new ItemViewModel
            {
                ItemID = model.ItemID,
                Item_Description = model.Item_Description,
                Price_Item = model.Price_Item

            };
            return viewModel;
        }


        public List<ItemViewModel> MappItemListToViewModel(List<Item> models)
        {
            var viewModels = new List<ItemViewModel>();
            models.ForEach(x => {
                var viewModel = MappItemToViewModel(x);
                viewModels.Add(viewModel);
            }
            );
            return viewModels;
        }
    }
}