using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{



    public partial class Kalkulačka : Form
    {
        double a, b, hodnotaPamet;
        double vysledek = 0;
        int x;
        string operace;

        bool stupne = false;
        bool shiftZmacknuty = false;

        public Kalkulačka()
        {
            InitializeComponent();
            this.button_pridaniPamet.Click += new System.EventHandler(this.button_pridaniPamet_Click);
            this.button_odebraniPamet.Click += new System.EventHandler(this.button_odebraniPamet_Click);
            this.button_obnoveniPamet.Click += new System.EventHandler(this.button_obnoveniPamet_Click);
            this.button_vymazaniPamet.Click += new System.EventHandler(this.button_vymazaniPamet_Click);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_dvojka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_trojka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_ctyrka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_petka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_sestka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_sedmicka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_osmicka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_devitka_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_nula_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_vysledek.Text += button.Text;
        }

        private void button_scitani_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(operace) && !string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                // Pokud již byla provedena předchozí operace, zavoláme metodu button_vysledek_Click pro vyhodnocení výrazu
                button_vysledek_Click(sender, e);
            }

            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = button.Text;
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " " + " ");


        }


        private void button_odecitani_Click(object sender, EventArgs e) // tlačítko na odečítání
        {
            Button button = (Button)sender;

            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(operace) && !string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                // Pokud již byla provedena předchozí operace, zavoláme metodu button_vysledek_Click pro vyhodnocení výrazu
                button_vysledek_Click(sender, e);
            }

            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = button.Text;
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " " + " ");
        }

        private void button_deleni_Click(object sender, EventArgs e) // tlačítko na dělení
        {
            Button button = (Button)sender;

            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(operace) && !string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                // Pokud již byla provedena předchozí operace, zavoláme metodu button_vysledek_Click pro vyhodnocení výrazu
                button_vysledek_Click(sender, e);
            }

            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = button.Text;
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " " + " ");
        }

        private void button_nasobeni_Click(object sender, EventArgs e) // tlačítko na dělení
        {
            Button button = (Button)sender;

            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(operace) && !string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                // Pokud již byla provedena předchozí operace, zavoláme metodu button_vysledek_Click pro vyhodnocení výrazu
                button_vysledek_Click(sender, e);
            }

            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = button.Text;
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " " + " ");
        }

        private void button_pí_Click(object sender, EventArgs e)
        {

        }

        private void button_pi_Click(object sender, EventArgs e) // tlačítko s funkcí Pí
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(operace) && !string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                // Pokud již byla provedena předchozí operace, zavoláme metodu button_vysledek_Click pro vyhodnocení výrazu
                button_vysledek_Click(sender, e);
            }

            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = button.Text;
            vysledek = a * Math.PI;
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(vysledek.ToString());
        }



        private void button_sin_Click(object sender, EventArgs e) // tlačítko s funkcí sinus
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("Nezadali jste žádné číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = Convert.ToDouble(textBox_vysledek.Text);
                operace = button.Text;

                if (shiftZmacknuty)
                {
                    vysledek = Math.Asin(a) * (180 / Math.PI); // Výpočet arcsinu a převod na úhel ve stupních
                    double stupne = (vysledek * 180) / Math.PI;
                    textBox_vysledek.Text = vysledek.ToString();
                }
                else
                {
                    vysledek = Math.Sin(a * (Math.PI / 180)); // Výpočet sinu
                    double stupne = (vysledek * 180) / Math.PI;
                    textBox_vysledek.AppendText(" sin");
                }
            }
        }

        private void button_cos_Click(object sender, EventArgs e) // Tlačítko s funkcí cosinus
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("Nezadali jste žádné číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = Convert.ToDouble(textBox_vysledek.Text);
                operace = button.Text;

                if (shiftZmacknuty)
                {
                    vysledek = Math.Acos(a) * (180 / Math.PI); // Výpočet arcscos a převod na úhel ve stupních
                    textBox_vysledek.Text = vysledek.ToString();
                }
                else
                {
                    vysledek = Math.Acos(a * (Math.PI / 180)); // Výpočet cos
                    textBox_vysledek.AppendText(" cos");
                }
            }
        }
        private void button_tg_Click(object sender, EventArgs e) // Tlačítko s funkcí tangens
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("Nezadali jste žádné číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = Convert.ToDouble(textBox_vysledek.Text);
                operace = button.Text;

                if (shiftZmacknuty)
                {
                    vysledek = Math.Atan(a) * (180 / Math.PI); // Výpočet arcstg a převod na úhel ve stupních
                    textBox_vysledek.Text = vysledek.ToString();
                }
                else
                {
                    vysledek = Math.Sin(a * (Math.PI / 180)); // Výpočet tg
                    textBox_vysledek.AppendText(" tg");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // Tlačítko s funkcí contg
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("Nezadali jste žádné číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = Convert.ToDouble(textBox_vysledek.Text);
                operace = button.Text;

                if (shiftZmacknuty)
                {
                    vysledek = 1 / Math.Atan(a) * (180 / Math.PI); // Výpočet arcstg a převod na úhel ve stupních
                    textBox_vysledek.Text = vysledek.ToString();
                }
                else
                {
                    vysledek = 1 / Math.Atan(a * (Math.PI / 180)); // Výpočet cotg
                    textBox_vysledek.AppendText(" " + operace + " ");
                }
            }
        }


        private void button_mocnina_Click(object sender, EventArgs e) // Tlačítko s mocninou (Na druhou)
        {

            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = "^2";
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " ");
        }

        private void button_odmocnina_Click(object sender, EventArgs e) // Tlačítko s odmocninou
        {

        }

        private void button_log_Click(object sender, EventArgs e) // Tlačítko s logaritmem
        {
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = "log";
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " ");
        }

        private void button_carka_Click(object sender, EventArgs e) // Tlačítko s čárkou
        {

            string kontrola = textBox_vysledek.Text;
            if (kontrola.EndsWith(",,")) // Pokud jsou za sebou dvě a více čárek
            {
                MessageBox.Show("Zadali jste příliš mnoho čárek", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox_vysledek.AppendText(",");
        }

        private void button_shift_Click(object sender, EventArgs e)
        {
            shiftZmacknuty = !shiftZmacknuty;
        }

        private void button_xOdmocnina_Click(object sender, EventArgs e) // Tlačítko pro procenta
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = button.Text;
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " ");
        }


        /*
            Tlačítka pro práci s paměťí
            pridaniPamet = M+ - přidání hodnoty zobrazené na displeji do paměti.
            odebraniPamet = M- - Odebrání hodnoty zobrazené na displeji z paměti.
            vymazaniPamet = MC - Vymazání obsahu paměti.
            obnoveniPamet = MR - Načtení hodnoty z paměti a zobrazení na displeji.

        */

        private void button_pridaniPamet_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                double aktualniHodnota = Convert.ToDouble(textBox_vysledek.Text);
                hodnotaPamet = aktualniHodnota;
            }
        }

        private void button_odebraniPamet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                double aktualniHodnota = Convert.ToDouble(textBox_vysledek.Text);
                hodnotaPamet = 0;
            }

            if (hodnotaPamet > 0.01)
            {
                button_obnoveniPamet.BackColor = Color.Gray;
            }
            else
            {
                button_obnoveniPamet.BackColor = Color.White;
            }
        }

        private void button_vymazaniPamet_Click(object sender, EventArgs e)
        {
            hodnotaPamet = 0;
        }

        private void button_obnoveniPamet_Click(object sender, EventArgs e)
        {
            textBox_vysledek.Text = hodnotaPamet.ToString();
        }

        private void button_3Odmocnina_Click(object sender, EventArgs e) // tlačítko pro třetí odmocninu
        {

        }

        private void button_faktorial_Click(object sender, EventArgs e) // Tlačítko pro faktoriál
        {

        }

        private void button_plusminus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                double hodnota = Convert.ToDouble(textBox_vysledek.Text);
                hodnota = -hodnota; // Změna znaménka

                textBox_vysledek.Text = hodnota.ToString();
            }
        }

        private void button_stupne_Click(object sender, EventArgs e)
        {

        }

        private void button_3Odmocnina_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            a = Convert.ToDouble(textBox_vysledek.Text);
            operace = "∛";
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " ");
        }

        private void button_odmocnina_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            a = Convert.ToDouble(textBox_vysledek.Text);
            vysledek = Math.Sqrt(a);
            operace = "√";
            textBox_vysledek.Clear();
            textBox_vysledek.AppendText(a.ToString() + " " + operace + " ");
        }

        private void button_stupne_Click_1(object sender, EventArgs e)
        {
            if (stupne == true)
            {
                // Přepnutí na desetinné číslo
                double hodnota = Convert.ToDouble(textBox_vysledek.Text);
                textBox_vysledek.Text = hodnota.ToString();
            }
            else
            {
                // Přepnutí na stupně a minuty
                double hodnota = Convert.ToDouble(textBox_vysledek.Text);
                int stupne = Convert.ToInt32(hodnota); // Celá část desetinného čísla je počet stupňů
                double zbytek = hodnota - stupne; // Zbývající desetinná část pro výpočet minut
                int minuty = Convert.ToInt32((zbytek * 60)); // Převod na minuty (desetinná část * 60)
                textBox_vysledek.Text = $"{stupne}° {minuty}'";
            }
        }

        private void button_faktorial_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_vysledek.Text))
            {
                MessageBox.Show("První musí být číslo", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            a = Convert.ToDouble(textBox_vysledek.Text);

            if (a > 20)
            {
                MessageBox.Show("Maximální číslo pro výpočet faktoriálu je 20.", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (a < 0)
            {
                MessageBox.Show("Minimální číslo pro výpočet faktoriálu je 0.", "Chyba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                operace = "!";
                textBox_vysledek.Clear();
                textBox_vysledek.AppendText(a.ToString() + " " + operace + " ");
            }
        }

        private void matematickáToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void převodMeziSoustavamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void výpočetPodsíťíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button_vymazani_Click(object sender, EventArgs e) // tlačítko na vymazání
        {
            textBox_vysledek.Clear();
            a = 0;
            b = 0;
            vysledek = 0;
        }
        private void button_vysledek_Click(object sender, EventArgs e)
        {

            
                if (string.IsNullOrEmpty(textBox_vysledek.Text))
                {
                    MessageBox.Show("Zpusťte program znovu", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    string vstup = textBox_vysledek.Text;
                    string[] oddelene = vstup.Split(' ');


                    switch (operace)
                    {
                        case "+":
                         b = Convert.ToDouble(oddelene[3]);
                        vysledek = a + b;
                            break;
                        case "-":
                         b = Convert.ToDouble(oddelene[3]);
                        vysledek = a - b;
                            break;
                        case "*":
                         b = Convert.ToDouble(oddelene[3]);
                        vysledek = a * b;
                            break;
                        case "/":
                         b = Convert.ToDouble(oddelene[3]);
                        if (b != 0)
                            {
                                vysledek = a / b;

                            }
                            else
                            {
                                MessageBox.Show("Nulou nelze dělit / číslem menším než 0 nelze dělit");
                            }
                            break;
                        case "pi":
                            vysledek = a * Math.PI;
                            break;
                        case "sin":
                            if (shiftZmacknuty)
                            {
                                double radiany = a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Asin(radiany); // Výpočet arcsinu
                                                               // double stupne = (vysledek * 180) / Math.PI; DODELAT
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("asin(" + a.ToString() + ")");

                            }
                            else
                            {
                                double radiany = a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Sin(radiany); // Výpočet sinu
                                                              // double stupne = (vysledek * 180) / Math.PI; DODELAT
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("sin(" + a.ToString() + ")");

                            }
                            break;
                        case "cos":
                            if (shiftZmacknuty)
                            {
                                double radiany = a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Acos(radiany); // Výpočet acos
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("acos(" + a.ToString() + ")");
                            }
                            else
                            {
                                double radiany = a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Cos(radiany); // Výpočet acos
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("cos(" + a.ToString() + ")");
                            }
                            break;
                        case "tg":
                            if (shiftZmacknuty)
                            {
                                double radiany = a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Atan(radiany); // Výpočet arcsgg
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("atg(" + a.ToString() + ")");
                            }
                            else
                            {
                                double radiany = a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Atan(radiany); // Výpočet tg
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("tg(" + a.ToString() + ")");
                            }
                            break;
                        case "cotg":
                            if (shiftZmacknuty)
                            {
                                double radiany = 1 / a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Atan(radiany); // Výpočet aCotg
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("acotg(" + a.ToString() + ")");
                            }
                            else
                            {
                                double radiany = 1 / a * (Math.PI / 180); // Převod úhlu ze stupňů na radiány
                                vysledek = Math.Atan(radiany); // Výpočet cotg
                                textBox_vysledek.Clear();
                                textBox_vysledek.AppendText("cotg(" + a.ToString() + ")");
                            }
                            break;
                        case "^2":
                            vysledek = Math.Pow(a, 2);
                            break;
                        case "Shift":
                            shiftZmacknuty = true;
                            break;
                        case "√":
                            if (a < 0)
                            {
                                MessageBox.Show("Chyba");
                            }
                            else
                            {
                                vysledek = Math.Sqrt(a);
                            }
                            break;
                        case "log":
                            vysledek = Math.Log10(a);
                            break;
                        case "∛":
                            vysledek = Math.Pow(a, 1.0 / 3.0);
                            break;
                        case "%":
                            vysledek = a / 100;
                            break;
                        case "!":
                            int faktorial = 1;
                            for (int i = 1; i <= a; i++)
                            {
                                faktorial *= i; // Př: Pro 5! = (5 * 1) * (4 * 1) * (3 * 1) * (2 * 1) * (1 *1) = 120
                            }
                            vysledek = faktorial;
                            break;
                        case "±":
                            vysledek = -vysledek; // Změna znaménka
                            break;
                        default:
                            MessageBox.Show("Neplatná operace", "Chyba",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    textBox_vysledek.Text = vysledek.ToString();
                }
            }

        



        private void světlýToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.GhostWhite;
            button_carka.BackColor = Color.WhiteSmoke;
            button_carka.ForeColor = Color.Black;
            button_cos.BackColor = Color.WhiteSmoke;
            button_cos.ForeColor = Color.Black;
            button_sin.BackColor = Color.WhiteSmoke;
            button_sin.ForeColor = Color.Black;
            button_cotg.BackColor = Color.WhiteSmoke;
            button_cotg.ForeColor = Color.Black;
            button_ctyrka.BackColor = Color.WhiteSmoke;
            button_ctyrka.ForeColor = Color.Black;
            button_deleni.BackColor = Color.WhiteSmoke;
            button_deleni.ForeColor = Color.Black;
            button_devitka.BackColor = Color.WhiteSmoke;
            button_devitka.ForeColor = Color.Black;
            button_dvojka.BackColor = Color.WhiteSmoke;
            button_dvojka.ForeColor = Color.Black;
            button_jednicka.BackColor = Color.WhiteSmoke;
            button_jednicka.ForeColor = Color.Black;
            button_odmocnina.BackColor = Color.WhiteSmoke;
            button_odmocnina.ForeColor = Color.Black;
            button_osmicka.BackColor = Color.WhiteSmoke;
            button_osmicka.ForeColor = Color.Black;
            button_trojka.BackColor = Color.WhiteSmoke;
            button_trojka.ForeColor = Color.Black;
            button_ctyrka.BackColor = Color.WhiteSmoke;
            button_ctyrka.ForeColor = Color.Black;
            button_petka.BackColor = Color.WhiteSmoke;
            button_petka.ForeColor = Color.Black;
            button_sestka.BackColor = Color.WhiteSmoke;
            button_sestka.ForeColor = Color.Black;
            button_sedmicka.BackColor = Color.WhiteSmoke;
            button_sedmicka.ForeColor = Color.Black;
            button_log.BackColor = Color.WhiteSmoke;
            button_log.ForeColor = Color.Black;
            button_scitani.BackColor = Color.WhiteSmoke;
            button_scitani.ForeColor = Color.Black;
            button_nula.BackColor = Color.WhiteSmoke;
            button_nula.ForeColor = Color.Black;
            button_shift.BackColor = Color.WhiteSmoke;
            button_shift.ForeColor = Color.Black;
            button_tg.BackColor = Color.WhiteSmoke;
            button_tg.ForeColor = Color.Black;
            button_pridaniPamet.BackColor = Color.WhiteSmoke;
            button_pridaniPamet.ForeColor = Color.Black;
            button_odebraniPamet.BackColor = Color.WhiteSmoke;
            button_odebraniPamet.ForeColor = Color.Black;
            button_obnoveniPamet.BackColor = Color.WhiteSmoke;
            button_obnoveniPamet.ForeColor = Color.Black;
            button_vymazaniPamet.BackColor = Color.WhiteSmoke;
            button_vymazaniPamet.ForeColor = Color.Black;
            button_vysledek.BackColor = Color.DeepSkyBlue;
            button_vysledek.ForeColor = Color.White;
            button_procenta.BackColor = Color.WhiteSmoke;
            button_procenta.ForeColor = Color.Black;
            button_mocnina.BackColor = Color.WhiteSmoke;
            button_mocnina.ForeColor = Color.Black;
            button_3Odmocnina.BackColor = Color.WhiteSmoke;
            button_3Odmocnina.ForeColor = Color.Black;
            button_pi.BackColor = Color.WhiteSmoke;
            button_pi.ForeColor = Color.Black;
            button_nasobeni.BackColor = Color.WhiteSmoke;
            button_nasobeni.ForeColor = Color.Black;
            button_odecitani.BackColor = Color.WhiteSmoke;
            button_odecitani.ForeColor = Color.Black;
            button_vymazani.BackColor = Color.WhiteSmoke;
            button_vymazani.ForeColor = Color.Black;
            button_faktorial.BackColor = Color.WhiteSmoke;
            button_faktorial.ForeColor = Color.Black;
            button_minus.BackColor = Color.WhiteSmoke;
            button_minus.ForeColor = Color.Black;
            button_stupne.BackColor = Color.WhiteSmoke;
            button_stupne.ForeColor = Color.Black;
        }

        private void tmavýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int red = 255;
            int green = 128;
            int blue = 0;

            Color ctyry_znaky = Color.FromArgb(red, green, blue);

            int red2 = 64;
            int green2 = 64;
            int blue2 = 64;

            Color pozadi = Color.FromArgb(red2, green2, blue2);

            
            BackColor = pozadi;
            button_carka.BackColor = Color.Gray;
            button_carka.ForeColor = Color.Black;
            button_cos.BackColor = Color.Gray;
            button_cos.ForeColor = Color.Black;
            button_sin.BackColor = Color.Gray;
            button_sin.ForeColor = Color.Black;
            button_cotg.BackColor = Color.Gray;
            button_cotg.ForeColor = Color.Black;
            button_ctyrka.BackColor = Color.Gray;
            button_ctyrka.ForeColor = Color.Black;
            button_deleni.BackColor = ctyry_znaky;
            button_deleni.ForeColor = Color.Black;
            button_devitka.BackColor = Color.Gray;
            button_devitka.ForeColor = Color.Black;
            button_dvojka.BackColor = Color.Gray;
            button_dvojka.ForeColor = Color.Black;
            button_jednicka.BackColor = Color.Gray;
            button_jednicka.ForeColor = Color.Black;
            button_odmocnina.BackColor = Color.Gray;
            button_odmocnina.ForeColor = Color.Black;
            button_osmicka.BackColor = Color.Gray;
            button_osmicka.ForeColor = Color.Black;
            button_trojka.BackColor = Color.Gray;
            button_trojka.ForeColor = Color.Black;
            button_ctyrka.BackColor = Color.Gray;
            button_ctyrka.ForeColor = Color.Black;
            button_petka.BackColor = Color.Gray;
            button_petka.ForeColor = Color.Black;
            button_sestka.BackColor = Color.Gray;
            button_sestka.ForeColor = Color.Black;
            button_sedmicka.BackColor = Color.Gray;
            button_sedmicka.ForeColor = Color.Black;
            button_log.BackColor = Color.Gray;
            button_log.ForeColor = Color.Black;
            button_scitani.BackColor = ctyry_znaky;
            button_scitani.ForeColor = Color.Black;
            button_nula.BackColor = Color.Gray;
            button_nula.ForeColor = Color.Black;
            button_shift.BackColor = Color.Gray;
            button_shift.ForeColor = Color.Black;
            button_tg.BackColor = Color.Gray;
            button_tg.ForeColor = Color.Black;
            button_pridaniPamet.BackColor = Color.Gray;
            button_pridaniPamet.ForeColor = Color.Black;
            button_odebraniPamet.BackColor = Color.Gray;
            button_odebraniPamet.ForeColor = Color.Black;
            button_obnoveniPamet.BackColor = Color.Gray;
            button_obnoveniPamet.ForeColor = Color.Black;
            button_vymazaniPamet.BackColor = Color.Gray;
            button_vymazaniPamet.ForeColor = Color.Black;
            button_vysledek.BackColor = ctyry_znaky;
            button_vysledek.ForeColor = Color.Black;
            button_procenta.BackColor = Color.Gray;
            button_procenta.ForeColor = Color.Black;
            button_mocnina.BackColor = Color.Gray;
            button_mocnina.ForeColor = Color.Black;
            button_3Odmocnina.BackColor = Color.Gray;
            button_3Odmocnina.ForeColor = Color.Black;
            button_pi.BackColor = Color.Gray;
            button_pi.ForeColor = Color.Black;
            button_nasobeni.BackColor = ctyry_znaky;
            button_nasobeni.ForeColor = Color.Black;
            button_odecitani.BackColor = ctyry_znaky;
            button_odecitani.ForeColor = Color.Black;
            button_vymazani.BackColor = Color.Gray;
            button_vymazani.ForeColor = Color.Black;
            button_faktorial.BackColor = Color.Gray;
            button_faktorial.ForeColor = Color.Black;
            button_minus.BackColor = Color.Gray;
            button_minus.ForeColor = Color.Black;
            button_stupne.BackColor = Color.Gray;
            button_stupne.ForeColor = Color.Black;
        }

        private void světlýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void základníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}




