using System;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace EvolveRocksMyWorld
{
    partial class TicketCellView
    {
       [Outlet]
        public NSTextField lblSubject { get; private set;}

        [Outlet]
        public NSTextField lblSentAt { get; private set;}

        [Outlet]
        public NSTextField lblMessage { get; private set;}

        void ReleaseDesignerOutlets ()
        {
            if (lblSubject != null)
            {
                lblSubject.Dispose();
                lblSubject = null;
            }

            if (lblSentAt != null) {
                lblSentAt.Dispose ();
                lblSentAt = null;
            }

            if (lblMessage != null) {
                lblMessage.Dispose ();
                lblMessage = null;
            }
        }
    }
}

