// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace EvolveRocksMyWorld
{
	[Register ("SignInController")]
	partial class SignInController
	{
		[Outlet]
		MonoMac.AppKit.NSButton btnCancel { get; set; }

		[Outlet]
		MonoMac.AppKit.NSImageView imgAvatar { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField tbxEmail { get; set; }

		[Outlet]
		MonoMac.AppKit.NSSecureTextField tbxPassword { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField tbxUrl { get; set; }

		[Action ("btnSign_Activated:")]
		partial void btnSign_Activated (MonoMac.AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (imgAvatar != null) {
				imgAvatar.Dispose ();
				imgAvatar = null;
			}

			if (tbxUrl != null) {
				tbxUrl.Dispose ();
				tbxUrl = null;
			}

			if (tbxEmail != null) {
				tbxEmail.Dispose ();
				tbxEmail = null;
			}

			if (tbxPassword != null) {
				tbxPassword.Dispose ();
				tbxPassword = null;
			}

			if (btnCancel != null) {
				btnCancel.Dispose ();
				btnCancel = null;
			}
		}
	}

	[Register ("SignIn")]
	partial class SignIn
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
