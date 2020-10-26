using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NoSQLProject
{
    public partial class ConfigItemUi : Form
    {
        public ConfigItemUi()
        {
            InitializeComponent();
        }

        private void NewConfigItem_Click(object sender, EventArgs e)
        {
            new ConfigItemForm().Show();

        }

        private void textBoxFilterCI_TextChanged(object sender, EventArgs e)
        {
            /*if (textBoxFilterCI.Text.Equals("Filter Items..."))
            {
                textBoxFilterCI.Text = "";
            }
            else if (textBoxFilterCI.Text.Equals(""))
            {
                textBoxFilterCI.Text = "Filter Items...";
            }*/
        }

        private void ConfigItemUI_Load(object sender, EventArgs e)
        {
            var ciService = new ConfigurationItem_Service();

            List<ConfigurationItem> configItems = ciService.GetAllConfigItems();
            listViewConfigurationItems.BeginUpdate();
            foreach (ConfigurationItem configurationItem in configItems)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    configurationItem.ID,
                    configurationItem.Name,
                    configurationItem.Description,
                    configurationItem.Owner.ToString(),
                    configurationItem.Location,
                    configurationItem.Importance.ToString()
                });
                //MessageBox.Show(configurationItem.ToString());
                listViewConfigurationItems.Items.Add(lvi);
            }

            listViewConfigurationItems.EndUpdate();
        }
    }
}