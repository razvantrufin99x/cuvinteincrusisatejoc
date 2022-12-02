using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cuvinteincrusisatejoc
{
    public partial class vklc : UserControl
    {
        public vklc()
        {
            InitializeComponent();
        }

        Form1 parinte;

        public void setbuttontext(string s)
        { 
            button1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parinte.setcurrentstring(button1.Text);
        }

        private void vklc_Load(object sender, EventArgs e)
        {
            try
            {
                parinte = (Form1)this.ParentForm;
            }
            catch { }
        }
    }
}
