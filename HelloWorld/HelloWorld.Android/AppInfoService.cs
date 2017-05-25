using HelloWorld.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppInfoService))]
namespace HelloWorld.Droid
{
    class AppInfoService : IAppInfoService
    {
        public string AppVersion
        {
            get
            {
                var context = Forms.Context;
                return context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionCode.ToString();
            }
        }
    }
}