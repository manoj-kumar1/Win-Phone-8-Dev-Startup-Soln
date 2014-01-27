using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataBoundApp.Common
{
    public interface INavigationService
    {
        void Navigate<T>();
    }
}
