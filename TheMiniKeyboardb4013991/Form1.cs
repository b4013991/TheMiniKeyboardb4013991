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
        int IntervalRequired = 500;

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
            timer1.Interval = IntervalRequired;
            timer1.Tick += new EventHandler(timerEnded);
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
            Keystrokes = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(timer1.Interval.ToString());
                rTxt_WorldBuilder.Clear();
             if (FirstTime == true)
            {
                FirstTime = false;
                 timer1.Enabled = true;
                 Keystrokes++;
                 Console.WriteLine("Timer Interval has started at 500");
                 rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
             }
             else if (timer1.Enabled == true)
             {
                 Keystrokes++;
                 rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                 timer1.Enabled = false;
                 timer1.Enabled = true;
                 Console.WriteLine("The Timer has been restarted");
             }
             else if (timer1.Enabled == false)
             {
                 Keystrokes = 1;
                 rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                 timer1.Enabled = true;
                 Console.WriteLine("Timer interval started again");

             }
            

            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "p";
            }


            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "q";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "r";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "s";

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "1";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "P";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "Q";
            }
            else if (Keystrokes == 8)
            {
                rTxt_WorldBuilder.Text = "R";
            }
            else if (Keystrokes == 9)
            {
                rTxt_WorldBuilder.Text = "S";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "t";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "u";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "v";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "2";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "T";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "U";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "V";
                Keystrokes = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "w";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "x";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "y";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "z";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "3";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "W";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "X";
                Keystrokes++;
            }
            else if (Keystrokes == 8)
            {
                rTxt_WorldBuilder.Text = "Y";
                Keystrokes++;
            }
            else if (Keystrokes == 9)
            {
                rTxt_WorldBuilder.Text = "Z";
                Keystrokes = 0;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "g";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "h";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "i";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "4";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "G";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "H";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "I";
                Keystrokes = 0;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "j";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "k";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "l";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "5";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "J";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "K";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "L";
                Keystrokes = 0;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "m";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "n";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "o";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "6";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "M";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "N";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "O";
                Keystrokes = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = ".";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "~";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "`";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "7";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "'";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = ":";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = ";";
                Keystrokes = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "a";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "b";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "c";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "8";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "A";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "B";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "C";
                Keystrokes = 0;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "d";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "e";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "f";
                Keystrokes++;
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "9";
                Keystrokes++;

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "D";
                Keystrokes++;
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "E";
                Keystrokes++;
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "F";
                Keystrokes = 0;

            }
        }

        private void button000_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "*";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "-";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "_";
                Keystrokes = 0;

            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "#";
                Keystrokes++;
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "-";
                Keystrokes++;
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "_";
                Keystrokes = 0;
            }}
             private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
           private void timerEnded(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }



        }
    }

