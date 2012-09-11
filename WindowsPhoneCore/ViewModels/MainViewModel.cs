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
using Cirrious.MvvmCross.Interfaces.Commands;
using Cirrious.MvvmCross.Commands;

namespace WindowsPhoneCore.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public IMvxCommand SearchCommand
        {
            get
            {
                return new MvxRelayCommand(() => RequestNavigate<ResultViewModel>(new { lexicon = "XD", id=10 }));
            }
        }
    }
}
