using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atomiki1
{
    public partial class Form2 : Form
    {
        public int xronos=1,score=0;
        public string usr;
        public Form2(string str,Color c)
        {
            InitializeComponent();
            label2.Text = "User : " + str;
            usr = str;
            this.BackColor = c;
            button1.TabIndex = 1;
            button3.TabIndex = 2;
            button2.TabIndex = 3;
            radioButton1.TabIndex = 4;
            radioButton2.TabIndex = 5;
          
                
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }
        Random r = new Random();
        Boolean save=false ,pause = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            pause = true;
            xronos = 60;
            
            score = 0;
            label1.Text = "Score : ";
            if (radioButton1.Checked==true)
            { timer2.Interval = 1000; }
            if (radioButton2.Checked == true)
            {
                timer2.Interval = 600;
            }
            timer2.Start();
            timer3.Start();
            save = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
           

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (xronos == 0)
            {
                SaveFile();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
        private void SaveFile()
        {

            if (!save)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                if (radioButton1.Checked)
                {
                    richTextBox1.LoadFile("level1.txt", RichTextBoxStreamType.PlainText);
                    richTextBox1.Text = richTextBox1.Text + "\n" + usr + " " + score.ToString();
                    richTextBox1.SaveFile("level1.txt", RichTextBoxStreamType.PlainText);
                }
                if (radioButton2.Checked)
                {
                    richTextBox1.LoadFile("level2.txt", RichTextBoxStreamType.PlainText);
                    richTextBox1.Text = richTextBox1.Text + "\n" + usr + " " + score.ToString();
                    richTextBox1.SaveFile("level2.txt", RichTextBoxStreamType.PlainText);
                }
                save = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           
                int x = r.Next(102, this.Width - 102);
                int y = r.Next(38, this.Height - 79);
                pictureBox1.Location = new Point(x, y); 
              
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pause)
            {
                pause = false;
                timer3.Stop();
                timer2.Stop();
            }
            else
            {
                pause = true;
                timer2.Start();
                timer3.Start();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pause)
            {
                xronos--;
            }

            label3.Text ="Time: "+ xronos.ToString();
            if (xronos == 0)
            {
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("ΤΕΛΟΣ ΠΑΙΧΝΙΔΙΟΥ!");
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pause&& xronos!=0)
            {               
                score++;
                label1.Text = "Score : " + score.ToString();
            }
        }
    }
}
