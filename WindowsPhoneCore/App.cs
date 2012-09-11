using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.ExtensionMethods;
using WindowsPhoneCore.ApplicationObjects;

namespace WindowsPhoneCore
{
    public class App
        : MvxApplication
        , IMvxServiceProducer<IMvxStartNavigation>
    {
        public App()
        {
            var startApplicationObject = new StartApplicationObject();
            this.RegisterServiceInstance<IMvxStartNavigation>(startApplicationObject);
        }
    }
}
