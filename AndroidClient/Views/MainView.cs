using Android.App;
using Android.Content;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Android.Views;
using Core.ViewModels;
using Android.Views;

namespace AndroidClient.Views
{
    [Activity]
    public class MainView : MvxBindingActivityView<MainViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.MainView);

            TabHost mTabHost = (TabHost)base.FindViewById(Resource.Id.tabHost);
            mTabHost.Setup();

            try
            {
                TabHost.TabSpec spec1 = mTabHost.NewTabSpec("welcome");
                spec1.SetIndicator("Welcome", Resources.GetDrawable(Resource.Drawable.Tab_Welcome));
                int viewId = Resource.Id.tab1;
                spec1.SetContent(viewId);
                mTabHost.AddTab(spec1);

                TabHost.TabSpec spec2 = mTabHost.NewTabSpec("alphabetical");
                spec2.SetIndicator("All Lexical", Resources.GetDrawable(Resource.Drawable.Tab_Sessions));
                spec2.SetContent(Resource.Id.tab2);
                mTabHost.AddTab(spec2);  
            }
            catch (Java.Lang.NullPointerException ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
        }
    }
}