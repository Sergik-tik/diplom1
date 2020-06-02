using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        { 
            InitializeComponent();
        }
        class a
        {
            public static int r = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Visible = false;
            button2.Visible = true;
            label1.Text = Convert.ToString(Program.r);

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
          Program.r= Program.r+1;
            label1.Text = Convert.ToString(Program.r);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            
            timer1.Enabled = false;
            Program.r1= Program.r1+1;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
