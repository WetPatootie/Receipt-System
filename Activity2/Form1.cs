using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public static string regularCus = "Regular 0%";
        public static string pwdCus = "PWD/Senior 20%";
        public static string studCus = "Student 15%";

        public Form1()
        {
            InitializeComponent();
            customerBox1.Items.Add(regularCus);
            customerBox1.Items.Add(pwdCus);
            customerBox1.Items.Add(studCus);
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        private void numLock(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int number =  int.Parse(textBox1.Text);
                if (number > 0)
                {
                    number--;
                    textBox1.Text = number.ToString();
                }
                else
                {
                    return;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int number = int.Parse(textBox1.Text);
                    number++;
                    textBox1.Text = number.ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int number = int.Parse(textBox2.Text);
                if (number > 0)
                {
                    number--;
                    textBox2.Text = number.ToString();
                }
                else
                {
                    return;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int number = int.Parse(textBox2.Text);
                number++;
                textBox2.Text = number.ToString();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int number = int.Parse(textBox3.Text);
                if (number > 0)
                {
                    number--;
                    textBox3.Text = number.ToString();
                }
                else
                {
                    return;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int number = int.Parse(textBox3.Text);
                number++;
                textBox3.Text = number.ToString();
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                int number = int.Parse(textBox4.Text);
                if (number > 0)
                {
                    number--;
                    textBox4.Text = number.ToString();
                }
                else
                {
                    return;
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                int number = int.Parse(textBox4.Text);
                number++;
                textBox4.Text = number.ToString();
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int number = int.Parse(textBox5.Text);
                if (number > 0)
                {
                    number--;
                    textBox5.Text = number.ToString();
                }
                else
                {
                    return;
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int number = int.Parse(textBox5.Text);
                number++;
                textBox5.Text = number.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int price1 = 145 * int.Parse(textBox1.Text);
            int price2 = 99 * int.Parse(textBox2.Text);
            int price3 = 85 * int.Parse(textBox3.Text);
            int price4 = 50 * int.Parse(textBox4.Text);
            int price5 = 30 * int.Parse(textBox5.Text);
            int sum = price1 + price2 + price3 + price4 + price5;
            textBox6.Text = sum.ToString();
            if (customerBox1.Text == pwdCus)
            {
              double discount1 = sum * .2;
              textBox7.Text = discount1.ToString();
            }else if (customerBox1.Text == studCus){
                double discount1 = sum * .15;
                textBox7.Text = discount1.ToString();
            }else
            {
                textBox7.Text = "0";
            }
            double total = sum - int.Parse(textBox7.Text);
            textBox8.Text = total.ToString();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double change = int.Parse(textBox8.Text) - int.Parse(textBox9.Text);
            if (int.Parse(textBox9.Text) < int.Parse(textBox8.Text))
            {
                MessageBox.Show("Please Enter the Right Amount");
            }else
            {
                MessageBox.Show("Order Successful");
            }
            textBox10.Text = change.ToString();
        }
    }
}
