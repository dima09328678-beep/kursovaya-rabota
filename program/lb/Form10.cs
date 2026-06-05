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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double R1) &&
                double.TryParse(textBox2.Text, out double R2))
            {
                if ((R1 + R2) == 0)
                {
                    MessageBox.Show("Сумма сопротивлений не может быть равна нулю!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Расчёт общего сопротивления
                double R = (R1 * R2) / (R1 + R2);

                // Вывод исходных данных
                textBox5.Text = R1.ToString();
                textBox6.Text = R2.ToString();

                textBox3.Text = R1.ToString();
                textBox1.Text = R2.ToString();

                // Вывод результата
                textBox7.Text = R.ToString("F3");
            }
            else
            {
                MessageBox.Show("Ошибка! Введите корректные числовые значения.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBox5.Clear();
                textBox6.Clear();
                textBox3.Clear();
                textBox1.Clear();
                textBox7.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox3.Clear();
            textBox1.Clear();
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
