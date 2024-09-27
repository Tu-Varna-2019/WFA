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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Вид товар";
            label2.Text = "Описание на товар";
            label3.Text = "Количество";
            label4.Text = "Килограми";
            label5.Text = "Цена на стоката";
            label6.Text = "Температура на съхранение";
            label7.Text = "Трайност на стоката";
            label8.Text = "Място на доставка";
            label9.Text = "Дата на влизане";
            label10.Text = "Дата на излизане";
        }

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        SqlDataAdapter adapt;
        Form1 frm = new Form1();

        private void Form2_Load(object sender, EventArgs e)
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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox8.Text != "")
            {
                try
                {

                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Wholesale(Type,Description,Quantity,Kilograms,Price,Date_entry,Date_exit,Storage,Durability,Delivery) values(@Type,@Description,@Quantity,@Kilograms,@Price,@Date_entry,@Date_exit,@Storage,@Durability,@Delivery)", myConnection);

                    myCommand.Parameters.AddWithValue("@Type", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@Description", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    myCommand.Parameters.AddWithValue("@Kilograms", textBox4.Text);
                    myCommand.Parameters.AddWithValue("@Price", textBox5.Text);

                    myCommand.Parameters.AddWithValue("@Date_entry", dateTimePicker1.Text);
                    myCommand.Parameters.AddWithValue("@Date_exit", dateTimePicker2.Text);

                    myCommand.Parameters.AddWithValue("@Storage", textBox6.Text);
                    myCommand.Parameters.AddWithValue("@Durability",dateTimePicker3.Text);
                    myCommand.Parameters.AddWithValue("@Delivery", textBox8.Text);

                  
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно въвеждане!");
                    displayData();

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            }
            else MessageBox.Show("Моля въведете необходимите данни!");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
