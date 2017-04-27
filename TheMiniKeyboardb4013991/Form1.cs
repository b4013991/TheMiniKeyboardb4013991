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
        int Keystrokes = 1;
        bool FirstTime = true;
   
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
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "p";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "q";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "r";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "s";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "1";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "P";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "Q";
                Keystrokes++;
            }
            else if (Keystrokes == 8)
            {
                rTxt_WorldBuilder.Text = "R";
                Keystrokes++;
            }
            else if (Keystrokes == 9)
            {
                rTxt_WorldBuilder.Text = "S";
                Keystrokes = 1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        
        

        }
    }

