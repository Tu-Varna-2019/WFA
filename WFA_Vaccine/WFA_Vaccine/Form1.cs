using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Vaccine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "User name";
            label2.Text = "Password";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sUsername = textBox1.Text;
            string sPassword = textBox2.Text;
            bool bCheckCrdedentials = true;
            int ii;
            int iSymbol = 0;

            if (sUsername.Length == 0 || sPassword.Length == 0)
            { MessageBox.Show("Empty credentials!"); bCheckCrdedentials = false; }
            else
            {
                if (sUsername.Length >= 5 && sUsername.Length <= 10)
                {
                    if (sPassword.Length >= 5 && sPassword.Length <= 8)
                    {

                        if ((int)sUsername[0] >= 48 && (int)sUsername[0] <= 57)
                        {
                            bCheckCrdedentials = false;
                            MessageBox.Show("First symbol is number");
                        }
                        else
                        {

                            for (ii = 0; ii < sUsername.Length; ii++)
                            {
                                iSymbol = (int)sUsername[ii];

                                if ((iSymbol >= 49 && iSymbol <= 53) || (iSymbol >= 65 && iSymbol <= 90))
                                    bCheckCrdedentials = true;
                                else { bCheckCrdedentials = false; break; }
                            }
                        }
                    }
                    else { MessageBox.Show("Wrong length on password"); bCheckCrdedentials = false; }
                }
                else { MessageBox.Show("Wrong length on username"); bCheckCrdedentials = false; }
            }
            if (bCheckCrdedentials)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else MessageBox.Show("Wrong credentials");
        }

        ///

    }

}
    

