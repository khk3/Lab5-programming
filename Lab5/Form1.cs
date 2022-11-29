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
        }//end of Login event
        //clear txtbox and set acceptbutton to btnJoin and cancelbutton to btnReset
        private void ResetTextGrp()
        {
            txtString1.Text="";
            txtString2.Text="";
            lblResults.Text="";
            this.AcceptButton= btnJoin;
            this.CancelButton=btnReset;
        }// end of resetTextGrp function

        //function ResetStatsGrp - clear all labels and lstbox. Acceptbutton is btnGenerate and cancelbutton is btnClear 
        private void ResetStatsGrp()
        {
            lblSum.Text="";
            lblMean.Text="";
            lblOdd.Text="";
            lstBoxStats.Text="";
            this.AcceptButton=btnGenerate;
            this.CancelButton=btnClear;
        }//end of ResetStatsGrp

        //function SetupOption - will hide or show the groupbox corre
        private void SetupOption()
        {
            if (radText.Checked)
            {
                grpText.Visible=true;
                grpStats.Visible=false;
                ResetTextGrp();
            }
            else
            {
                grpText.Visible=false;
                grpStats.Visible=true;
                ResetStatsGrp();
            }
        }
        //event will call SetupOption function
        private void radText_CheckedChanged(object sender, EventArgs e)
        {
            SetupOption();
        }
        //event will call SetupOption function
        private void radStats_CheckedChanged(object sender, EventArgs e)
        {
            SetupOption();
        }
        //btnReset event will call ResetTextGrp function
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextGrp();
        }
        //btnClear event will call ResetStatsGrp function
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetStatsGrp();
        }

        //Function swap in GrpText. It will get value by reference and store in a temporary variable
        //only to pass after to the second number
        private void Swap(ref string txt1, ref string txt2)
        {
            string temp = txt1;
            txt1 = txt2;
            txt2= temp;
           
        }

        //function CheckInput- if txtString1 or txtString2 is empty will return false. Otherwise, true.
        private bool CheckInput()
        {
            bool isValid=true;
            if (txtString1.Text=="" && txtString2.Text=="")
            {
                isValid=false;               
               
            }
            return isValid;
        }//end of CheckInput function
        
        //Swap checkbox event
        private void chkSwap_CheckedChanged(object sender, EventArgs e)
        {   
            //store txtbox values in variables
            string txt1 = txtString1.Text;
            string txt2 = txtString2.Text;
            
            //swap the strings before calling the function 
            txtString1.Text= txt2;
            txtString2.Text= txt1;
            //call the function Swap sending value by reference
            Swap(ref txt1, ref txt2);

            //show the swapped result
            lblResults.Text= txt1 + txt2;            
        }//end of Swap checkbox event

        //btn Join event
        private void btnJoin_Click(object sender, EventArgs e)
        {   
            //call function CheckInput
            CheckInput();
            //show info and and result 
            lblResults.Text="First string = " + txtString1.Text + "\nSecond string= " +txtString2.Text +"\nJoined = " + 
                txtString1.Text + "-->" + txtString2.Text ;
        }
        //btnAnalyze event
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if(CheckInput()==true)
            {
                lblResults.Text="First String = "+ txtString1.Text+ "\nCharacters = " + txtString2.Text.Length +
                    "\nSecond string = " + txtString2.Text + "\nCharacters = " +txtString2.Text.Length;
            }

        }
    }
}
