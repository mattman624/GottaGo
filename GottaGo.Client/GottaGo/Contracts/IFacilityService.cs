using GottaGo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GottaGo.Client.Contracts
{
    public interface IFacilityService
    {
        Task<ObservableCollection<Facility>> GetFacilities();
    }
}
