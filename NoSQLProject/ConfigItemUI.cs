﻿using System;
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
    public partial class ConfigItemUI : Form
    {
        public ConfigItemUI()
        {
            InitializeComponent();
        }

        private void NewConfigItem_Click(object sender, EventArgs e)
        {
            new ConfigItemForm().Show();
            
        }
    }
}