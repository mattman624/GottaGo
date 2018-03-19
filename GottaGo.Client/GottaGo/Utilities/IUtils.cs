using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Utilities
{
    public interface IUtils
    {
        INavigationService NavigationService { get; }
        ILogger Logger { get; }
    }
}
