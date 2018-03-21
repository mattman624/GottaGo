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
using GottaGo.Shared.Models;
using GottaGo.Shared.MockData;
using System.Collections.ObjectModel;

namespace GottaGo.Client.Test.ViewModels
{
    [TestFixture]
    public class FacilityListPageViewModelTests
    {
        private TestApp _app;
        Mock<IFacilityService> FSmoq = new Mock<IFacilityService>();
        FacilityListPageViewModel _model;

        [SetUp]
        public void SetUp()
        {
            _app = new TestApp();            
            _app.Registry.RegisterInstance<IFacilityService>(FSmoq.Object);


            _model = _app.Container.Resolve<FacilityListPageViewModel>();            
        }

        [Test]
        public void FacilityListPageRequestsFacilitiesWhenNavigatingFirstTime()
        {
            FSmoq.Setup(f => f.GetFacilities()).Returns(Task.FromResult(new ObservableCollection<Facility>(MockFacilities.GetAll())));
            _app.NavigateTo(_model);

            FSmoq.Verify(v => v.GetFacilities(), Times.AtLeastOnce);
            Assert.IsTrue(_model.Facilities.Any());
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
