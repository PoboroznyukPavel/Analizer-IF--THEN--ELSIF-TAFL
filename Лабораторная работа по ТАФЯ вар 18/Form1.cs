using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Лабораторная_работа_по_ТАФЯ_вар_18
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            FillTextBox();
        }


        void FillTextBox()
        {
            string s = "";
            foreach (string x in textBox_Input.Lines)
            {
                s += x.ToLower();
                s += " ";
            }
            Analizer a = new Analizer();
            string t = a.Analize(s);
            if (t != "")
            {
                textBox_Output.Text = t;
                textBox_Input.Focus();
                int z = a.GetLastPos();
                textBox_Input.SelectionStart = z-1;
                textBox_Input.SelectionLength = 1;
            }
            else
            {
                textBox_Output.Lines = a.Table;
            }

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            FillTextBox();
        }
    }
}
