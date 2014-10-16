using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace EvolveRocksMyWorld
{
    public partial class AppDelegate : NSApplicationDelegate
    {
        SignInController signInController;

        public AppDelegate()
        {
        }

        public override void FinishedLaunching(NSObject notification)
        {
            signInController = new SignInController();
            signInController.Window.MakeKeyAndOrderFront(this);
        }
    }
}

