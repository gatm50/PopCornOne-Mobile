using System;
using System.Collections.Generic;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.Touch.ExtensionMethods;
using Cirrious.MvvmCross.Touch.Interfaces;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Core.ViewModels;
//using TouchClient.Controllers;

namespace TouchClient
{
//    public class TabBarController
//        : MvxTouchTabBarViewController<MainViewModel>
//        , ITabBarPresenter
//        , IMvxServiceConsumer<ITabBarPresenterHost>
//    {
//        private bool _needViewDidLoadCall = false;
//
//        public TabBarController(MvxShowViewModelRequest request)
//            : base(request)
//        {
//            this.GetService<ITabBarPresenterHost>().TabBarPresenter = this;
//            if (_needViewDidLoadCall)
//                ViewDidLoad();
//        }
//
//        private int _createdSoFarCount = 0;
//
//        private UIViewController CreateTabFor(string title, string imageName, IMvxViewModel viewModel)
//        {
//            var controller = new UINavigationController();
//            controller.NavigationBar.TintColor = UIColor.Black;
//            var screen = this.CreateViewControllerFor(viewModel) as UIViewController;
//            SetTitleAndTabBarItem(screen, title, imageName);
//            controller.PushViewController(screen, false);
//            return controller;
//        }
//
//        private void SetTitleAndTabBarItem(UIViewController screen, string title, string imageName)
//        {
//            screen.Title = "A TEST";
//            screen.TabBarItem = new UITabBarItem(title, UIImage.FromBundle("Images/Tabs/" + imageName + ".png"),
//                                                 _createdSoFarCount);
//            _createdSoFarCount++;
//        }
//
//        public override void ViewDidLoad()
//        {
//            base.ViewDidLoad();
//
//            if (ViewModel == null)
//            {
//                _needViewDidLoadCall = true;
//                return;
//            }
//
//            _needViewDidLoadCall = false;
//
//            var viewControllers = new UIViewController[]
//                                  {
//				new MainView(),
//                                  };
//            ViewControllers = viewControllers;
//            CustomizableViewControllers = new UIViewController[] { };
//            SelectedViewController = ViewControllers[0];
//        }
//
//        /// <summary>
//        /// Only allow iPad application to rotate, iPhone is always portrait
//        /// </summary>
//        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
//        {
//            return toInterfaceOrientation == UIInterfaceOrientation.Portrait;
//        }
//
//        public bool GoBack()
//        {
//            var subNavigation = this.SelectedViewController as UINavigationController;
//            if (subNavigation == null)
//                return false;
//
//            if (subNavigation.ViewControllers.Length <= 1)
//                return false;
//
//            subNavigation.PopViewControllerAnimated(true);
//            return true;
//        }
//
//        public bool ShowView(IMvxTouchView view)
//        {
//            if (TryShowViewInCurrentTab(view))
//                return true;
//
//            return false;
//        }
//
//        private bool TryShowViewInCurrentTab(IMvxTouchView view)
//        {
//            var navigationController = (UINavigationController)this.SelectedViewController;
//            navigationController.PushViewController((UIViewController)view, true);
//            return true;
//        }
//    }
}

