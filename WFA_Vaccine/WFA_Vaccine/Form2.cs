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

    public partial class Form2 : Form
    {
        public static int iYears;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sFirstName = textBox1.Text;
            string sLastName = textBox2.Text;
            string sEGN = textBox3.Text;
            string sYears = textBox4.Text;
            bool bCheckNames = true;
            bool bCheckEGN = true;
            int ii;
            int iSymbol;

            if (sFirstName.Length == 0 || sLastName.Length == 0)
            { MessageBox.Show("Empty credentials!"); bCheckNames = false; }
            else if (!((int)sFirstName[0] >= 65 && (int)sFirstName[0] <= 90) && ( (int)sLastName[0] >= 65 && (int)sLastName[0] <= 90))
            {
                { MessageBox.Show("Names should start with capital letter!"); bCheckNames = false; }
            }
            else
            {
                for (ii = 1; ii < sFirstName.Length; ii++)
                {
                    iSymbol = (int)sFirstName[ii];

                    if (iSymbol >= 97 && iSymbol <= 122)
                        bCheckNames = true;
                    else { bCheckNames = false; break; }
                }

                if (bCheckNames)
                {
                    for (ii = 1; ii < sLastName.Length; ii++)
                    {
                        iSymbol = (int)sLastName[ii];

                        if (iSymbol >= 97 && iSymbol <= 122)
                            bCheckNames = true;
                        else { bCheckNames = false; break; }
                    }
                }
            }

            if (!bCheckNames)
            {
                MessageBox.Show("Invalid first name/ last name");
            }

            /////
            if (sEGN.Length == 0)
            { MessageBox.Show("Empty EGN!"); bCheckEGN = false; }
            else if (sEGN.Length == 10)
            {
                for (ii = 0; ii < sEGN.Length; ii++)
                {
                    iSymbol = (int)sEGN[ii];

                    if (iSymbol >= 48 && iSymbol <= 57)
                        bCheckEGN = true;
                    else { bCheckEGN = false; break; }

                }

            }
            /////

            if (bCheckEGN)
            {
                string sDate  = "";
                string sDateYearDigit = "";
                string sDateMonthDigit = "";
                string sDateDayDigit = "";

                sDate += textBox3.Text;
                sDateYearDigit  += sDate[0].ToString() + sDate[1].ToString();
                sDateMonthDigit += sDate[2].ToString() + sDate[3].ToString();
                sDateDayDigit   += sDate[4].ToString() + sDate[5].ToString();


                int iDateYear = int.Parse(sDateYearDigit);
                int iDateMonth = int.Parse(sDateMonthDigit);
                int iDateDay = int.Parse(sDateDayDigit);

                iDateYear += 1900;


                dateTimePicker1.Value = new DateTime(iDateYear, iDateMonth, iDateDay);

                DateTime dtNow = DateTime.Now;
                
                iYears = (dtNow.Year - iDateYear);
                textBox4.Text = iYears.ToString();

                int iSex = int.Parse(sEGN[8].ToString());

                if (iSex % 2 == 0)
                    radioButton1.Select();
                else radioButton2.Select();
            }

            if (bCheckNames && bCheckEGN)
            {
                Form3 frm3 = new Form3();
                frm3.Update();
                frm3.Show();
            }


        }
    }
}
