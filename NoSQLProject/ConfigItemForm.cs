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

        public ConfigItemForm()
        {
            InitializeComponent();
        }

        private void buttonAddConfigItem_Click(object sender, EventArgs e)
        {
            String name = textBoxCIName.Text;
            String description = textBoxCIDescription.Text;
            int owner = int.Parse(comboBoxOwner.SelectedItem.ToString().Split(' ')[0]);
            MessageBox.Show(comboBoxOwner.SelectedItem.ToString().Split(' ')[0]); // Doesn't Work
            String location = textBoxLocation.Text;
            TicketPriorityType importance = (TicketPriorityType) comboBoxImportance.SelectedItem;
            ConfigurationItem configurationItem = new ConfigurationItem(name, description, owner, location, importance); 
            //MessageBox.Show(configurationItem.ToString()); // Successfully added
            configItemService.AddConfigItem(configurationItem);
            this.Close();
        }

        private void ConfigItemForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
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
        }
    }
}