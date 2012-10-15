using Android.App;
using Cirrious.MvvmCross.Binding.Android.Views;
using Core.ViewModels;

namespace AndroidClient.Views
{
    [Activity]
    class DetailView
        : MvxBindingActivityView<DetailViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.DetailView);
        }
    }
}