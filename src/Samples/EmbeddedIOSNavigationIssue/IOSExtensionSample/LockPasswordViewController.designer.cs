// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Bit.iOS.Autofill
{
	[Register ("LockPasswordViewController")]
	partial class LockPasswordViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIBarButtonItem CancelButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UINavigationItem NavItem { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIBarButtonItem SubmitButton { get; set; }

		[Action ("AccountSwitchingBarButton_Activated:")]
		partial void AccountSwitchingBarButton_Activated (UIKit.UIBarButtonItem sender);

		[Action ("CancelButton_Activated:")]
		partial void CancelButton_Activated (UIKit.UIBarButtonItem sender);

		[Action ("SubmitButton_Activated:")]
		partial void SubmitButton_Activated (UIKit.UIBarButtonItem sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}

			if (NavItem != null) {
				NavItem.Dispose ();
				NavItem = null;
			}

			if (SubmitButton != null) {
				SubmitButton.Dispose ();
				SubmitButton = null;
			}
		}
	}
}
