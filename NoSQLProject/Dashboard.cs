using Model;
using MongoDB.Bson;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSQLProject
{
    //Emre Kutuk
    public partial class Dashboard : Form
    {
        Ticket_Service ticket_Service = new Ticket_Service();
        User_Service user_Service = new User_Service();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Initialize();
        }

        private void Initialize()
        {
            DisplayPriorityTexts();
            DisplayDeadlineText();
            DisplayStatusTex();
        }

        private void DisplayStatusTex()
        {
            //gets the nr of users and nr of tickets
            List<User> allUsers = user_Service.getAllUsers();
            List<Ticket> allTickets = ticket_Service.GetAllTickets();

            //checks if there are more tickets than users and displays the status accordingly
            if (allUsers.Count < allTickets.Where(t => t.IsOpen).ToList().Count)
            {
                lblStatus.Text = $"Status: Busy";
                lblStatus.ForeColor = Color.Red;
            }
            else
            { 
                lblStatus.Text = $"Status: Normal";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void DisplayDeadlineText()
        {
            List<Ticket> allTickets = ticket_Service.GetAllTickets();

            //gets the nr of tickets that are over their deadline
            int overDeadlineTicketNr = allTickets.Where(t => t.Deadline < DateTime.Now && t.IsOpen).ToList().Count;
            lblUrgentTickets.Text = $"There are {overDeadlineTicketNr} ticket(s) that needs urgent attention!";

            //if there are more than 3 tickets that over their deadline, the color becomes red
            if (overDeadlineTicketNr <= 3)
                lblUrgentTickets.ForeColor = Color.Green;
            else
                lblUrgentTickets.ForeColor = Color.Red;
        }
        private void DisplayPriorityTexts()
        {
            List<Ticket> allTickets = ticket_Service.GetAllTickets();

            //gets the nr of open tickets for each priority
            int highPriorityTicketNr = allTickets.Where(t => t.Priority == TicketPriorityType.High).Where(t => t.IsOpen).ToList().Count;
            int normalPriorityTicketNr = allTickets.Where(t => t.Priority == TicketPriorityType.Normal).Where(t => t.IsOpen).ToList().Count;
            int lowPriorityTicketNr = allTickets.Where(t => t.Priority == TicketPriorityType.Low).Where(t => t.IsOpen).ToList().Count;

            lblHighPriorityTickets.Text = $"Tickets with high priority; {highPriorityTicketNr}";
            lblNormalPriorityTickets.Text = $"Tickets with normal priority; {normalPriorityTicketNr}";
            lblLowPriorityTickets.Text = $"Tickets with low priority; {lowPriorityTicketNr}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }
    }
}
