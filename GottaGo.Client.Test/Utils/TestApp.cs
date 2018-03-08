using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace GottaGo.Client.Test.Utils
{
    
    public class TestApp
    {
        public IUnityContainer Container { get; }
        
        public TestApp()
        {
            Container = new UnityContainer();
        }

        public void RegsterTypes()
        {

        }
    }
}
