using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Microsoft.Phone.Controls;

namespace DemoDataBoundApp.Common
{
    class NavigationService : INavigationService
    {
        public PhoneApplicationFrame RootFrame { get; private set; }

        public NavigationService()
        {
            RootFrame = App.RootFrame;
        }

        public void Navigate<T>()
        {
            var type = typeof(T);

            var path = type.FullName.Substring(type.FullName.IndexOf('.')).Replace('.', '/') + ".xaml";

            RootFrame.Navigate(new Uri(path, UriKind.Relative));
        }
    }
}
