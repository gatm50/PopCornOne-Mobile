using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.ViewModels;
using Core.ViewModels;

namespace Core.ApplicationObjects
{
    public class StartApplicationObject :
        MvxApplicationObject
        , IMvxStartNavigation
    {
        public void Start()
        {
            this.RequestNavigate<MainViewModel>();
        }

        public bool ApplicationCanOpenBookmarks
        {
            get { return true; }
        }
    }
}
