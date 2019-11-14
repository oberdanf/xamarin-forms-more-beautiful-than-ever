using DotNetConfFloripa.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DotNetConfFloripa
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("collectionView", typeof(CollectionViewPage));
            Routing.RegisterRoute("carouselView", typeof(CarouselViewPage));
            Routing.RegisterRoute("detail", typeof(ItemDetailPage));
        }
    }
}
