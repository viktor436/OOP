using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project1._2
{
    public partial class FormGameLevel : Form
    {
        public FormGameLevel()
        {
            InitializeComponent();
        }
        private int _level;
        public int Level 
        {
            get { return _level; }
            set { _level = value; }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonEasyLevel.Checked)
                _level = 1;
            else
                _level = 2;
            DialogResult = DialogResult.OK;
        }
    }
}
