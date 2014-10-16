
using System;
using MonoMac.Foundation;

namespace EvolveRocksMyWorld
{
    public partial class MainWindowController : MonoMac.AppKit.NSWindowController
    {
        #region Constructors

        // Called when created from unmanaged code
        public MainWindowController(IntPtr handle)
            : base(handle)
        {
            Initialize();
        }
        
        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public MainWindowController(NSCoder coder)
            : base(coder)
        {
            Initialize();
        }
        
        // Call to load from the XIB/NIB file
        public MainWindowController(ZendeskApi_v2.ZendeskApi api)
            : base("MainWindow")
        {
            _api = api;
            Initialize();
        }
        
        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        //strongly typed window accessor
        public new MainWindow Window
        {
            get
            {
                return (MainWindow)base.Window;
            }
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            _tickets = _api.Tickets.GetAllTickets();

            _ticketDatasource = new TicketDataSource(_tickets);
            _ticketDelegate = new TicketDelegate(_tickets);

            tableView.DataSource = _ticketDatasource;
            tableView.Delegate = _ticketDelegate;
            tableView.ReloadData();
        }

        ZendeskApi_v2.ZendeskApi _api;
        ZendeskApi_v2.Models.Tickets.GroupTicketResponse _tickets;
        TicketDataSource _ticketDatasource;
        TicketDelegate _ticketDelegate;
    }
}

