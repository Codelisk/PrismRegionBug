using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this._navigationService = navigationService;
            Title = "Main Page";
        }
        private DelegateCommand _clickCommand;
        public DelegateCommand ClickCommand =>
            _clickCommand ?? (_clickCommand = new DelegateCommand(ExecuteClickCommand));

        async void ExecuteClickCommand()
        {
            var pp= _navigationService.GetNavigationUriPath();
            var res=await this._navigationService.NavigateAsync("/Page2/Page2");
        }
    }
}
