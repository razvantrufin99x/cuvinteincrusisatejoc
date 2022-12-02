using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cuvinteincrusisatejoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string currentstring = " ";

        public void setcurrentstring(string s)
        {
            currentstring = s;
            setbtn1text();
        }
        public void setbtn1text ()
        {
            button1.Text = currentstring;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            vklc1.setbuttontext("A");
            vklc2.setbuttontext("B");
            vklc3.setbuttontext("C");
            vklc4.setbuttontext("D");
            vklc5.setbuttontext("E");
            vklc6.setbuttontext("F");
            vklc7.setbuttontext("G");
            vklc8.setbuttontext("H");
            vklc9.setbuttontext("I");
            vklc10.setbuttontext("J");
            vklc11.setbuttontext("K");
            vklc12.setbuttontext("L");
            vklc13.setbuttontext("M");
            vklc14.setbuttontext("N");
            vklc15.setbuttontext("O");
            vklc16.setbuttontext("P");
            vklc17.setbuttontext("Q");
            vklc18.setbuttontext("R");
            vklc19.setbuttontext("S");
            vklc20.setbuttontext("T");
            vklc21.setbuttontext("U");
            vklc22.setbuttontext("V");
            vklc23.setbuttontext("X");
            vklc24.setbuttontext("Z");
            vklc25.setbuttontext("W");
            vklc26.setbuttontext("Y");
            vklc27.setbuttontext("1");
            vklc28.setbuttontext("2");
            vklc29.setbuttontext("3");
            vklc30.setbuttontext("4");
            vklc31.setbuttontext("5");
            vklc32.setbuttontext("6");
            vklc33.setbuttontext("7");
            vklc34.setbuttontext("8");
            vklc35.setbuttontext("9");
            vklc36.setbuttontext("0");
            vklc37.setbuttontext(" ");

        }

        
    }
}
