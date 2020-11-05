using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib.dll;

namespace Work_quest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("16,48","Код 1.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("24,71", "Код 2.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("92,32", "Код 3.");
        }

        public void button4_Click(object sender, EventArgs e)
        {
          

            if (radioButton1.Checked)
            {
          
                if (textBox1.Text =="24" && textBox2.Text == "71") // Проверка правильности кода
                {
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    button5.Visible = true;
                    button4.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label4.Visible = true;
                }
                else
                {
                    label1.Text = "Неправильный код!";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
               
                    
                finaly name1  = new finaly();
                name1.PluginName = "PrototypeA";
                label7.Text = name1.PluginName;
                name1.Description = "Лучшая версия прошивки генератора Альфа.";
                label9.Text = name1.Description;
                textBox5.Text = "A";
            }

            if (radioButton2.Checked)
            {

                if (textBox1.Text == "92" && textBox2.Text == "32") // Проверка правильности кода
                {
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    button5.Visible = true;
                    button4.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label4.Visible = true;
                }
                else
                {
                    label1.Text = "Неправильный код!";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }


                finaly name2 = new finaly();
                name2.PluginName = "PrototypeB";
                label7.Text = name2.PluginName;
                name2.Description = "Лучшая версия прошивки генератора Бетта.";
                label9.Text = name2.Description;
                textBox5.Text = "B";
            }
                if (radioButton3.Checked)
                {
               
                    if (textBox1.Text == "16" && textBox2.Text == "48") // Проверка правильности кода
                    {
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        button5.Visible = true;
                        button4.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        label4.Visible = true;
                    }
                    else
                    {
                        label1.Text = "Неправильный код!";
                        textBox1.Text = "";
                        textBox2.Text = "";
                    
                    }
                    finaly name3 = new finaly();
                    name3.PluginName = "PrototypeG";
                    label7.Text = name3.PluginName;
                    name3.Description = "Лучшая версия прошивки генератора Гамма.";
                    label9.Text = name3.Description;
                textBox5.Text = "G";
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == ("") || textBox4.Text == (""))
            {
                label1.Text = "Нет кода!";
            }
            int kode1 = Convert.ToInt32(textBox3.Text);// Конвертирование  в число
            int kode2 = Convert.ToInt32(textBox4.Text);

            finaly version = new finaly(); //Обращаюсь к библеотеке (lib.dll) и исполбзую метод Run
           
            version.Version = Convert.ToString (version.Run(kode1, kode2)); //Вставляю на место input1 и input2 переменные со значением
                                                                            
            textBox5.Text += version.Version;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            textBox5.Visible = true;
        }
    }
    
}
