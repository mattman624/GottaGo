using GottaGo.Client.Utils;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Utils
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
