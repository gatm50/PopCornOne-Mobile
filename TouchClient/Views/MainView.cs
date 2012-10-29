using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Core.ViewModels;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.Binding.Interfaces;
using System.Collections.Generic;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using System.Collections.ObjectModel;

namespace TouchClient
{
	public partial class MainView : MvxBindingTouchViewController<MainViewModel>
	{
		public MainView (MvxShowViewModelRequest request) : 
			base(request, "MainView", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);
			this.View.EndEditing(true);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			tabViewA.ItemSelected += (sender, e) => {
				this.SelectView (tabViewA.Items, tabViewA.SelectedItem);
			};

			tabViewB.ItemSelected += (sender, e) => {
				this.SelectView (tabViewB.Items, tabViewB.SelectedItem);
			};

			tabViewC.ItemSelected += (sender, e) => {
				this.SelectView (tabViewC.Items, tabViewC.SelectedItem);
			};

			this.AddBindings (
                new Dictionary<object, string> ()
                    {
                        { this.btnSearch, "{'TouchDown':{'Path':'SearchCommand'}}" },
						{ this.txtSearch, "{'Text':{'Path':'SearchTerm'}}" }		
                    }
			);
			this.SelectItemTabBar(0);
		}

		public void SelectView (UITabBarItem[] items, UITabBarItem selectedItem)
		{
			int index = 0;
			foreach (var item in items) {
				if (item == selectedItem)
					break;
				index++;
			}

			UIView result = null;
                
			switch (index) {
			case 0:
				result = this.ViewA;
				this.SelectItemTabBar(0);
				break;
			case 1:
				var tableSource = new TableViewSourceAllLexicalView (ViewModel.AllLexicals, this.ViewModel);
				tblAllLexical.Source = tableSource;
				tblAllLexical.ReloadData ();
				result = this.ViewB;

				this.SelectItemTabBar(1);
				break;
			case 2:
				result = this.ViewC;
				this.SelectItemTabBar(2);
				break;
			default:
				break;
			}



			this.View = result;
		}

		private void SelectItemTabBar (int index)
		{
				this.tabViewA.SelectedItem=tabViewA.Items[index];
				this.tabViewB.SelectedItem=tabViewB.Items[index];
				this.tabViewC.SelectedItem=tabViewC.Items[index];
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			if(UIInterfaceOrientation.Portrait == toInterfaceOrientation || 
			   UIInterfaceOrientation.PortraitUpsideDown == toInterfaceOrientation)
				return true;
			return false;
		}
	}

	public class TableViewSourceAllLexicalView : UITableViewSource
	{
		static readonly NSString CellIdentifier = new NSString ("ResultView");
		private ObservableCollection<string> _allLexicals;
		private MainViewModel _viewModel;

		public TableViewSourceAllLexicalView (ObservableCollection<string> allLexicals, MainViewModel viewModel)
		{
			_allLexicals = allLexicals;
			_viewModel = viewModel;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var reuse = tableView.DequeueReusableCell (CellIdentifier);
			if (reuse != null)
				return reuse;
	
			var toReturn = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier);
			toReturn.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			toReturn.TextLabel.Text = _allLexicals [indexPath.Row];
			toReturn.TextLabel.Lines = 0;
			return toReturn;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _allLexicals.Count;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			_viewModel.GoLexical_Execute(_allLexicals[indexPath.Row]);
		}
	}
}

