using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KR2_WFA_Iliyan_Kostov_19621609
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = "Задаване на Цена под описание стока";
            label2.Text = "Цена";
            label3.Text = "Описание";

        }
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        SqlDataAdapter adapt;
        Form1 frm = new Form1();

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void displayData()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Wholesale", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {

                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Wholesale set Price=@Price where Description=@Description", myConnection);

                    myCommand.Parameters.AddWithValue("@Price", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@Description", textBox2.Text);

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    displayData();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
    }
}
