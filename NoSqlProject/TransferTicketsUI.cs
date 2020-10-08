﻿using Model;
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
    // This part is Egehan Cinarli's [641716] individual part which is transfering the tickets from one user to another. 
    // As requested a separate class is created for this function.
    public partial class TransferTicketsUI : Form
    {

        private Ticket ticket;
        private Ticket_Service ticketService;
        private User_Service userService;
        private List<User> users;
        public TransferTicketsUI(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
            this.ticketService = new Ticket_Service();
            this.userService = new User_Service();
            users = userService.getAllUsers();

        }

        private void TransferTicketsUI_Load(object sender, EventArgs e)
        {
            FillComboBox();
            UpdateFields();
        }

        private void UpdateFields()
        {
            lblDeadline.Text = "Deadline: "+ticket.Deadline.ToString("dd-MMM-yy");
            lblPriority.Text = "Priority: "+ticket.Priority.ToString();
            lblOldUser.Text = "Reported by(old): " + ticket.ReportedByUser.firstName + " " + ticket.ReportedByUser.lastName;
            lblDescriptionFlow.Text = ticket.Description;

        }

        private void FillComboBox()
        {
            cmbUsers.Items.Clear();
           foreach(User u in users)
            {
                cmbUsers.Items.Add($"{u.id}. {u.firstName} {u.lastName}");
            }
            cmbUsers.SelectedIndex= 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User oldUser = ticket.ReportedByUser;
            string [] selectedUser = cmbUsers.SelectedItem.ToString().Split('.');
            int id = int.Parse(selectedUser[0]);
            User newUser = userService.GetUserById(id);

            if (oldUser.id != newUser.id)
            {
                try
                {
                    if (oldUser.nrTickets > 0)
                    {
                        oldUser.nrTickets--;
                        newUser.nrTickets++;
                        userService.UpdateUserTickets(oldUser);
                        userService.UpdateUserTickets(newUser);
                    }                

                    ticket.ReportedByUser = newUser;
                    ticketService.UpdateTicketUser(ticket);
                    MessageBox.Show("User of the ticket is updated", "Transfer completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Something went wrong:{exception.Message}");
                }
                finally
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please do not pick the same user ", "Transfer failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
