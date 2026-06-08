using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lb
{
    public partial class ф : Form
    {
        public ф()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считываем ввод пользователя
            if (double.TryParse(textBox4.Text, out double U) &&
                double.TryParse(textBox2.Text, out double I))
            {
                // Расчёт мощности
                double P = U * I;

                // Вывод исходных данных
                textBox5.Text = U.ToString();
                textBox6.Text = I.ToString();

                // Вывод результата
                textBox7.Text = P.ToString("F3");
            }
            else
            {
                MessageBox.Show("Ошибка! Введите корректные числовые значения.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBox5.Clear();
                textBox6.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar == '-' && textBox5.SelectionStart == 0 && !textBox5.Text.Contains("-")) || (e.KeyChar == ',' && !textBox5.Text.Contains(",")))
                return;
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar == '-' && textBox5.SelectionStart == 0 && !textBox5.Text.Contains("-")) || (e.KeyChar == ',' && !textBox5.Text.Contains(",")))
                return;
            e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar == '-' && textBox7.SelectionStart == 0 && !textBox7.Text.Contains("-")) || (e.KeyChar == ',' && !textBox7.Text.Contains(",")))
                return;
            e.Handled = true;
        }
    }
}
