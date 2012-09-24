using Android.App;
using Cirrious.MvvmCross.Binding.Android.Views;
using Core.ViewModels;

namespace AndroidClient.Views
{
    [Activity]
    class ResultView
        : MvxBindingActivityView<ResultViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.ResultView);
        }
    }
}