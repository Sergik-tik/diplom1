using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            button3.Visible = true;
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(Program.r);
           

            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Dip;Persist Security Info=True;User ID=sa;Password=12345");

            string script = "INSERT INTO Nagruzka (kurs, Gruppa, Korpus, Kabinet, Wremi, Nagruzka, Stud_kol) "+ "Values (@kurs, @Gruppa, @Korpus, @Kabinet, @Wremi, @Nagruzka, @Stud_kol); ";

            SqlCommand cmd = new SqlCommand(script, conn);
            cmd.Parameters.AddWithValue("@kurs", ""+  textBox1.Text + "");
            cmd.Parameters.AddWithValue("@Gruppa", "" + textBox2.Text + "");
            cmd.Parameters.AddWithValue("@Korpus", "" + textBox3.Text + "");
            cmd.Parameters.AddWithValue("@Kabinet", "" + textBox4.Text + ""); 
            cmd.Parameters.AddWithValue("@Wremi", "" + textBox7.Text + ""); 
            cmd.Parameters.AddWithValue("@Nagruzka", "" + textBox5.Text + "");
            cmd.Parameters.AddWithValue("@Stud_kol", "" + textBox6.Text + "");
            conn.Open();
            cmd.ExecuteNonQuery();

          //  '"+ textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', " + textBox4.Text + ", " + textBox7.Text + ", '" + textBox5.Text + "', '" + textBox6.Text + "'
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Move(object sender, EventArgs e)
        {
            
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.r1 > 0)
            { button3.Visible = true; }
        }
    }
}
