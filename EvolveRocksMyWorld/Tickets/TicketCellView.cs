using System;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace EvolveRocksMyWorld
{
    [Register("TicketCellView")]
    partial class TicketCellView : NSTableCellView
    {
        #region Constructors

        // Called when created from unmanaged code
        public TicketCellView(IntPtr handle)
            : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public TicketCellView(NSCoder coder)
            : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

    }
}

