using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Utils
{
    public interface IUtils
    {
        INavigationService NavigationService { get; }
        ILogger Logger { get; }
    }
}
