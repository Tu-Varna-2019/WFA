using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA4_19621609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Size";
            radioButton1.Text = "Small 9.25";
            radioButton2.Text = "Medium 11.50";
            radioButton3.Text = "Large 13.75";
            radioButton4.Text = "Thin";
            radioButton5.Text = "Thick";
            groupBox2.Text = "Crust";
            checkBox1.Text = "Extra cheese 1.50";
            label1.Text = "Toppings";
            button1.Text = "Calculate";
            string[] strLines = File.ReadAllLines("Toppings.txt");
            foreach (string str in strLines)
            {
                checkedListBox1.Items.Add(str);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dPrice=0.00;
            string strCrust = "";
            string str = "Check items:\n";
            int iBr = 0;
            for (int ii = 0; ii <= (checkedListBox1.Items.Count - 1); ii++)
            {
                if (checkedListBox1.GetItemChecked(ii))
                {
                    iBr++;
                    str = str + "Item: " + iBr.ToString() + " = " +
                    checkedListBox1.Items[ii].ToString() + "\n";
                }
            }

                 if ( radioButton1.Checked ) dPrice+= 9.25; 
                   else if ( radioButton2.Checked ) dPrice += 11.50;
                   else if ( radioButton3.Checked ) dPrice += 13.75;

                 if (checkBox1.Checked) dPrice += 1.50;

                 if (radioButton4.Checked) strCrust = "Thin";
                   else if ( radioButton5.Checked ) strCrust = "Thick";

                 richTextBox1.Text = str + "Total br = " + iBr.ToString() +
                     "\nPrice = " + dPrice.ToString();

                 if (strCrust != String.Empty) richTextBox1.Text += "\nCrust: " + strCrust;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            if (checkedListBox1.CheckedItems.Count != 0)
            {

                for (int ii = 0; ii <= (checkedListBox1.CheckedItems.Count + checkedListBox1.CheckedItems.Count); ii++)
                {

                    if (checkedListBox1.GetItemChecked(ii))
                    {
                        str = str + "Checked items: " + (ii + 1).ToString() + " = " +
                            checkedListBox1.Items[ii].ToString() + "\n";

                    }
                }
                MessageBox.Show(str);

            }
        }
    }
}