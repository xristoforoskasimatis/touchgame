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
    
    public partial class Form1 : Form
    {
        public string usr;
        
        int sp=0;
        
        Color colour = Form1.DefaultBackColor;

        public Form1()
        {
            InitializeComponent();
            textBox1.TabIndex = 1;
            button1.TabIndex = 2;
            button2.TabIndex = 3;
            button4.TabIndex = 4;
            button3.TabIndex = 5;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            usr = textBox1.Text;
            int length = usr.Length;
            char[] space = usr.ToCharArray();            
            int sp = 0;
            for (int i = 0; i < length; i++)
            {
                if (space[i] == ' ')
                {
                    sp++;
                }
            }

            if (usr == "")
            {
                MessageBox.Show("ΠΡΕΠΕΙ ΝΑ ΒΑΛΕΙΣ ΟΝΟΜΑ ΠΡΩΤΑ");
            }          
            else
            if (sp > 0)
            {
                MessageBox.Show("ΔΕΝ ΕΠΙΤΡΕΠΟΝΤΑΙ ΤΑ ΚΕΝΑ");
            }
            else
            {
                Form2 form2 = new Form2(usr, colour);
                form2.Show();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            colour=colorDialog1.Color;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("level1.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                if (tmp[0] == "")
                {
                    break;
                }
                MessageBox.Show("Level 1: \n" + tmp[0] + "\n" + tmp[1]);
            }
            richTextBox1.Clear();
            richTextBox1.LoadFile("level2.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                if(tmp[0]=="")
                {
                    break;
                }
                MessageBox.Show("Level 2: \n" + tmp[0] + "\n" + tmp[1]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int top = 0;
            string best = "",best1="";
            richTextBox1.LoadFile("level1.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                if (tmp[0] == "")
                {
                    break;
                }
                if (int.Parse(tmp[1]) > top)
                {
                    top = int.Parse(tmp[1]);
                    best1 = tmp[0];
                }   
            }
            MessageBox.Show("Ο ΚΑΛΥΤΕΡΟΣ ΠΑΙΧΤΗΣ ΤΟΥ LEVEL 1 ΕΙΝΑΙ : \n" + best1 + " ΜΕ ΣΚΟΡ : \n" + top.ToString());
            richTextBox1.Clear();
            top = 0;
            richTextBox1.LoadFile("level2.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                if (tmp[0] == "")
                {
                    break;
                }
                if (int.Parse(tmp[1]) > top)
                {
                    top = int.Parse(tmp[1]);
                    best = tmp[0];                    
                }
            }
            MessageBox.Show("Ο ΚΑΛΥΤΕΡΟΣ ΠΑΙΧΤΗΣ ΤΟΥ LEVEL 2 ΕΙΝΑΙ : \n" + best + " ΜΕ ΣΚΟΡ : \n" + top.ToString());
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usr = textBox1.Text;
            int length = usr.Length;
            char[] space = usr.ToCharArray();
            int sp = 0;
            for (int i = 0; i < length; i++)
            {
                if (space[i] == ' ')
                {
                    sp++;
                }
            }

            if (usr == "")
            {
                MessageBox.Show("ΠΡΕΠΕΙ ΝΑ ΒΑΛΕΙΣ ΟΝΟΜΑ ΠΡΩΤΑ");
            }
            else
            if (sp > 0)
            {
                MessageBox.Show("ΔΕΝ ΕΠΙΤΡΕΠΟΝΤΑΙ ΤΑ ΚΕΝΑ");
            }
            else
            {
                Form2 form2 = new Form2(usr, colour);
                form2.Show();
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cREATORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by :\nUniversity of Piraeus Student \nKasimatis Christoforos");
        }

        private void hIGHSCORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int top = 0;
            string best = "", best1 = "";
            richTextBox1.LoadFile("level1.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                if (int.Parse(tmp[1]) > top)
                {
                    top = int.Parse(tmp[1]);
                    best1 = tmp[0];
                }
            }
            MessageBox.Show("Ο ΚΑΛΥΤΕΡΟΣ ΠΑΙΧΤΗΣ ΤΟΥ LEVEL 1 ΕΙΝΑΙ : \n" + best1 + " ΜΕ ΣΚΟΡ : \n" + top.ToString());
            top = 0;
            richTextBox1.LoadFile("level2.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                if (int.Parse(tmp[1]) > top)
                {
                    top = int.Parse(tmp[1]);
                    best = tmp[0];
                }
            }
            MessageBox.Show("Ο ΚΑΛΥΤΕΡΟΣ ΠΑΙΧΤΗΣ ΤΟΥ LEVEL 2 ΕΙΝΑΙ : \n" + best + " ΜΕ ΣΚΟΡ : \n" + top.ToString());
        }

        private void sCORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("level1.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                MessageBox.Show("Level 1: \n" + tmp[0] + "\n" + tmp[1]);
            }
            richTextBox1.LoadFile("level2.txt", RichTextBoxStreamType.PlainText);
            foreach (string s in richTextBox1.Lines)
            {
                string[] tmp = s.Split(' ');
                MessageBox.Show("Level 2: \n" + tmp[0] + "\n" + tmp[1]);
            }
        }
    }
}
