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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считываем ввод пользователя
            if (double.TryParse(textBox4.Text, out double U) &&
                double.TryParse(textBox2.Text, out double I) &&
                double.TryParse(textBox3.Text, out double t))
            {
                // Расчёт работы электрического тока
                double A = U * I * t;

                // Вывод исходных данных
                textBox5.Text = U.ToString();
                textBox6.Text = I.ToString();
                textBox1.Text = t.ToString();

                // Вывод результата
                textBox7.Text = A.ToString("F3");
            }
            else
            {
                MessageBox.Show("Ошибка! Введите корректные числовые значения.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBox5.Clear();
                textBox6.Clear();
                textBox1.Clear();
                textBox7.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
