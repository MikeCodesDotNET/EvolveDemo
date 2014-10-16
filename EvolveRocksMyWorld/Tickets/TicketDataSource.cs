using MonoMac.AppKit;

namespace EvolveRocksMyWorld
{
    public class TicketDataSource : NSTableViewDataSource
    {
        public TicketDataSource(ZendeskApi_v2.Models.Tickets.GroupTicketResponse tickets)
        {
            _tickets = tickets;
        }

        public override int GetRowCount(NSTableView tableView)
        {
            return _tickets.Count;
        }

        ZendeskApi_v2.Models.Tickets.GroupTicketResponse _tickets;
    }
}

