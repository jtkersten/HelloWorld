using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using HelloWorld.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppInfoService))]
namespace HelloWorld.UWP
{
    public class AppInfoService : IAppInfoService
    {
        public string AppVersion
        {
            get
            {
                var package = Package.Current;
                var packageId = package.Id;
                var version = packageId.Version;

                return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
            }
        }
    }
}
