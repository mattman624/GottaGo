using GottaGo.Client.Utilities;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GottaGo.Client.ViewModels
{
    public class BaseViewModel : BindableBase, INavigatedAware, INavigatingAware, INavigationAware, IActiveAware
    {
        private IUtils _utils;
        INavigationService NavigationService;
        ILogger Log;
        public BaseViewModel(IUtils utils)
        {
            _utils = utils;
            NavigationService = utils.NavigationService;
            Log = utils.Logger;
        }
        public bool IsActive { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public event EventHandler IsActiveChanged;
        
        

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        protected virtual void NavigatedTo(NavigationParameters parameters)
        {
            Log.Info($"{GetType().Name} NavigatedTo");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Log.Info($"OnNavigatedTo {GetType().Name}");
            LogParameters(parameters);
            NavigatedTo(parameters);
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Log.Info($"OnNavigatingTo {GetType().Name}");
            LogParameters(parameters);
            NavigatingToAsync(parameters);
        }

        protected virtual Task NavigatingToAsync(NavigationParameters parameters)
        {            
            return Task.Run(() => Log.Info($"{GetType().Name} NavigatingTo"));
        }

        private void LogParameters(NavigationParameters parameters)
        {
            try
            {
                //if (Logger.IsInfoEnabled)
                    foreach (var parameter in parameters)


                        Log.Debug($"{parameter.Key} = {parameter.Value}");
            }
            catch (Exception ex)
            {
                Log.Error("get paramaters failed", ex);
            }
        }
    }
}
