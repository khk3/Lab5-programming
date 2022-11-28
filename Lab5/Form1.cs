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

        }
    }
}
