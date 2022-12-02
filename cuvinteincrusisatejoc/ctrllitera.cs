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
    public partial class ctrllitera : UserControl
    {
        public ctrllitera()
        {
            InitializeComponent();
        }
        Form1 parinte = null;

        public void setlabeltext(string s)
        {
            label1.Text = s;
        }

        private void ctrllitera_Load(object sender, EventArgs e)
        {
            try
            {
                parinte = (Form1)this.ParentForm;
            }
            catch { }
            setlabeltext(" ");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            setlabeltext(parinte.currentstring);
        }

        private void ctrllitera_MouseClick(object sender, MouseEventArgs e)
        {
            setlabeltext(parinte.currentstring);
        }
    }
}
