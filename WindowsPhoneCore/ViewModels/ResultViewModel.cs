﻿using System;
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
using System.Collections.ObjectModel;

namespace WindowsPhoneCore.ViewModels
{
    public class ResultViewModel : MvxViewModel
    {
        public ObservableCollection<string> Results;

        public ResultViewModel(string lexicon = "")
        {
            this.Results = new ObservableCollection<string>();
        }
    }
}