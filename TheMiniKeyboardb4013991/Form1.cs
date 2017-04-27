using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace TheMiniKeyboardb4013991
{
    public partial class Form1 : Form
    {

        string WordBuilderTxt;
        string Keystrokes = 0;
        bool FirstTime = true;
        int TestNumber = 0;
   
        public Form1()
        {
            InitializeComponent();
      
        }


        private void btn_Mode_Click(object sender, EventArgs e)
        {
            if (txt_ModeStatus.Text == "Multi-Press")
            {
            txt_ModeStatus.Text = "Prediction";
            }
            else
            {
                txt_ModeStatus.Text = "Multi-Press";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            mainTxt.AppendText(Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int intIntervalRequired = 500;
            timer1.Interval = intIntervalRequired;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxt_WorldBuilder.Clear();
            mainTxt.Clear();
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            WordBuilderTxt = rTxt_WorldBuilder.Text;
            mainTxt.AppendText(WordBuilderTxt + " ");

            rTxt_WorldBuilder.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Keystrokes = "1";
              if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                TestNumber++;
                rTxt_WorldBuilder.Text = Convert.ToString(TestNumber);
            }
            else if (timer1.Enabled == true)
            {
                TestNumber++;
                rTxt_WorldBuilder.Text = Convert.ToString(TestNumber);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
              else if (timer1.Enabled == false)
              {
                  TestNumber = 0;
                  TestNumber++;
                  rTxt_WorldBuilder.Text = Convert.ToString(TestNumber);
                  timer1.Enabled = true;
              }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Keystrokes = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Keystrokes = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Keystrokes = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Keystrokes = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Keystrokes = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Keystrokes = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Keystrokes = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Keystrokes = "9";
        }

        
        

        }
    }

