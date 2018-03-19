using GottaGo.Client.Contracts;
using GottaGo.Client.Test.Utilities;
using GottaGo.Client.ViewModels;
using Moq;
using Prism.Ioc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Lifetime;

namespace GottaGo.Client.Test.ViewModels
{
    [TestFixture]
    public class FacilityListPageViewModelTests
    {
        private TestApp _app;
        Mock<IFacilityService> moq = new Mock<IFacilityService>();
        FacilityListPageViewModel _model;

        [SetUp]
        public void SetUp()
        {
            _app = new TestApp();
            var obj = moq.Object;
            _app.Registry.RegisterInstance<IFacilityService>(obj);


            _model = _app.Container.Resolve<FacilityListPageViewModel>();
            //(FacilityListPageViewModel)_app.Container.Resolve(typeof(FacilityListPageViewModel));
            
        }

        [Test]
        public void FacilityListPageRequestsFacilitiesWhenNavigatingFirstTime()
        {
            _model.OnNavigatingTo
        }
    }
}
