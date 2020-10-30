using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NoSQLProject
{
    public partial class ConfigItemUi : Form
    {
        BindingSource bindingSource = new BindingSource();


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
            /*try
            {
                string search = textBoxFilterCI.Text;
                (bindingSource.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE %'{search}'% " +
                    $"OR ID LIKE %'{search}'% OR" +
                    $"OR Description LIKE %'{search}'% OR" +
                    $"OR Location LIKE %'{search}'% OR" +
                    $"OR Importance LIKE %'{search}'% OR" +
                    $"OR Owner LIKE %'{search}'%";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }*/
        }

        private void textBoxFilterCI_Click(object sender, EventArgs e)
        {
            if (textBoxFilterCI.Text.Equals("Filter Items...")) textBoxFilterCI.Text = "";
        }

        private void ConfigItemUI_Load(object sender, EventArgs e)
        {
            UpdateList();
            textBoxFilterCI.Visible = false;
        }


        private void buttonEditConfigItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewConfigItem.SelectedRows.Count > 0)
            {
                new ConfigItemForm((ConfigurationItem) dataGridViewConfigItem.SelectedRows[0].DataBoundItem).Show();
                UpdateList();
            }
            else
            {
                MessageBox.Show("You must select a configuration item to edit");
            }
        }

        private void UpdateList()
        {
            bindingSource.Clear();
            var ciService = new ConfigurationItem_Service();
            foreach (var configItem in ciService.GetAllConfigItems())
            {
                bindingSource.Add(configItem);
            }

            dataGridViewConfigItem.DataSource = bindingSource;
        }
    }
}