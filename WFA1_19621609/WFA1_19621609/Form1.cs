using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA1_19621609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("The concept of this game is the application to 'guess' if the number from the user, that has typed is even or odd", "Info");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            DialogResult result;
            try {
               number = int.Parse(textBox1.Text);
               if (number % 2 == 0) result =MessageBox.Show("Even!","Was it even or odd?",MessageBoxButtons.YesNo);
               else result = MessageBox.Show("Odd!","Was it even or odd?",MessageBoxButtons.YesNo);

               if (result == DialogResult.Yes) this.Close();
               else 
                   Application.Exit();
                
            }catch{
                    MessageBox.Show("Input string is not in correct format!");
                

        }
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if ( (result = MessageBox.Show("Are you sure you want to exit?","Close", MessageBoxButtons.YesNo) ) == DialogResult.Yes)
                this.Close();

        }
    }
}
