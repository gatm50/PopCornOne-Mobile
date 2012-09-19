using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Microsoft.Phone.Controls;
using Core.ViewModels;

namespace WindowsPhoneClient.Views
{
    public partial class ResultView : BaseResultView
    {
        public ResultView()
        {
            InitializeComponent();
        }
    }
    public class BaseResultView : MvxPhonePage<ResultViewModel> { }
}