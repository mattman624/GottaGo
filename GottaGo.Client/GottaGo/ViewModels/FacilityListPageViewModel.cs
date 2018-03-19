using GottaGo.Client.Contracts;
using GottaGo.Client.Utilities;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GottaGo.Client.ViewModels
{
	public class FacilityListPageViewModel : BaseViewModel
    {
        public FacilityListPageViewModel(IFacilityService facilityService, IUtils utils) : base(utils)
        {

        }
	}
}
