using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void textBox_vysledek_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {

                textBox_vysledek2.Text = string.Empty;
                textBox_vysledek3.Text = string.Empty;
                textBox_vysledek4.Text = string.Empty;
            }
            else if (int.TryParse(textBox_vysledek.Text, out int decimalni))
            {

                string result = Convert.ToString(decimalni, 2);
                string result_eight = Convert.ToString(decimalni, 8);
                string result_sixteen = decimalni.ToString("X");

                textBox_vysledek2.Text = result;
                textBox_vysledek3.Text = result_eight;
                textBox_vysledek4.Text = result_sixteen;
            }
            else
            {
                MessageBox.Show("První musí být číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(textBox_vysledek3.Text))
                {
                    textBox_vysledek.Text = string.Empty;
                    textBox_vysledek2.Text = string.Empty;
                    textBox_vysledek4.Text = string.Empty;
                }
                else if (IsOctalNumber(textBox_vysledek3.Text))
                {
                    int osmickova = Convert.ToInt32(textBox_vysledek3.Text, 8);
                    string result_desitkova = osmickova.ToString();
                    string result_binarni = Convert.ToString(osmickova, 2);
                    string result_sestnactkova = osmickova.ToString("X");

                    textBox_vysledek.Text = result_desitkova;
                    textBox_vysledek2.Text = result_binarni;
                    textBox_vysledek4.Text = result_sestnactkova;
                }
                else
                {
                    MessageBox.Show("Zadejte platné osmičkové číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_vysledek3.Text = string.Empty; // Vymaže chybně zadanou hodnotu
                }
            }

          
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_vysledek2.Text))
            {
                // Vstupní pole je prázdné, nemusí se provádět žádný převod
                textBox_vysledek.Text = string.Empty;
            }
            else if (IsBinaryNumber(textBox_vysledek2.Text))
            {
                int decimalni = Convert.ToInt32(textBox_vysledek2.Text, 2);
                textBox_vysledek.Text = decimalni.ToString();
            }
            else
            {
                MessageBox.Show("Zadejte platné binární číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool IsBinaryNumber(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsOctalNumber(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '7')
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(textBox_vysledek4.Text))
                {
                    textBox_vysledek.Text = string.Empty;
                    textBox_vysledek2.Text = string.Empty;
                    textBox_vysledek3.Text = string.Empty;
                }
                else if (IsHexCislo(textBox_vysledek4.Text))
                {
                    int sestnactkova = Convert.ToInt32(textBox_vysledek4.Text, 16);
                    string result_desitkova = sestnactkova.ToString();
                    string result_binarni = Convert.ToString(sestnactkova, 2);
                    string result_osmickova = Convert.ToString(sestnactkova, 8);

                    textBox_vysledek.Text = result_desitkova;
                    textBox_vysledek2.Text = result_binarni;
                    textBox_vysledek3.Text = result_osmickova;
                }
                else
                {
                    MessageBox.Show("Zadejte platné šestnáctkové číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_vysledek4.Text = string.Empty; // Vymaže chybně zadanou hodnotu
                }
            }

            private bool IsHexCislo(string input) // Kontrola zda uživatel zadal správně čísla
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c) && !IsHexPismeno(c))
                    {
                        return false;
                    }
                }
                return true;
            }

            private bool IsHexPismeno(char c)
            {
                return (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f'); // Povolené písmenka, jak velké tak i malé
            }

        private void matematickáKalkulačkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kalkulačka kalkulačka = new Kalkulačka();
            kalkulačka.Show();
            this.Hide();
        }

        private void výpočetPodsítěToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
