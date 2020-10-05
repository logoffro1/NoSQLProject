using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;
namespace NoSQLProject
{
    public partial class TicketsOverview : Form
    {
        public TicketsOverview()
        {
            InitializeComponent();
        }
        private void LoadListView()
        {
            Ticket_Service ticketService = new Ticket_Service();

            foreach(Ticket ticket in ticketService.GetAllTickets())
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add("Username");
                item.SubItems.Add(ticket.IncidentDate.ToString());
                item.SubItems.Add(ticket.Type.ToString());
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add(ticket.GetStatus());
                listViewTickets.Items.Add(item);
            }
            
            listViewTickets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
           
        }
        private void TicketsOverview_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void TicketsOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            //User_Service userService = new User_Service();
            //Ticket_Service ticketService = new Ticket_Service();
            //User testUser = new User
            //{
            //    id = 999,
            //    username = "user",
            //    password = "pass",
            //    firstName = "Alex",
            //    lastName = "John",
            //    email = "alex@gmail.com",
            //    nrTickets = 0
            //};
            //Ticket ticket = new Ticket
            //{
            //    ReportedByUser = testUser,
            //    IncidentDate = DateTime.Now,
            //    Subject = "Crash",
            //    IsOpen = true,
            //    Type = TicketIncidentType.Software,
            //    Priority = TicketPriorityType.Normal,
            //    Description = "My program crashed wtffff",
            //    Deadline = TicketDeadline.SevenDays
            //};
            //ticketService.AddTicket(ticket);
            this.Hide();
            new AddTicketForm().Show();
        }
    }
}
