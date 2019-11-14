using DotNetConfFloripa.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DotNetConfFloripa.ViewModels
{
    public class CollectionViewViewModel : BaseViewModel
    {
        public CollectionViewViewModel()
        {
            Title = "CollectionView";
            LoadData();
            LoadMoreCommand = new Command(LoadData);
        }

        public ObservableCollection<Event> DataList { get; } = new ObservableCollection<Event>();

        public ICommand LoadMoreCommand { get; }

        private async void LoadData()
        {
            IsBusy = true;
            await foreach (var item in LoadMoreData().ConfigureAwait(false))
            {
                DataList.Add(item);
            }
            IsBusy = false;
        }

        public async IAsyncEnumerable<Event> LoadMoreData()
        {
            for (int i = 0; i < Event.Events.Count; i++)
            {
                await Task.Delay(500);
                yield return Event.Events[i];
            }
        }
    }
}
