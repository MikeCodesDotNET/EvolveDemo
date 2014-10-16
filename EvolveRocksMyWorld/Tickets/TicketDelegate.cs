using MonoMac.AppKit;

namespace EvolveRocksMyWorld
{
    public class TicketDelegate : NSTableViewDelegate
    {
        public TicketDelegate(ZendeskApi_v2.Models.Tickets.GroupTicketResponse tickets)
        {
            _tickets = tickets;
        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, int row)
        {
            var cellView = tableView.MakeView("TicketCellView", this) as TicketCellView;

            cellView.lblSubject.StringValue = _tickets.Tickets[row].Subject;
            cellView.lblMessage.StringValue = _tickets.Tickets[row].Description;
            cellView.lblSentAt.StringValue = _tickets.Tickets[row].CreatedAt;

            return cellView;
        }

        ZendeskApi_v2.Models.Tickets.GroupTicketResponse _tickets;
    }
}

