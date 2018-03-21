using GottaGo.Client.Contracts;
using GottaGo.Client.Utilities;
using GottaGo.Shared.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GottaGo.Client.ViewModels
{
	public class FacilityListPageViewModel : BaseViewModel
    {
        public ObservableCollection<Facility> Facilities { get; set; }

        private IFacilityService _facilityService;

        public FacilityListPageViewModel(IFacilityService facilityService, IUtils utils) : base(utils)
        {
            _facilityService = facilityService;
        }

        protected override async Task NavigatingToAsync(NavigationParameters parameters)
        {
            Facilities = await _facilityService.GetFacilities();
        }
    }
}
