using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetConfFloripa.Models;

namespace DotNetConfFloripa.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = ".NET Conf 2019", Description="Dias 23 a 25 de Setembro de 2019" },
                new Item { Id = Guid.NewGuid().ToString(), Text = ".NET Conf Floripa 2019", Description="Dia 26 de Outubro de 2019" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Xamarin Summit", Description="Dias 4 e 5 de Outubro de 2019" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}