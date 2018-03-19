using GottaGo.Client.Contracts;

using GottaGo.Client.Utilities;
using GottaGo.Client.ViewModels;
using Moq;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace GottaGo.Client.Test.Utilities
{
    
    public class TestApp //: PrismApplicationBase
    {
        //public UnityContainerExtension Container { get; }
        public Mock<INavigationService> NavMock { get; }
        public IContainerRegistry Registry => (IContainerRegistry)Container;
        public IContainerProvider Container { get; }
        
        public TestApp()
        {
            //Xamarin.Forms.Init();
            Container = new UnityContainerExtension(new UnityContainer());

            NavMock = new Mock<INavigationService>();
            RegisterTypes(Registry);
            //NavMock = nav.Object;
            
        }

        public void NavigateTo(BaseViewModel model, NavigationParameters paras = null)
        {
            model.OnNavigatingTo(paras);
            model.OnNavigatedTo(paras);
        }

        protected IContainerExtension CreateContainerExtension()
        {
            return new UnityContainerExtension(new UnityContainer());
        }

        protected void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<Utils, IUtils>();
            containerRegistry.Register<ILogger, MoqLogger>();
            
            containerRegistry.RegisterInstance<INavigationService>(NavMock.Object);
            containerRegistry.Register<IUtils, Utils>();
        }                
    }
}
