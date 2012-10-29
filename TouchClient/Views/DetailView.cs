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
using Core.Models;

namespace TouchClient
{
	public partial class DetailView : MvxBindingTouchTableViewController<DetailViewModel>
	{
		public DetailView (MvxShowViewModelRequest request)
          : base(request)
		{
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			var tableSource = new TableViewSourceDetailView (TableView);
          
			this.AddBindings (
                new Dictionary<object, string> ()
                    {
                        { tableSource, "{'ItemsSource':{'Path':'Results'}}" }
                    }
			);

			TableView.AllowsSelection = false;
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

	public sealed class TableViewCellDetailView
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

		public TableViewCellDetailView (UITableViewCellStyle cellStyle, NSString cellIdentifier)
                		: base(BindingDescriptions, cellStyle, cellIdentifier)
		{
			Accessory = UITableViewCellAccessory.None;
		}
	}

	public class TableViewSourceDetailView : MvxBindableTableViewSource
	{
		static readonly NSString CellIdentifier = new NSString ("ResultView");

		public TableViewSourceDetailView (UITableView tableView)
                : base(tableView)
		{
		}

		protected override UITableViewCell GetOrCreateCellFor (UITableView tableView, NSIndexPath indexPath, object item)
		{
			var reuse = tableView.DequeueReusableCell (CellIdentifier);
			if (reuse != null)
				return reuse;
	
			var toReturn = new TableViewCellDetailView (UITableViewCellStyle.Subtitle, CellIdentifier);

			toReturn.TitleText = (item as CompleteTranslation).Translation.TranslationContent;
			toReturn.TextLabel.Lines = 0;
			toReturn.DetailText = (item as CompleteTranslation).Translation.TranslationDescription;
			toReturn.DetailTextLabel.Lines = 0;

			return toReturn;
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			var res = this.GetCell (tableView, indexPath);
			double numberOfLinesTitle = Math.Ceiling (res.TextLabel.Text.Length / 29.0d);
			double numberOfLinesDetail = Math.Ceiling (res.DetailTextLabel.Text.Length / 29.0d);

			return (float)(numberOfLinesTitle * 35.0f + numberOfLinesDetail * 20.0f);
		}
	}
}

