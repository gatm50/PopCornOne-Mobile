
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using TouchClient.Controllers;
using Cirrious.MvvmCross.Touch.Interfaces;

namespace TouchClient
{
//    public class ClientPresenter
//        : MvxModalSupportTouchViewPresenter
//        , ITabBarPresenterHost
//    {
//        public ClientPresenter(UIApplicationDelegate applicationDelegate, UIWindow window)
//            : base(applicationDelegate, window)
//        {
//        }
//
//        protected override UINavigationController CreateNavigationController(UIViewController viewController)
//        {
//            var toReturn = base.CreateNavigationController(viewController);
//            toReturn.NavigationBarHidden = true;
//            return toReturn;
//        }
//
//        public ITabBarPresenter TabBarPresenter { get; set; }
//
//        public override void Show(IMvxTouchView view)
//        {
//            if (TabBarPresenter != null && view != TabBarPresenter)
//            {
//                TabBarPresenter.ShowView(view);
//                return;
//            }
//
//            base.Show(view);
//        }
//    }
}
