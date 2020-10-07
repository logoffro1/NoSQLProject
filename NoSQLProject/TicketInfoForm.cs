using System.Windows.Forms;
using Model;
namespace NoSQLProject
{
    public partial class TicketInfoForm : Form
    {
        private Ticket ticket;
        public TicketInfoForm(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;

            if (ticket != null)
                DisplayInfo();
        }
        private void DisplayInfo()
        {
            lblId.Text = $"ID: {ticket.Id}";
            lblSubject.Text = $"Subject: {ticket.Subject}";
            lblSnitch.Text = $"Reported by: {ticket.ReportedByUser.username}({ticket.ReportedByUser.id})";
            lblDate.Text = $"Date: {ticket.IncidentDate}";
            lblType.Text = $"Type: {ticket.Type}";
            lblPriority.Text = $"Priority: {ticket.Priority}";
            lblDeadline.Text = $"Deadline: {ticket.Deadline.ToString("dd-MMM-yy")}";
            lblStatus.Text = $"Status: {ticket.GetStatus()}";
            lblDescription.Text = $"Description: {ticket.Description}";
        }
        private void btnReturn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
