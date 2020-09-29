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

        private void button1_Click(object sender, EventArgs e)
        {
            User_Service userService = new User_Service();
            Ticket_Service ticketService = new Ticket_Service();
            User testUser = new User
            {
                id = 999,
                username = "user",
                password = "pass",
                firstName = "Alex",
                lastName = "John",
                email = "alex@gmail.com",
                nrTickets = 0
            };
            Ticket ticket = new Ticket
            {
                reportedByUser = testUser,
                incidentDate = DateTime.Now,
                subject = "Crash",
                type = TicketIncidentType.Software,
                priority = TicketPriorityType.Normal,
                description = "My program crashed wtffff",
                deadline = TicketDeadline.SevenDays
            };
            ticketService.AddTicket(ticket);
        }

        private void TicketsOverview_Load(object sender, EventArgs e)
        {

        }

        private void TicketsOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
