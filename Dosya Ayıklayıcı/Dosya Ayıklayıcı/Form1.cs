using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Dosya_Ayıklayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (String kaynak in Directory.GetDirectories(textBox1.Text))
            {
                listBox1.Items.Add(kaynak);
                foreach (string klasor1 in Directory.GetDirectories(kaynak))
                {
                    listBox1.Items.Add(klasor1);
                    foreach (string klasor2 in Directory.GetDirectories(klasor1))
                    {
                        listBox1.Items.Add(klasor2);
                        foreach (string klasor3 in Directory.GetDirectories(klasor2))
                        {
                            listBox1.Items.Add(klasor3);
                            foreach (string klasor4 in Directory.GetDirectories(klasor3))
                            {
                                listBox1.Items.Add(klasor4);
                                foreach (string klasor5 in Directory.GetDirectories(klasor4))
                                {
                                    listBox1.Items.Add(klasor5);
                                    foreach (string klasor6 in Directory.GetDirectories(klasor5))
                                    {
                                        listBox1.Items.Add(klasor6);
                                        foreach (string klasor7 in Directory.GetDirectories(klasor6))
                                        {
                                            listBox1.Items.Add(klasor7);
                                            foreach (string klasor8 in Directory.GetDirectories(klasor7))
                                            {
                                                listBox1.Items.Add(klasor8);
                                                foreach (string klasor9 in Directory.GetDirectories(klasor8))
                                                {
                                                    listBox1.Items.Add(klasor9);
                                                    foreach (string klasor10 in Directory.GetDirectories(klasor9))
                                                    {
                                                        listBox1.Items.Add(klasor10);
                                                        foreach (string klasor11 in Directory.GetDirectories(klasor10))
                                                        {
                                                            listBox1.Items.Add(klasor11);
                                                            foreach (string klasor12 in Directory.GetDirectories(klasor11))
                                                            {
                                                                listBox1.Items.Add(klasor12);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (string dosya in Directory.GetFiles(textBox1.Text))
            {
                openFileDialog1.FileName = dosya;
                string dsyad = openFileDialog1.SafeFileName;

                if (comboBox1.SelectedIndex == 0)
                {
                    if (File.Exists(textBox2.Text + "\\" + dsyad))
                    {
                        dsyad = "(-2-)" + dsyad;
                    }
                    File.Move(dosya, textBox2.Text + "\\" + dsyad);
                }
                else if (dsyad.Contains(textBox3.Text))
                {
                    if (File.Exists(textBox2.Text + "\\" + dsyad))
                    {
                        dsyad = "(-2-)" + dsyad;
                    }
                    File.Move(dosya, textBox2.Text + "\\" + dsyad);
                }
            }

            foreach (string klasoryol in listBox1.Items)
            {
                foreach (string dosya in Directory.GetFiles(klasoryol))
                {
                    openFileDialog1.FileName = dosya;
                    string dsyad = openFileDialog1.SafeFileName;

                    if (comboBox1.SelectedIndex == 0)
                    {
                        if (File.Exists(textBox2.Text + "\\" + dsyad))
                        {
                            dsyad = "(-2-)" + dsyad;
                        }
                        File.Move(dosya, textBox2.Text + "\\" + dsyad);
                    }
                    else if (dsyad.Contains(textBox3.Text))
                    {
                        if (File.Exists(textBox2.Text + "\\" + dsyad))
                        {
                            dsyad = "(-2-)" + dsyad;
                        }
                        File.Move(dosya, textBox2.Text + "\\" + dsyad);
                    }
                }
              
            }

            textBox3.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
