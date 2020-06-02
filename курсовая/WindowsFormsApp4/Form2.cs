using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        private object akteriTableAdapter;
        private object kursDataSet;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dipDataSet.Nagruzka". При необходимости она может быть перемещена или удалена.
            this.nagruzkaTableAdapter.Fill(this.dipDataSet.Nagruzka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dipDataSet.Nagruzka". При необходимости она может быть перемещена или удалена.
            this.nagruzkaTableAdapter.Fill(this.dipDataSet.Nagruzka);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nagruzkaTableAdapter.Fill(dipDataSet.Nagruzka);

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           SqlCommand cmd = new SqlCommand("UPDATE Nagruzka SET Kod = @Kod, kurs = @kurs, Gruppa=@Gruppa, Korpus = @Korpus, Kabinet = @Kabinet, Wremi = @Wremi, Nagruzka = @Nagruzka, Stud_kol = @Stud_kol");
            this.nagruzkaTableAdapter.Update(this.dipDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "Выберите один из вариантов",
    "Сообщение",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
                this.nagruzkaTableAdapter.Update(this.dipDataSet);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
