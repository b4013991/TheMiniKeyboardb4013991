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
        public Form1()
        {
            InitializeComponent();
        }
        string WordBuilderTxt;
        string Keystrokes;
        bool FirstTime = true;

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

        private void button0_Click(object sender, EventArgs e)
        {
            WordBuilderTxt = rTxt_WorldBuilder.Text;
            mainTxt.AppendText(WordBuilderTxt + " ");

            rTxt_WorldBuilder.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int intIntervalRequired = 500;

        }

        
        

        }
    }

