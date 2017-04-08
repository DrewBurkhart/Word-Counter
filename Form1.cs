using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int countWords(string str)
        {
            int numWords = 0;
            bool wordBegin = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && !char.IsWhiteSpace(str[i]))
                {
                    wordBegin = true;
                }
                else if (i > 0 && char.IsWhiteSpace(str[i-1]))
                {
                    wordBegin = true;
                }
                else
                {
                    wordBegin = false;
                }

                if (wordBegin && (char.IsLetterOrDigit(str[i]) || char.IsPunctuation(str[i])))
                    numWords++;
            }

            return numWords;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Number of words :: " + countWords(textBox1.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
        }
    }
}
