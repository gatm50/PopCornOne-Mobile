using Android.App;
using Cirrious.MvvmCross.Binding.Android.Views;
using Core.ViewModels;

namespace AndroidClient.Views
{
    [Activity]
    public class MainView
        : MvxBindingActivityView<MainViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.MainView);
        }
    }
}