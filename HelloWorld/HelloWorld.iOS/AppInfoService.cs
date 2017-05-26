using Foundation;
using HelloWorld.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(AppInfoService))]
namespace HelloWorld.iOS
{
    public class AppInfoService : IAppInfoService
    {
        public string AppVersion
        {
            get
            {
                NSObject version = NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"];
                return version.ToString();
            }
        }
    }
}