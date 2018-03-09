using GottaGo.Client.Utils;
using GottaGo.Client.Views;
using Plugin.SimpleLogger;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GottaGo.Client
{
	public partial class App : PrismApplication
	{
		public App () : base()
		{
            //InitializeComponent();

            //MainPage = new GottaGo.Client.MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<INavigationService, NavigationService>();
            containerRegistry.Register<IUtils, Utils.Utils>();
            containerRegistry.Register<ILogger, Logger>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage>();
            containerRegistry.RegisterForNavigation<BathroomListPage>();
        }

        protected override void OnInitialized()
        {            
            NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }
    }
}
