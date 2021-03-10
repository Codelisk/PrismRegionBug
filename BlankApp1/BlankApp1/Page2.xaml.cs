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
        public Page2(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            InitializeComponent();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            this._regionManager.RequestNavigate("ContentRegion1", nameof(Region1));
        }
    }
}