using DotNetConfFloripa.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DotNetConfFloripa.ViewModels
{
    public class CarouselViewViewModel : BaseViewModel
    {
        public CarouselViewViewModel()
        {
            Title = "CarouselView";
            DataList = new ObservableCollection<Event>(Event.Events);
        }

        public ObservableCollection<Event> DataList { get; }
    }
}
