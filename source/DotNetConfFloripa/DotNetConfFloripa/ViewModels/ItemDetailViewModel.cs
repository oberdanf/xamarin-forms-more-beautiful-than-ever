using System;

using DotNetConfFloripa.Models;

namespace DotNetConfFloripa.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }

        public ItemDetailViewModel(string id)
        {
            var item = DataStore.GetItemAsync(id).GetAwaiter().GetResult();
            Title = item?.Text;
            Item = item;
        }
    }
}
