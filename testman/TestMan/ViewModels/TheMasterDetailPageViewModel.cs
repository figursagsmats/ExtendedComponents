using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMan.ViewModels
{
    public class TheMasterDetailPageViewModel : BindableBase
    {
        INavigationService _navigationService;

        public DelegateCommand<string> NavigateCommand { get; set; }
        public TheMasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
        private void Navigate(string name)
        {
            _navigationService.NavigateAsync(name);
        }
    }
}
