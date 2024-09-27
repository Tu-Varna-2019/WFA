using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace WFA3_19621609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime NewYear = new DateTime(2022,1,1);
            DateTime CurrTime= DateTime.Now;
            DateTime dd = new DateTime();
          
            dd = DateTime.Parse(dateTimePicker1.Text);

            DateTime[] NationalHolidays = { 
                     new DateTime(1,3,3),
                     new DateTime(1,4,19),
                     new DateTime(1,5,1),
                     new DateTime(1,5,6),
                     new DateTime(1,5,24),
                     new DateTime(1,9,6),
                     new DateTime(1,9,22),
                     new DateTime(1,11,1),
                     new DateTime(1,12,24),
                     new DateTime(1,12,25),
                     new DateTime(1,12,26) };


            for (var i = 0; i < 11; i++)
            {
                if ( dd.ToString("d, M").Equals(NationalHolidays[i].ToString("d, M")) ) 
                 MessageBox.Show("The set date is an official holiday!");
            }
            string msg = "\nDay=" + dd.Day +
                "\nMonth=" + dd.Month +
                "\nYear=" + dd.Year +
                "\nDayOfWeek=" + dd.DayOfWeek +
                "\nDayOfYear=" + dd.DayOfYear +
                "\n\nDays and time from set date to new year: " + NewYear.Subtract(dd).Days +
                "\n\nDays from set date to current time: " + Math.Abs((dd.Day - CurrTime.Day)) +
           "\n\nMonths from set date to current time: " + Math.Abs((dd.Month - CurrTime.Month)) +
            "\n\nYears from set date to current time: " + Math.Abs((dd.Year - CurrTime.Year));
            
               

            string msg1 = "30 days";
            string msg2 = "31 days";
            string msg3 = "28 days";
            string msg4 = "29 days";

            int mm = dd.Month;
            switch (mm)
            {
                case 1:case 3 : case 5:case 7:case 8:case 10:case 12:
                    MessageBox.Show(msg + "\n" + msg2);

                    break;
                case 4:case 6:case 9:case 11:
                    MessageBox.Show(msg + "\n" + msg1);
                    break;
                case 2:
                    if (DateTime.IsLeapYear(dd.Year))
                    { MessageBox.Show("Leap year "+msg + "\n" + msg4); }
                    else 
MessageBox.Show("Not a leap year "+msg + "\n" + msg4); 
                    break;


                default:
                    break;
            }
        }

    
    }
}
