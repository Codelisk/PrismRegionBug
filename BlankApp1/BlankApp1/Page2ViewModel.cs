using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp1
{
    public class Page2ViewModel : BindableBase, IInitialize
    {
        public Page2ViewModel()
        {

        }
        private string _regionName;
        public string RegionName
        {
            get { return _regionName; }
            set { SetProperty(ref _regionName, value); }
        }
        public void Initialize(INavigationParameters parameters)
        {
            this.RegionName = "Region" + App.count;
            App.count++;
        }
    }
}
