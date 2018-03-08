using GottaGo.Client.Contracts;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Utils
{
    public class Utils : IUtils
    {
        public INavigationService NavigationService { get; }

        public Utils(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
