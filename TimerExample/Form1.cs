using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimerExample
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (countingTimer.Enabled == true)
            {
                countingTimer.Enabled = false;
                startButton.Text = "Start";
            }
            else
            {
                countingTimer.Enabled = true;
                startButton.Text = "Stop";
            }

        }

        private void countingTimer_Tick(object sender, EventArgs e)
        {
            //count
            counter++;
            counterLabel.Text = $"{counter}";

            //colour
            if (counter % 10 == 0)
            {
                if (colourLabel.BackColor == Color.White)
                {
                    colourLabel.BackColor = Color.Red;
                }
                else
                {
                    colourLabel.BackColor = Color.White;
                }
            }

        }
    }
}
