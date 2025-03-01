using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_DVGB07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double result = 0;
        string operation = "";
        bool isOperationPerfomed = false; //kollar om man har utfört en operation eller inte.

       
    
//Funktion som tar hand om CLEAR - knappen
        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            labelDisplay.Text = "0";
        }

     
//Funktion som tar hand om knapptryck för likamed tecket (=)
        private void buttonLikaMed_Click(object sender, EventArgs e)
        {
            switch(operation) {

                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString(); break;

                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString(); break;
                case "x":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString(); break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString(); break;

                default: 
                    break;

            }
            result = Double.Parse(txtDisplay.Text);
            labelDisplay.Text = "";

        }


        //Funktion som tar hand om knapptryckningar för alla tal, (0,1,2,3,4,5,6,7,8,9)
        private void button_click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0" || (isOperationPerfomed) ) 
                txtDisplay.Clear();

            isOperationPerfomed = false;

            Button button = (Button)sender;
            

            txtDisplay.Text += button.Text;

        }

 //Funktion som tar hand om knapptryckningar för alla Operatorer, (+, -, /, *)
        private void buttonOperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Om resultatet inte är noll, 
            if (result != 0)
            {
                buttonLikaMed.PerformClick();
                operation = button.Text;
                labelDisplay.Text = result + " " + operation; //Visar upp det på labelDisplay
                isOperationPerfomed = true;


            }
            else 
        {
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            labelDisplay.Text = result + " " + operation; //Visar upp det på labelDisplay
            isOperationPerfomed = true;
        }
        }

        //LabelDisplay knappen - ska visa föregående tal
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    }

}

