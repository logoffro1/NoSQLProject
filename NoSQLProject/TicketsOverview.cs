using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Service;
using Model;
using System.Drawing;
using System.Drawing.Design;
using System.Xml;
using System.CodeDom.Compiler;
using System.Diagnostics;

namespace NoSQLProject
{
    public partial class TicketsOverview : Form
    {
        private List<Ticket> tickets;
        private Ticket_Service ticketService;
        public TicketsOverview()
        {
            InitializeComponent();
            ticketService = new Ticket_Service();
            if (tickets == null)
                tickets = ticketService.GetAllTickets();
        }
        private void LoadListView()
        {
            listViewTickets.Items.Clear();

            foreach (ListViewItem item in GetFullListView().Items)
            {

                listViewTickets.Items.Add((ListViewItem)item.Clone());
            }

            ColorListRows();
            listViewTickets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private ListView GetFullListView()
        {

            ListView tempList = new ListView();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.ReportedByUser.username);
                item.SubItems.Add(ticket.IncidentDate.ToString("dd-MMM-yy"));
                item.SubItems.Add(ticket.Type.ToString());
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add(ticket.GetStatus());
                tempList.Items.Add(item);
            }
            return tempList;
        }
        private void ColorListRows() //color the status column/row
        {
            foreach (ListViewItem item in listViewTickets.Items)
            {
                item.UseItemStyleForSubItems = false;
                if (item.SubItems[6].Text.Equals("Open"))
                    item.SubItems[6].BackColor = Color.LightGreen;
                else
                    item.SubItems[6].BackColor = Color.PaleVioletRed;
            }
        }
        private Ticket GetTicketById(int id)
        {

            foreach (Ticket ticket in tickets)
                if (ticket.Id == id)
                    return ticket;

            return null;
        }
        private void TicketsOverview_Load(object sender, EventArgs e)
        {
            LoadListView();
            txtFilter.ForeColor = Color.Gray;
        }
        private void RemovePlaceholderText()
        {
            if (txtFilter.Text.Equals("Filter list..."))
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }

        }
        private void AddPlaceholderText()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Filter list...";
                txtFilter.ForeColor = Color.Gray;
            }

        }

        private void TicketsOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddTicketForm().Show();
        }

        private void listViewTickets_DoubleClick(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                Ticket ticket = GetTicketById(int.Parse(listViewTickets.SelectedItems[0].Text));
                new TicketInfoForm(ticket).ShowDialog();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (listViewTickets.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewTickets.CheckedItems)
                {
                    Ticket ticket = GetTicketById(int.Parse(item.SubItems[0].Text));
                    ticket.IsOpen = !ticket.IsOpen;
                    ticketService.UpdateTicket(ticket);
                    LoadListView();
                }
            }
            else
                MessageBox.Show("No tickets selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            RemovePlaceholderText();
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            AddPlaceholderText();
        }
        private void FilterList()
        {
            string filter = txtFilter.Text;
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ListViewItem item in GetFullListView().Items)
            {
                for (int i = 0; i < item.SubItems.Count; i++)
                    if (item.SubItems[i].Text.ToLower().Contains(filter.ToLower()))
                    {
                        items.Add(item);
                        break;
                    }
            }

            listViewTickets.Items.Clear();
            foreach (ListViewItem item in items)
                listViewTickets.Items.Add((ListViewItem)item.Clone());

            ColorListRows();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text != "Filter list...")
                FilterList();
        }
    }
}
