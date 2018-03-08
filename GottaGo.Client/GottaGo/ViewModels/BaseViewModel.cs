using GottaGo.Client.Contracts;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.ViewModels
{
    public class BaseViewModel : BindableBase, INavigatedAware, INavigatingAware, INavigationAware, IActiveAware
    {
        IUtils _utils;
        INavigationService NavigationService;
        public BaseViewModel(IUtils utils)
        {
            _utils = utils;
            NavigationService = utils.NavigationService;
        }
        public bool IsActive { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public event EventHandler IsActiveChanged;

        //public abstract void NavigatedFrom(NavigationParameters parameters)
        //{

        //}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
    }
}
