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

        }

        private void ConfigItemUI_Load(object sender, EventArgs e)
        {
            var ciService = new ConfigurationItem_Service();
            listViewConfigurationItems.Clear();
            /*List<ConfigurationItem> configItems = ciService.GetAllConfigItems();
            listViewConfigurationItems.BeginUpdate();
            foreach (ConfigurationItem configurationItem in configItems)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(configurationItem.ID);
                lvi.SubItems.Add(configurationItem.Name);
                lvi.SubItems.Add(configurationItem.Description);
                lvi.SubItems.Add(configurationItem.Owner.ToString());
                lvi.SubItems.Add(configurationItem.Location);
                lvi.SubItems.Add(configurationItem.Importance.ToString());
                listViewConfigurationItems.Items.Add(lvi);
            }
            listViewConfigurationItems.EndUpdate();*/
        }
    }
}
