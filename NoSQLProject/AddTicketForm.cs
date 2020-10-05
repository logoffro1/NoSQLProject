using Model;
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
    public partial class AddTicketForm : Form
    {
        User_Service userService = new User_Service();
        List<User> users = new List<User>();
        public AddTicketForm()
        {
            InitializeComponent();
        }

        private void AddTicketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void SetDefaultFields()
        {
            dateReported.Value = DateTime.Now;
            dateReported.MaxDate = DateTime.Now;

            #region Incident type combo box
            cmbType.Items.Add("Select type");
            foreach (TicketIncidentType type in Enum.GetValues(typeof(TicketIncidentType)))
            {
                cmbType.Items.Add(type);
            }
            cmbType.SelectedIndex = 0;
            #endregion

            #region Incident snitch combo box
            users = userService.getAllUsers();
            foreach (User user in users)
            {
                cmbSnitch.Items.Add(user.username);
            }
            cmbSnitch.SelectedIndex = 0;
            #endregion

            #region Incident priority combo box
            foreach (TicketPriorityType priority in Enum.GetValues(typeof(TicketPriorityType)))
            {
                cmbPriority.Items.Add(priority);
            }
            cmbPriority.SelectedIndex = 1;
            #endregion

            #region Incident deadline combo box
            foreach (TicketDeadline deadline in Enum.GetValues(typeof(TicketDeadline)))
            {
                cmbDeadline.Items.Add($"{(int)deadline} days");
            }
            cmbDeadline.SelectedIndex = 0;
            #endregion


        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CanCreateTicket())
                CreateTicket();
            else
                MessageBox.Show("All fields must be completed!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        private bool CanCreateTicket()
        {
            if (dateReported.Value == null)
                return false;
            if (String.IsNullOrEmpty(txtSubject.Text))
                return false;
            else if (!(cmbType.SelectedIndex > 0))
                return false;
            else if (!(cmbSnitch.SelectedIndex > -1))
                return false;
            else if (!(cmbPriority.SelectedIndex >= -1))
                return false;
            else if (!(cmbDeadline.SelectedIndex >= -1))
                return false;

            return true;
        }
        private void CreateTicket()
        {
            Ticket_Service ticketService = new Ticket_Service();

            Ticket ticket = new Ticket
            {
                ReportedByUser = GetUserByUsername(),
                IncidentDate = dateReported.Value,
                Subject = txtSubject.Text,
                Type = (TicketIncidentType)cmbType.SelectedItem,
                Priority = (TicketPriorityType)cmbPriority.SelectedItem,
                Description = txtDescription.Text,
                Deadline = (TicketDeadline)cmbDeadline.SelectedIndex,
                IsOpen = true
               
            };
            ticketService.AddTicket(ticket);
        }
        private User GetUserByUsername()
        {
            foreach (User user in users)
                if (user.username.Equals(cmbSnitch.SelectedItem.ToString()))
                    return user;

            return null;
        }
        private void AddTicketForm_Load(object sender, EventArgs e)
        {
            SetDefaultFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TicketsOverview().Show();
        }
    }
}
