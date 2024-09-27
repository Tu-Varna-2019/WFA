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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        SqlDataAdapter adapt;
        Form1 frm = new Form1();
       
        private void displayData()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Wholesale where MONTH(Durability)=12 AND Quantity > 5", myConnection); 
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                displayData();
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }

        }



        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
    }
}
