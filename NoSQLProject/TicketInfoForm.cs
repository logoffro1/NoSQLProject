﻿using System.Windows.Forms;
using Model;
using Service;

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

            if (ticket.IsOpen)
            {
                btnTransfer.Enabled = true;
            }
            else
            {
                btnTransfer.Enabled = false;
            }
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            TransferTicketsUI ticketsUI = new TransferTicketsUI(ticket);
            ticketsUI.ShowDialog();

            //after here we should update the ticket form (name of the user stays the same) but I didnt want to ask stuff to your code without asking bro so ill wait -ege
        }
    }
}
