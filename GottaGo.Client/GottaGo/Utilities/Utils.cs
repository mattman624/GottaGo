using GottaGo.Client.Utilities;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Utilities
{
    public class Utils : IUtils
    {
        public INavigationService NavigationService { get; }
        public ILogger Logger { get; }

        public Utils(INavigationService navigationService, ILogger logger)
        {
            NavigationService = navigationService;
            Logger = logger;
        }
    }
}
