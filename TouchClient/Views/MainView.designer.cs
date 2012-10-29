// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace TouchClient
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		MonoTouch.UIKit.UITabBar tabViewA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITabBar tabViewB { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITabBar tabViewC { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView ViewA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView ViewB { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView ViewC { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtSearch { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSearch { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView tblAllLexical { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tabViewA != null) {
				tabViewA.Dispose ();
				tabViewA = null;
			}

			if (tabViewB != null) {
				tabViewB.Dispose ();
				tabViewB = null;
			}

			if (tabViewC != null) {
				tabViewC.Dispose ();
				tabViewC = null;
			}

			if (ViewA != null) {
				ViewA.Dispose ();
				ViewA = null;
			}

			if (ViewB != null) {
				ViewB.Dispose ();
				ViewB = null;
			}

			if (ViewC != null) {
				ViewC.Dispose ();
				ViewC = null;
			}

			if (txtSearch != null) {
				txtSearch.Dispose ();
				txtSearch = null;
			}

			if (btnSearch != null) {
				btnSearch.Dispose ();
				btnSearch = null;
			}

			if (tblAllLexical != null) {
				tblAllLexical.Dispose ();
				tblAllLexical = null;
			}
		}
	}
}
