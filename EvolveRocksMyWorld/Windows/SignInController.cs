
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace EvolveRocksMyWorld
{
    public partial class SignInController : MonoMac.AppKit.NSWindowController
    {
        #region Constructors

        // Called when created from unmanaged code
        public SignInController(IntPtr handle)
            : base(handle)
        {
            Initialize();
        }
        
        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public SignInController(NSCoder coder)
            : base(coder)
        {
            Initialize();
        }
        
        // Call to load from the XIB/NIB file
        public SignInController()
            : base("SignIn")
        {
            Initialize();
        }
        
        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        //strongly typed window accessor
        public new SignIn Window
        {
            get
            {
                return (SignIn)base.Window;
            }
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            tbxEmail.EditingEnded += FetchAvatar;
            btnCancel.Activated += delegate
            {
                this.Close();
            };
        }

        async void FetchAvatar (object sender, EventArgs e)
        {
            imgAvatar.Image = !string.IsNullOrEmpty(tbxEmail.StringValue) ? await Gravatar.GravatarService.GetGravatar(tbxEmail.StringValue) : new NSImage();
        }

        partial void btnSign_Activated(MonoMac.AppKit.NSButton sender)
        {
            if((!string.IsNullOrEmpty(tbxEmail.StringValue)) && (!string.IsNullOrEmpty(tbxPassword.StringValue)) && (!string.IsNullOrEmpty(tbxUrl.StringValue)))
            {
                var api = new ZendeskApi_v2.ZendeskApi(tbxUrl.StringValue, tbxEmail.StringValue, tbxPassword.StringValue);

                try
                {
                    var user =  api.Users.GetCurrentUser();
                    if(user.User.Verified == true)
                    {
                        var mainWindowController = new MainWindowController(api);
                        mainWindowController.ShowWindow(this);
                        this.Close();
                    }
                    else
                    {
                        Whoops();
                    }
                }
                catch (Exception ex)
                {
                    Whoops();
                    Console.WriteLine(ex.Message);
                }
            }
        }

        void Whoops()
        {
            Window.Animations = NSDictionary.FromObjectAndKey(ShakeIt.ShakeAnimation(this.Window.Frame), new NSString(@"frameOrigin"));
            ((NSWindow)this.Window.Animator).SetFrameOrigin(Window.Frame.Location);
            Console.WriteLine("Whoops");
        }
    }
}

