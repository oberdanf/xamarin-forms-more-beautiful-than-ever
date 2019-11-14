using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DotNetConfFloripa.Models;
using DotNetConfFloripa.ViewModels;

namespace DotNetConfFloripa.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [QueryProperty(nameof(ItemId), "id")]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        private string itemId;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Nome do evento",
                Description = "Descrição do evento"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public string ItemId
        {
            get => itemId;
            set
            {
                itemId = value;
                System.Diagnostics.Debug.WriteLine($"Valor passado por parâmetro {value}");
            }
        }
    }
}