﻿using System;
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
using Microsoft.Phone.Controls;
using Cirrious.MvvmCross.WindowsPhone.Views;
using WindowsPhoneCore.ViewModels;

namespace WindowsPhoneClient.Views
{
    public partial class MainView : BaseMainView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
    
    public class BaseMainView : MvxPhonePage<MainViewModel> { }
}