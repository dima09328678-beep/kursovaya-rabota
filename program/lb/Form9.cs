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
    public partial class Form9 : Form
    {
        public Form9()
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
            if (double.TryParse(textBox4.Text, out double R1) &&
                double.TryParse(textBox2.Text, out double R2) &&
                double.TryParse(textBox3.Text, out double R3))
            {
                double R = R1 + R2 + R3;

                // Вывод подстановки значений
                textBox5.Text = R1.ToString();
                textBox6.Text = R2.ToString();
                textBox1.Text = R3.ToString();

                // Вывод результата
                textBox7.Text = R.ToString("F3");
            }
            else
            {
                MessageBox.Show(
                    "Ошибка! Введите корректные числовые значения.",
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
            textBox4.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Clear();
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||
        e.KeyChar == (char)8 ||
        (e.KeyChar == ',' && !textBox4.Text.Contains(",")))
                return;

            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||
        e.KeyChar == (char)8 ||
        (e.KeyChar == ',' && !textBox4.Text.Contains(",")))
                return;

            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||
        e.KeyChar == (char)8 ||
        (e.KeyChar == ',' && !textBox4.Text.Contains(",")))
                return;

            e.Handled = true;
        }
    }
}
