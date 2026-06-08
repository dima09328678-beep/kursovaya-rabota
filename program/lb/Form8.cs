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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            if (double.TryParse(textBox4.Text, out double p) &&
        double.TryParse(textBox2.Text, out double l) &&
        double.TryParse(textBox3.Text, out double S))
            {
                if (S == 0)
                {
                    MessageBox.Show("Площадь сечения не может быть равна нулю.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Расчёт сопротивления проводника
                double R = p * l / S;

                // Вывод исходных данных
                textBox5.Text = p.ToString();
                textBox6.Text = l.ToString();
                textBox1.Text = S.ToString();

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
                textBox1.Clear();
                textBox7.Clear();
            }
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar == '-' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains("-")) || (e.KeyChar == ',' && !textBox1.Text.Contains(",")))
                return;
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar == '-' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains("-")) || (e.KeyChar == ',' && !textBox1.Text.Contains(",")))
                return;
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar == '-' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains("-")) || (e.KeyChar == ',' && !textBox1.Text.Contains(",")))
                return;
            e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar == '-' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains("-")) || (e.KeyChar == ',' && !textBox1.Text.Contains(",")))
                return;
            e.Handled = true;
        }
    }
}
