using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{   
    //Kang Hyun Kwon 
    //create a program that validates the code first in order to run.
    //user has 3 attempts to run or program will close.

    public partial class Form1 : Form
    {
        //class level constant with name
        const string PROGRAMMER = "Kang";
        const int MINCODE = 100000;
        //add +1 to the MAXCODE in order to include the value when getting random number
        const int MAXCODE = 200001;
        const int errorsAllowed = 3;


        public Form1()
        {
            InitializeComponent();
        }
        //GetRandom function. Will return a variable the a random number between MINCODE and MAXCODE values
        private int GetRandom(int num1, int num2)
        {
            Random rand = new Random();
            int randomNum = rand.Next(num1, num2);
            return randomNum;
        }

        //when program runs
        private void Form1_Load(object sender, EventArgs e)
        {
            //add name at the end of the form title

            grpChoose.Hide();
            grpText.Hide();
            grpStats.Hide();
            txtCode.Focus();
            lblCode.Text= Convert.ToString(GetRandom(MINCODE, MAXCODE));

        }//end of form load event

        int counter = 1;
        private void btnLogin_Click(object sender, EventArgs e)
        {   
            //if user input wrong code and less than 3 times. Show a message and number of error entered
            if (lblCode.Text != txtCode.Text && counter <3)
            {
                MessageBox.Show(counter +" incorrect code(s) entered \nTry again - only "+errorsAllowed+ " attempts allowed", PROGRAMMER);
                counter++;
                txtCode.Text="";
                txtCode.Focus();
            //if user commit mistakes 3 times, show a message and close the program    
            }else if (counter ==3)
            {
                MessageBox.Show(counter + " attempts to login \nAccount locked - Closing program", PROGRAMMER);
                Close();
            }
            //if user enter correct code
            else
            {
                grpLogin.Enabled=false;
                grpChoose.Visible=true;
                grpText.Visible=true;
            }
        }
    }
}
