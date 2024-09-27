using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



public struct Operands
{
    public int iOperand1;
    public int iOperand2;


    public int getResult(char cSign)
    {
        switch (cSign)
        {
            case '+':
                return iOperand1 + iOperand2;
                break;
            case '-':
                return iOperand1 - iOperand2;
                break;
            case '*':
                return iOperand1 * iOperand2;
                break;
            case '/':
                if (iOperand2 == 0)
                { 
                    MessageBox.Show("\nCant divide by zero!");
                    
                }
                else
                    return iOperand1 / iOperand2;
                break;
        }
        return 0;
    }

    public bool bCheckNumber(string sOperand, bool bOperand)
    {
        if (bOperand)
        {
            if (int.TryParse(sOperand, out iOperand1))
                return true;
        }
        else
        {
            if (int.TryParse(sOperand, out iOperand2))
                return true;
        }
        return false;

    }
};



namespace WFA_Calculator_19621609
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   int cLeft = 20;

        public System.Windows.Forms.Button AddNewButton() {

            System.Windows.Forms.Button bButtonAdd = new System.Windows.Forms.Button();
            System.Windows.Forms.Button bButtonSub = new System.Windows.Forms.Button();
            System.Windows.Forms.Button bButtonMul = new System.Windows.Forms.Button();
            System.Windows.Forms.Button bButtonDiv = new System.Windows.Forms.Button();

            this.Controls.Add(bButtonAdd);
            this.Controls.Add(bButtonSub);
            this.Controls.Add(bButtonMul);
            this.Controls.Add(bButtonDiv);
            
            bButtonAdd.Size = new System.Drawing.Size(60,60);
            bButtonAdd.Location = new System.Drawing.Point(10, 100);
            bButtonSub.Size = new System.Drawing.Size(60, 60);
            bButtonSub.Location = new System.Drawing.Point(80, 100);
            bButtonMul.Size = new System.Drawing.Size(60, 60);
            bButtonMul.Location = new System.Drawing.Point(150, 100);
            bButtonDiv.Size = new System.Drawing.Size(60, 60);
            bButtonDiv.Location = new System.Drawing.Point(220, 100);
            


            bButtonAdd.Text = "+";
            bButtonSub.Text = "-";
            bButtonMul.Text = "*";
            bButtonDiv.Text = "/";

            bButtonAdd.Click += new EventHandler(this.bButtonClickAdd);
            bButtonSub.Click += new EventHandler(this.bButtonClickSub);
            bButtonMul.Click += new EventHandler(this.bButtonClickMul);
            bButtonDiv.Click += new EventHandler(this.bButtonClickDiv);

            return bButtonAdd;

        }


        System.Windows.Forms.TextBox tbOperand1;
        System.Windows.Forms.TextBox tbOperand2;
        System.Windows.Forms.TextBox tbResult;

        System.Windows.Forms.TextBox AddNewTextBox()
        {
          tbOperand1 = new System.Windows.Forms.TextBox();
          tbOperand2 = new System.Windows.Forms.TextBox();
          tbResult = new System.Windows.Forms.TextBox();

            this.Controls.Add(tbOperand1);
            this.Controls.Add(tbOperand2);
            this.Controls.Add(tbResult);

            tbOperand1.Top = cLeft;
            tbOperand1.Left = 20;
            tbOperand2.Top = cLeft;
            tbOperand2.Left = 160;
            tbResult.Top = cLeft + 40;
            tbResult.Left = 80;
            tbOperand1.Text = "0";
            tbOperand2.Text = "0";
            tbResult.Text = "0";
            cLeft++;

            return tbOperand1;

            


        }

        System.Windows.Forms.Label AddNewLabel()
        {
            System.Windows.Forms.Label lbOperand1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbOperand2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbResult = new System.Windows.Forms.Label();

            this.Controls.Add(lbOperand1);
            this.Controls.Add(lbOperand2);
            this.Controls.Add(lbResult);

            lbOperand1.Top = cLeft - 20;
            lbOperand1.Left = 30;
            lbOperand2.Top = cLeft - 20;
            lbOperand2.Left = 170;
            lbResult.Top = cLeft + 20;
            lbResult.Left = 110;


            lbOperand1.Text = "Operand 1";
            lbOperand2.Text = "Operand 2";
            lbResult.Text = "Result";

            return lbOperand1;

        }

 

        private void bButtonClickAdd(object sender ,EventArgs e)
        {
            Operands oOperands = new Operands();
           
            if ( (oOperands.bCheckNumber(tbOperand1.Text,true)) && (oOperands.bCheckNumber(tbOperand2.Text,false)) )
                tbResult.Text = oOperands.getResult('+').ToString();
            else MessageBox.Show("Numbers are only allowed!");


        }

        private void bButtonClickSub(object sender, EventArgs e)
        {
            Operands oOperands = new Operands();

            if ((oOperands.bCheckNumber(tbOperand1.Text, true)) && (oOperands.bCheckNumber(tbOperand2.Text, false)))
                tbResult.Text = oOperands.getResult('-').ToString();
            else MessageBox.Show("Numbers are only allowed!");

        }

        private void bButtonClickMul(object sender, EventArgs e)
        {
            Operands oOperands = new Operands();

            if ((oOperands.bCheckNumber(tbOperand1.Text, true)) && (oOperands.bCheckNumber(tbOperand2.Text, false)))
                tbResult.Text = oOperands.getResult('*').ToString();
            else MessageBox.Show("Numbers are only allowed!");

        }

        private void bButtonClickDiv(object sender, EventArgs e)
        {
            Operands oOperands = new Operands();

            if ((oOperands.bCheckNumber(tbOperand1.Text, true)) && (oOperands.bCheckNumber(tbOperand2.Text, false)))
                tbResult.Text = oOperands.getResult('/').ToString();
            else MessageBox.Show("Numbers are only allowed!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            AddNewButton();
            AddNewTextBox();
            AddNewLabel();
        }
    }
}
