using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Form f9 = new Form9(); //создание нового объекта
            f9.Show(); //показываем форму2
            this.Hide(); //скрываем текущую форму
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Form f2 = new Form2(); //создание нового объекта
                f2.Show(); //показываем форму2
                this.Hide(); //скрываем текущую форму
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form f7 = new Form7(); //создание нового объекта
            f7.Show(); //показываем форму2
            this.Hide(); //скрываем текущую форму
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Form f8 = new Form8(); //создание нового объекта
            f8.Show(); //показываем форму2
            this.Hide(); //скрываем текущую форму
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Form f4 = new ф(); //создание нового объекта
                f4.Show(); //показываем форму
                this.Hide(); //скрываем текущую форму
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Form f10 = new Form10(); //создание нового объекта
            f10.Show(); //показываем форму2
            this.Hide(); //скрываем текущую форму
        }
    }
}
