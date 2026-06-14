using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Form f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if (radioButton3.Checked)
            {
                Form f4 = new ф();
                f4.Show();
                this.Hide();
            }
            else if (radioButton4.Checked)
            {
                Form f7 = new Form7();
                f7.Show();
                this.Hide();
            }
            else if (radioButton5.Checked)
            {
                Form f8 = new Form8();
                f8.Show();
                this.Hide();
            }
            else if (radioButton6.Checked)
            {
                Form f9 = new Form9();
                f9.Show();
                this.Hide();
            }
            else if (radioButton7.Checked)
            {
                Form f10 = new Form10();
                f10.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Выберите задачу!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}