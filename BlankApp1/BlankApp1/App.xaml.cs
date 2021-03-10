using BlankApp1.ViewModels;
using BlankApp1.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace BlankApp1
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var result=await NavigationService.NavigateAsync("/TabbedPage1?createTab=NavigationPage|MainPage&createTab=NavigationPage|Page2");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterRegionServices();
            containerRegistry.RegisterForRegionNavigation<Region1>();

            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPage1>();
            containerRegistry.RegisterForNavigation<Page2>();
            containerRegistry.RegisterForNavigation<Page3>();
        }
    }
}
