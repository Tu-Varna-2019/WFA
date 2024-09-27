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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form2.iYears > 1 && Form2.iYears < 6)
                radioButton1.Select();
            else if (Form2.iYears > 7 && Form2.iYears < 12)
                radioButton2.Select();
            else if (Form2.iYears > 13 && Form2.iYears < 18)
                radioButton3.Select();
        }
    }
}
