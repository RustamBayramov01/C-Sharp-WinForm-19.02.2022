using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            comboBox1.Items.Add("A-76");
            comboBox1.Items.Add("Ai-92");
            comboBox1.Items.Add("Ai-95");
            comboBox1.Items.Add("Premium");

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "A-76")
            {
                textBox1.Text = "6,40";
                label3.Text = "0";
                textBox2.Text = "";

            }
            else if (comboBox1.SelectedItem.ToString() == "Ai-92")
            {

                textBox1.Text = "2,60";
                label3.Text = "0";
                textBox2.Text = "";

            }
            else if (comboBox1.SelectedItem.ToString() == "Ai-95")
            {

                textBox1.Text = "4,50";
                label3.Text = "0";
                textBox2.Text = "";

            }
            else if (comboBox1.SelectedItem.ToString() == "Premium")
            {

                textBox1.Text = "8,50";
                label3.Text = "0";
                textBox2.Text = "";

            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
            textBox2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = false;
            textBox3.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            double result = 0;

            if (textBox2.Text.Length != 0)
            {
                if (comboBox1.SelectedItem.ToString() == "A-76")
                {
                    result = double.Parse(textBox2.Text);
                    label3.Text = (result * 6.40).ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Ai-92")
                {
                    result = double.Parse(textBox2.Text);
                    label3.Text = (result * 2.60).ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Ai-95")
                {
                    result = double.Parse(textBox2.Text);
                    label3.Text = (result * 4.50).ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Premium")
                {
                    result = double.Parse(textBox2.Text);
                    label3.Text = (result * 8.50).ToString();
                }
            }
            else
            {
                label3.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked) textBox11.ReadOnly = false;
            else
            {
                textBox11.Text = "";
                textBox11.ReadOnly = true;
            }

        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) textBox10.ReadOnly = false;
            else
            {
                textBox10.Text = "";
                textBox10.ReadOnly = true;
            }
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) textBox9.ReadOnly = false;
            else
            {
                textBox9.Text = "";
                textBox9.ReadOnly = true;
            }
        }



        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) textBox8.ReadOnly = false;
            else
            {
                textBox8.Text = "";
                textBox8.ReadOnly = true;
            }
        }




        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double result = 0;

            if (textBox11.Text.Length != 0)
            {
                result = int.Parse(textBox11.Text);

                if (checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
                {
                    double copyResult = 0;

                    copyResult = double.Parse(label4.Text);
                    copyResult += (4.00 * result);

                    label4.Text = copyResult.ToString();

                }
                else
                {
                    label4.Text = (4.00 * result).ToString();
                }

            }
            else
            {
                label4.Text = "0";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double result = 0;

            if (textBox10.Text.Length != 0)
            {
                result = int.Parse(textBox10.Text);

                if (checkBox1.Checked || checkBox3.Checked || checkBox4.Checked)
                {
                    double copyResult = 0;

                    copyResult = double.Parse(label4.Text);
                    copyResult += (5.40 * result);

                    label4.Text = copyResult.ToString();
                }
                else
                {
                    label4.Text = (5.40 * result).ToString();
                }
            }
            else
            {
                label4.Text = "0";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double result = 0;

            if (textBox9.Text.Length != 0)
            {
                result = int.Parse(textBox9.Text);

                if (checkBox1.Checked || checkBox2.Checked || checkBox4.Checked)
                {
                    double copyResult = 0;

                    copyResult = double.Parse(label4.Text);
                    copyResult += (7.20 * result);

                    label4.Text = copyResult.ToString();
                }
                else
                {
                    label4.Text = (7.20 * result).ToString();
                }
            }
            else
            {
                label4.Text = "0";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double result = 0;

            if (textBox8.Text.Length != 0)
            {
                result = int.Parse(textBox8.Text);

                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                {
                    double copyResult = 0;

                    copyResult = double.Parse(label4.Text);
                    copyResult += (4.20 * result);

                    label4.Text = copyResult.ToString();
                }
                else
                {
                    label4.Text = (4.20 * result).ToString();
                }
            }
            else
            {
                label4.Text = "0";
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;

            result = (double.Parse(label3.Text) + double.Parse(label4.Text));

            label7.Text = result.ToString();

            MessageBox.Show("Success", "Info");


            label7.Text = "0";
            label4.Text = "0";
            label3.Text = "0";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textBox2.ReadOnly = true;

            comboBox1.Text = "";
            textBox1.Text = "";
        }
    }
    
}
