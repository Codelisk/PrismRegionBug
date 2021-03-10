using BlankApp1.Views;
using Prism.Navigation;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage, INavigatedAware
    {
        private readonly IRegionManager _regionManager;
        INavigationService navigationService;
        public Page2(IRegionManager regionManager, INavigationService navigationService)
        {
            this.navigationService = navigationService;
            _regionManager = regionManager;
            InitializeComponent();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            this._regionManager.RequestNavigate("ContentRegion1", nameof(Region1));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var test=await this.navigationService.NavigateAsync("Page2/Page2");
        }
    }
}