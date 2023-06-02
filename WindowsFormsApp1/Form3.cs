using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_zadani_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_adresa_Leave(object sender, EventArgs e)
        {
                

               
        }


        private void textBox_maska_TextChanged(object sender, EventArgs e)  // Výpočet masky
        {

            /* if (string.IsNullOrEmpty(textBox_maska.Text))
            {
                // Vstupní pole je prázdné, nemusí se provádět žádný převod
                textBox_maska.Text = string.Empty;
            } else
            {
                int maska = Convert.ToInt32(textBox_maska.Text);
                string maska_binar = "";

            if (maska >= 0 && maska <= 32)
            {
                for (int i = 0; i < maska; i++)
                {
                    maska_binar += "1";
                }

                for (int i = maska; i < 32; i++)
                {
                    maska_binar += "0";
                }
               
                 int maskaIP = Convert.ToInt32(maska_binar, 2);
                 byte[] maskaBytes = BitConverter.GetBytes(maskaIP); // Pole s funkcí z C#

                 label_maska.Text = $"{maskaBytes[3]}.{maskaBytes[2]}.{maskaBytes[1]}.{maskaBytes[0]}"; // Zobrazení masky ve správném tvaru (255.x.x.x)

            
            }
            else
            {
                MessageBox.Show("Neplatná maska. Maska musí být větší než 0 a menší než 32", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
            } */
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_sit_Click(object sender, EventArgs e)
        {
           
                

        }

        private IPAddress GetNextUsableAddress(IPAddress address)
        {
            byte[] addressBytes = address.GetAddressBytes();

            // Inkrementujte poslední bajt adresy
            addressBytes[addressBytes.Length - 1]++;

            // Pokud je adresa plná 0 nebo plná 255, pokračujte v inkrementaci dalších bajtů
            for (int i = addressBytes.Length - 1; i >= 0; i--)
            {
                if (addressBytes[i] != 0)
                    break;

                addressBytes[i - 1]++;
            }

            return new IPAddress(addressBytes);
        }

        private IPAddress GetPreviousUsableAddress(IPAddress address)
        {
            byte[] addressBytes = address.GetAddressBytes();

            // Dekrementujte poslední bajt adresy
            addressBytes[addressBytes.Length - 1]--;

            // Pokud je adresa plná 255 nebo plná 0, pokračujte v dekrementaci dalších bajtů
            for (int i = addressBytes.Length - 1; i >= 0; i--)
            {
                if (addressBytes[i] != 255)
                    break;

                addressBytes[i - 1]--;
            }

            return new IPAddress(addressBytes);
        }

        private void button_vypocitat_Click_1(object sender, EventArgs e)
        {
            string ipAddressString = textBox_adresa.Text;
            string subnetMaskString = textBox_maska.Text;

            
                IPAddress ipAddress;
                IPAddress subnetMask;

            if (IPAddress.TryParse(ipAddressString, out ipAddress) && IPAddress.TryParse(subnetMaskString, out subnetMask))
            {
                IPNetwork network = IPNetwork.Parse($"{ipAddress}/{subnetMask}");
                IPAddress firstUsableAddress = GetNextUsableAddress(network.Network);
                IPAddress lastUsableAddress = GetPreviousUsableAddress(network.Broadcast);

                label_sit.Text = network.Network.ToString();
                label_prvni.Text = firstUsableAddress.ToString();
                label_posledni.Text = lastUsableAddress.ToString();
                label_broadcast.Text = network.Broadcast.ToString();
                label_maska.Text = "/" + network.Cidr.ToString();
                label_wild.Text = network.WildcardMask.ToString();
                label_trid.Text = network.AddressFamily.ToString();
                
            }
            
            else
            {
                MessageBox.Show("Špatně zadaná IP Adresa nebo mask.");
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void matematickáKalkulačkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kalkulačka kalkulačka = new Kalkulačka();
            kalkulačka.Show();
            this.Hide();

        }

        private void převodMeziSoustavamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }

    }









