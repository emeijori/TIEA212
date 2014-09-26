using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Canasta2
{
    public partial class canasta : Form
    {
        public canasta()
        {
            this.jakoLista = new List<jakoKontrolli>();
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void aloitaNappi_Click(object sender, EventArgs e)
        {
            if ( jakoLista.Count > 0)
            {
                return;
            }

            bool nimet = false;
            nimet = tarkistaOnkoPelaajillaNimet();

            if (nimet == true)
            {
                UusiJako();
            }
            else return;
        }

        public int JaonNumero()
        {
            return jakoLista.Count + 1;
        }

        public void  UusiJako()
        {
            jakoLista.Add(new jakoKontrolli(this));
            tausta.Controls.Add(jakoLista[jakoLista.Count - 1]);
        }

        private bool tarkistaOnkoPelaajillaNimet()
        {
            TextBox[] taulukko = new TextBox[]{pelaajaNimiKentta1, pelaajaNimiKentta2, pelaajaNimiKentta3, pelaajaNimiKentta4};

            foreach (TextBox t in taulukko)
            {
                if (t.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream striimini;
            SaveFileDialog tallennaDialogi = new SaveFileDialog();

            tallennaDialogi.Filter = "tekstitiedosto(*.txt)|*.txt";
            tallennaDialogi.FilterIndex = 2;
            tallennaDialogi.RestoreDirectory = true;

            if (tallennaDialogi.ShowDialog() == DialogResult.OK)
            {
                if ((striimini = tallennaDialogi.OpenFile()) != null)
                {
                    string tallennettavat = puolueLaatikko1.Text + ":" + Environment.NewLine + "\t" + pelaajaNimiKentta1.Text + " ja " + pelaajaNimiKentta2.Text
                        + Environment.NewLine + puolueLaatikko2.Text + ":" + Environment.NewLine + "\t" + pelaajaNimiKentta3.Text + " ja " + pelaajaNimiKentta4.Text;
                    foreach (var element in jakoLista)
                    {
                        tallennettavat += Environment.NewLine + element.AnnaPisteet();
                    }
                    byte[] tallennus = System.Text.Encoding.UTF8.GetBytes(tallennettavat);
                    striimini.Write(tallennus, 0 , tallennus.Length);
                    striimini.Close();
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About tietoja = new About();
            tietoja.Visible = true;
        }
    }
}
