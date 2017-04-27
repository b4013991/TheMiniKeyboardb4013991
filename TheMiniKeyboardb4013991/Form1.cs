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

        string WordBuilderTxt; // creates the string where letters from the word builder will be stored
        int Keystrokes = 0; // sets the keystrokes integer for use with the keypad
        bool FirstTime = true; // establishes the user is opening the app for the first time
        int IntervalRequired = 500; // sets the default interval to 500 (0.5s)

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
                txt_ModeStatus.Text = "Multi-Press"; // allows the user to switch between multi-press and prediction mode
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            mainTxt.AppendText(Environment.NewLine); // acts as an enter button for the main text box, starting a new line
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
             if (FirstTime == true)
            {
                FirstTime = false;
                 timer1.Enabled = true;
                 Keystrokes++;
                 rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
             }
             else if (timer1.Enabled == true)
             {
                 Keystrokes++;
                 rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                 timer1.Enabled = false;
                 timer1.Enabled = true;
             }
             else if (timer1.Enabled == false)
             {
                 Keystrokes = 1;
                 rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                 timer1.Enabled = true;

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
                Keystrokes = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "t";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "u";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "v";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "2";

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "T";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "U";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "V";
                Keystrokes = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "w";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "x";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "y";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "z";

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "3";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "W";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "X";
            }
            else if (Keystrokes == 8)
            {
                rTxt_WorldBuilder.Text = "Y";
            }
            else if (Keystrokes == 9)
            {
                rTxt_WorldBuilder.Text = "Z";
                Keystrokes = 0;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "g";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "h";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "i";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "4";

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "G";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "H";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "I";
                Keystrokes = 0;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "j";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "k";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "l";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "5";

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "J";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "K";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "L";
                Keystrokes = 0;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "m";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "n";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "o";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "6";
            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "M";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "N";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "O";
                Keystrokes = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = ".";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "~";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "`";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "7";

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "'";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = ":";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = ";";
                Keystrokes = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "a";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "b";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "c";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "8";

            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "A";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "B";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "C";
                Keystrokes = 0;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "d";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "e";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "f";
            }
            else if (Keystrokes == 4)
            {
                rTxt_WorldBuilder.Text = "9";
            }
            else if (Keystrokes == 5)
            {
                rTxt_WorldBuilder.Text = "D";
            }
            else if (Keystrokes == 6)
            {
                rTxt_WorldBuilder.Text = "E";
            }
            else if (Keystrokes == 7)
            {
                rTxt_WorldBuilder.Text = "F";
                Keystrokes = 0;

            }
        }

        private void button000_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "*";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "-";
            }
            else if (Keystrokes == 3)
            {
                rTxt_WorldBuilder.Text = "_";
                Keystrokes = 0;

            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if (FirstTime == true)
            {
                FirstTime = false;
                timer1.Enabled = true;
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
            }
            else if (timer1.Enabled == true)
            {
                Keystrokes++;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == false)
            {
                Keystrokes = 1;
                rTxt_WorldBuilder.Text = Convert.ToString(Keystrokes);
                timer1.Enabled = true;

            }
            if (Keystrokes == 1)
            {
                rTxt_WorldBuilder.Text = "#";
            }
            else if (Keystrokes == 2)
            {
                rTxt_WorldBuilder.Text = "-";
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

           private void quitToolStripMenuItem_Click(object sender, EventArgs e)
           {
               Environment.Exit(0);
           }

           private void setIntervalToolStripMenuItem_Click(object sender, EventArgs e)
           {
               int interval500;
               interval500 = 500;
               timer1.Interval = interval500;
               MessageBox.Show("The interval has been set to 500, which translates to 0.5 second");
             
           }

           private void interval10001sToolStripMenuItem_Click(object sender, EventArgs e)
           {
               int interval1000;
               interval1000 = 1000;
               timer1.Interval = interval1000;
               MessageBox.Show("The interval has been set to 1000, which translates to 1 second");

           }

           private void interval20002sToolStripMenuItem_Click(object sender, EventArgs e)
           {
               int interval2000;
               interval2000 = 2000;
               timer1.Interval = interval2000;
               MessageBox.Show("The interval has been set to 2000, which translates to 2 seconds");
           }



        }
    }

