using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DotNetConfFloripa.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Sobre";

            OpenWebCommand = new Command<string>(url => OpenUrl(url));
        }

        private static void OpenUrl(string url) => Device.OpenUri(new Uri(url));

        public ICommand OpenWebCommand { get; }
    }
}