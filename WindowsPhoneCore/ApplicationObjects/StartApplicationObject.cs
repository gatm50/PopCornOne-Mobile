using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using WindowsPhoneCore.ViewModels;

namespace WindowsPhoneCore.ApplicationObjects
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
