using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Contracts
{
    public interface IUtils
    {
        INavigationService NavigationService { get; }
    }
}
