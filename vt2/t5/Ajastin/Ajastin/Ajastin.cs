using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//@author Ruukinen
//@version Lopullinen 26.9 2014

namespace Ajastin
{
    public partial class keittioAjastin : Form
    {
        private List<string> valiaikoja = new List<string>();
        private int a;
        private TimeSpan IdleTime;
        private TimeSpan TimingTime;

        public keittioAjastin()
        {
            InitializeComponent();
            paivitaAika();
            AikaLoppui();
            Valiajat();

            aikaLaatikko1.OK += delegate(object sender, EventArgs e)
            {
                resettausNappi.Enabled = true;
            };

            aikaLaatikko1.Virhe += delegate(object sender, EventArgs e)
            {
                resettausNappi.Enabled = false;
            };

            kello1.IdleOver += delegate(object sender, EventArgs e)
            {
                IdleTime = (TimeSpan)sender;
            };

            kello1.TimingOver += delegate(object sender, EventArgs e)
            {
                TimingTime = (TimeSpan)sender;
            };
        }

        private void Suljetaan(object sender, FormClosingEventArgs e)
        {
            if (aloitaNappi.Enabled != true)
            {
                e.Cancel = true;
            }
        }

        private void AikaLoppui()
        {
            kello1.Halytys += delegate(object sender, EventArgs e)
            {
                aloitaNappi.Enabled = true;
                stopNappi.Enabled = false;
                kello1.Stop();
                MessageBox.Show("Aika Loppui");
            };
        }

        private void aloitaNappi_Click(object sender, EventArgs e)
        {
            kello1.aloitettu = 1;
            kello1.Start();
            aloitaNappi.Visible = false;
            aloitaNappi.Enabled = false;
            stopNappi.Enabled = true;
            stopNappi.Visible = true;
            taukoNappi.Enabled = true;
            taukoNappi.Visible = true;
            if (kello1.lasketaankoYlos)
            {
                valiaikaNappi.Enabled = true;
                valiaikaNappi.Visible = true;
            }
        }

        private void stopNappi_Click(object sender, EventArgs e)
        {
            if (!jatkaNappi.Enabled)
            {
                kello1.pysaytetty = 1;
            }

            kello1.Stop();
            stopNappi.Enabled = false;
            stopNappi.Visible = false;
            taukoNappi.Enabled = false;
            taukoNappi.Visible = false;
            jatkaNappi.Enabled = false;
            jatkaNappi.Visible = false;
            aloitaNappi.Enabled = true;
            aloitaNappi.Visible = true;
            valiaikaNappi.Enabled = false;
            valiaikaNappi.Visible = false;
            kello1.aika = kello1.ajastusAika;
            aikaNaytto.Text = kello1.aika;
        }

        private void resettausNappi_Click(object sender, EventArgs e)
        {
            Nollaa();
            kello1.aika = aikaLaatikko1.Text;
            aikaNaytto.Text = aikaLaatikko1.Text;
            if (!kello1.lasketaankoYlos)
            {
                valiaikaNappi.Enabled = false;
                valiaikaNappi.Visible = false;
            }
            if (!aloitaNappi.Enabled && !jatkaNappi.Enabled)
            {
                kello1.Stop();
                kello1.Start();
            }
        }

        /*private List<string> Valiajat()
        {
            //return valiajat
        }*/

        private void paivitaAika()
        {
            kello1.Sekunti += delegate(object sender, EventArgs e)
            {
                if (a > 0)
                {
                    a--;
                }
                else
                {
                    aikaNaytto.Text = kello1.aika;
                }
            };
        }

        private void jatkaNappi_Click(object sender, EventArgs e)
        {
            kello1.aloitettu = 1;
            kello1.Start();
            jatkaNappi.Enabled = false;
            jatkaNappi.Visible = false;
            taukoNappi.Enabled = true;
            taukoNappi.Visible = true;
        }

        private void taukoNappi_Click(object sender, EventArgs e)
        {
            kello1.pysaytetty = 1;
            kello1.Stop();
            taukoNappi.Enabled = false;
            taukoNappi.Visible = false;
            jatkaNappi.Enabled = true;
            jatkaNappi.Visible = true;
        }

        private void Nollaa()
        {
            kello1.aika = "00:00:00";
            aikaNaytto.Text = kello1.aika;
            valiaikoja.Clear();
            valiaikaLaatikko.Items.Clear();
        }

        private List<string> Valiajat()
        {
            kello1.ValiaikaTallennettu += delegate(object sender, EventArgs e)
            {
                a = 1;
                TimeSpan valiaikaBufferi = (TimeSpan)sender;
                valiaikoja.Add(valiaikaBufferi.ToString());
                valiaikaLaatikko.Items.Add(valiaikoja[valiaikoja.Count - 1]);
                aikaNaytto.Text = valiaikaBufferi.ToString();
            };

            return valiaikoja;
        }

        private void valiaikaNappi_Click(object sender, EventArgs e)
        {
            if (!aloitaNappi.Enabled && !jatkaNappi.Enabled)
            {
                kello1.Valiaika();
            }
        }
    }
}
