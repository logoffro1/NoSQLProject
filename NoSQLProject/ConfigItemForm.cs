using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Model;
using Service;

namespace NoSQLProject
{
    public partial class ConfigItemForm : Form
    {
        ConfigurationItem_Service configItemService = new ConfigurationItem_Service();
        private ConfigurationItem ci;

        public ConfigItemForm()
        {
            InitializeComponent();
        }

        public ConfigItemForm(ConfigurationItem ci)
        {
            InitializeComponent();
            this.ci = ci;
        }

        private void buttonAddConfigItem_Click(object sender, EventArgs e)
        {
            if (textBoxCIName.Text.Equals("") || textBoxCIDescription.Text.Equals("") ||
                comboBoxOwner.SelectedItem == null || textBoxLocation.Text.Equals("") ||
                comboBoxImportance.SelectedItem == null)
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            if (ci == null)
            {
                ci = new ConfigurationItem(textBoxCIName.Text, textBoxCIDescription.Text,
                    int.Parse(comboBoxOwner.SelectedItem.ToString().Split(' ')[0]),
                    textBoxLocation.Text,
                    (TicketPriorityType) comboBoxImportance.SelectedIndex);
            }
            else
            {
                ci.Name = textBoxCIName.Text;
                ci.Description = textBoxCIDescription.Text;
                ci.Owner = int.Parse(comboBoxOwner.SelectedItem.ToString().Split(' ')[0]);
                ci.Location = textBoxLocation.Text;
                ci.Importance = (TicketPriorityType) comboBoxImportance.SelectedIndex;
            }


            if (buttonAddConfigItem.Text.Equals("Update"))
            {
                configItemService.UpdateConfigItem(ci);
            }
            else
            {
                configItemService.AddConfigItem(ci);
            }

            MessageBox.Show($"Configuration Item Added\n{ci.ToString()}"); // Successfully added
            ConfigItemUi ciForm = (ConfigItemUi) Application.OpenForms["ConfigItemUI"];
            ciForm.UpdateList();
            this.Close();
        }

        private void ConfigItemForm_Load(object sender, EventArgs e)
        {
            User_Service userService = new User_Service();
            List<User> userList = userService.getAllUsers();

            comboBoxOwner.BeginUpdate();
            foreach (User user in userList)
            {
                string name = $"{user.id} {user.firstName} {user.lastName}";
                comboBoxOwner.AutoCompleteCustomSource.Add(name); // Allows the user to search the combobox by typing
                comboBoxOwner.Items.Add(name);
                comboBoxOwner.ValueMember = user.id.ToString(); // Stores ID of user for later retrieval
            }

            comboBoxOwner.EndUpdate();
            comboBoxOwner.SelectedIndex = 0;

            comboBoxImportance.Items.Add(TicketPriorityType.Low);
            comboBoxImportance.Items.Add(TicketPriorityType.Normal);
            comboBoxImportance.Items.Add(TicketPriorityType.High);
            comboBoxImportance.SelectedIndex = 0;

            if (ci != null)
            {
                buttonAddConfigItem.Text = "Update";
                this.Text = "Edit Configuration Item";
                textBoxCIDescription.Text = ci.Description;
                textBoxCIName.Text = ci.Name;
                textBoxLocation.Text = ci.Location;
                comboBoxImportance.SelectedIndex = (int) ci.Importance;
                comboBoxOwner.SelectedIndex = ci.Owner;
            }
            else
            {
                buttonAddConfigItem.Text = "Add";
                this.Text = "Ädd New Configuration Item";
            }
        }
    }
}