using System;
using System.Collections.Generic;
using Cirrious.MvvmCross.Binding.Interfaces;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Core.ViewModels;
using Cirrious.MvvmCross.Touch.Views;
using Core.TranslationReference;

namespace TouchClient
{
	public partial class ResultView : MvxBindingTouchTableViewController<ResultViewModel>
	{
		public ResultView (MvxShowViewModelRequest request)
          : base(request)
		{
			tblResult= new UITableView();
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var tableSource = new TableViewSourceResultView (TableView);
			tableSource.SelectionChanged += (sender, args) => ViewModel.GoPhrase_Execute ((Translation)args.AddedItems [0]);
          
			this.AddBindings (
                new Dictionary<object, string> ()
                    {
                        { tableSource, "{'ItemsSource':{'Path':'Results'}}" }
                    }
			);
			TableView.Source=tableSource;
			TableView.ReloadData();

			TableView.Source = tableSource;
			TableView.ReloadData ();
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			if(UIInterfaceOrientation.Portrait == toInterfaceOrientation || 
			   UIInterfaceOrientation.PortraitUpsideDown == toInterfaceOrientation)
				return true;
			return false;
		}
	}

	public sealed class TableViewCellResultView
  				        : MvxBindableTableViewCell
	{
		public static readonly MvxBindingDescription[] BindingDescriptions
             = new[]
             {
             	new MvxBindingDescription ()
	             {
		             TargetName = "TextLabel.Text",
		             SourcePropertyPath = "TranslationContent"
	             },
             };

		public TableViewCellResultView(UITableViewCellStyle cellStyle, NSString cellIdentifier)
                		: base(BindingDescriptions, cellStyle, cellIdentifier)
		{
			Accessory = UITableViewCellAccessory.DisclosureIndicator;
		}
	}

	public class TableViewSourceResultView : MvxBindableTableViewSource
	{
		static readonly NSString CellIdentifier = new NSString ("ResultView");

		public TableViewSourceResultView (UITableView tableView)
                : base(tableView)
		{
		}

		protected override UITableViewCell GetOrCreateCellFor (UITableView tableView, NSIndexPath indexPath, object item)
		{
			var reuse = tableView.DequeueReusableCell (CellIdentifier);
			if (reuse != null)
				return reuse;
	
			var toReturn = new TableViewCellResultView (UITableViewCellStyle.Default, CellIdentifier);
			toReturn.TextLabel.Text= (item as Translation).TranslationContent;
			return toReturn;
		}
	}
}

