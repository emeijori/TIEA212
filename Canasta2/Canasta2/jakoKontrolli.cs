using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Canasta2
{
    public partial class jakoKontrolli : UserControl
    {
        canasta peli;

        public jakoKontrolli(canasta c)
        {
            peli = c;
            InitializeComponent();
            jakoNum = peli.JaonNumero();
            try
            {
                aikasempiyhteensa1 = int.Parse(peli.jakoLista[peli.jakoLista.Count - 1].yhteensaPisteKentta1.Text);
                aikasempiyhteensa2 = int.Parse(peli.jakoLista[peli.jakoLista.Count - 1].yhteensaPisteKentta2.Text);
            }

            catch { }

            jako.Name = "jako" + jakoNum.ToString();
            jako.Text = "Jako " + jakoNum.ToString();
            //aikasempiyhteensa1 = a;
            //aikasempiyhteensa2 = b;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox pisteet = (TextBox)sender;
            bool b = OnkoNumero(pisteet);
            if (b == false)
            {
                return;
            }

            jakoKontrolli voittaja = null;
            bool end = false;
            foreach (jakoKontrolli element in peli.jakoLista)
            {
                end = PisteittenPaivitys(element);
                if (end == true)
                {
                    voittaja = element;
                    break;
                }
            }

            if (end != true)
            {
                SeuraavaJako();
            }
            else
            {
                PoistaJako(voittaja);
            }
        }

        private void PoistaJako(jakoKontrolli jako)
        {
            try
            {
                if (int.Parse(jako.yhteensaPisteKentta2.Text) > 4999 || int.Parse(jako.yhteensaPisteKentta1.Text) > 4999)
                {
                    jako.i = 0;
                    for (int a = peli.jakoLista.Count - 1; a > jakoNum - 1; a--)
                    {
                        jakoKontrolli poistettava = peli.jakoLista[a];
                        poistettava.Dispose();
                    }

                    peli.jakoLista.RemoveRange(jakoNum, peli.jakoLista.Count - 1);
                }
            }

            catch { }

            /*jakoKontrolli poistettava = peli.jakoLista[peli.jakoLista.Count - 1];
            poistettava.Dispose();
            peli.jakoLista.RemoveAt(peli.jakoLista.Count - 1);
            this.i--;*/
        }

        private void SeuraavaJako()
        {
            try
            {
                if (int.Parse(yhteensaPisteKentta1.Text) > 0 + this.aikasempiyhteensa1 && int.Parse(yhteensaPisteKentta2.Text) > 0 + this.aikasempiyhteensa2 && i == 0 &&
                    int.Parse(yhteensaPisteKentta1.Text) < 5000 && int.Parse(yhteensaPisteKentta2.Text) < 5000)
                {
                    this.i++;
                    peli.UusiJako();
                }
            }

            catch { }

        }

        private bool OnkoJaolliset(TextBox pisteet, string tagi, int numero, bool onnistuko)
        {
            switch (tagi)
            {
                case "bonus":
                    {
                        if (numero % 100 == 0 && numero != 0)
                        {
                            pisteet.ForeColor = Color.Black;
                            return onnistuko;
                        }

                        pisteet.ForeColor = Color.Red;
                        return false;
                    }

                case "kortti":
                    {
                        if (numero % 5 == 0 && numero != 0)
                        {
                            pisteet.ForeColor = Color.Black;
                            return onnistuko;
                        }

                        pisteet.ForeColor = Color.Red;
                        return false;
                    }

                default:
                    {
                        pisteet.ForeColor = Color.Red;
                        return false;
                    }
            }
        }

        private bool OnkoNumero(TextBox pisteet)
        {
            int numero;
            try
            {
                numero = int.Parse(pisteet.Text);
                pisteet.ForeColor = Color.Black;
            }

            catch
            {
                pisteet.ForeColor = Color.Red;
                return false;
            }

            string tagi = pisteet.Tag.ToString();
            bool onnistuko = OnkoJaolliset(pisteet, tagi, numero, true);
            return onnistuko;
        }

        private bool PisteittenPaivitys(jakoKontrolli jako)
        {
            try
            {
                jako.aikasempiyhteensa1 = int.Parse(peli.jakoLista[jako.jakoNum - 2].yhteensaPisteKentta1.Text);
                jako.aikasempiyhteensa2 = int.Parse(peli.jakoLista[jako.jakoNum - 2].yhteensaPisteKentta2.Text);
            }
            catch { }

            if (OnkoNumero(jako.bonusPisteKentta1) == true && OnkoNumero(jako.bonusPisteKentta2) == true &&
            OnkoNumero(jako.korttiPisteKentta1) == true && OnkoNumero(jako.korttiPisteKentta2) == true)
            {
                int bonus1 = int.Parse(jako.bonusPisteKentta1.Text);
                int bonus2 = int.Parse(jako.bonusPisteKentta2.Text);
                int kortti1 = int.Parse(jako.korttiPisteKentta1.Text);
                int kortti2 = int.Parse(jako.korttiPisteKentta2.Text);
                int yhteensa1 = bonus1 + kortti1 + jako.aikasempiyhteensa1;
                int yhteensa2 = bonus2 + kortti2 + jako.aikasempiyhteensa2;
                jako.yhteensaPisteKentta1.Text = yhteensa1.ToString();
                jako.yhteensaPisteKentta2.Text = yhteensa2.ToString();
            }

            bool end = VoittikoJoku(jako);
            return end;
        }

        private bool VoittikoJoku(jakoKontrolli jako)
        {
            bool end = false;
            try
            {
                if (int.Parse(jako.yhteensaPisteKentta1.Text) > 4999)
                {
                    jako.yhteensaPisteKentta1.BackColor = Color.Cyan;
                    end = true;
                }

                else
                {
                    jako.yhteensaPisteKentta1.BackColor = default(Color);
                }

                if (int.Parse(jako.yhteensaPisteKentta2.Text) > 4999)
                {
                    jako.yhteensaPisteKentta2.BackColor = Color.Cyan;
                    end = true;
                }

                else
                {
                    jako.yhteensaPisteKentta2.BackColor = default(Color);
                }
            }

            catch {return end;}
            return end;
        }

        public string AnnaPisteet()
        {
            return jako.Text + Environment.NewLine + "\t" + bonusPisteKentta1.Text + " : " + bonusPisteKentta2.Text + Environment.NewLine
                + "\t" + korttiPisteKentta1.Text + " : " + korttiPisteKentta2.Text + Environment.NewLine + "\t" + yhteensaPisteKentta1.Text + " : " + yhteensaPisteKentta2.Text;
        }

        int aikasempiyhteensa1;
        int aikasempiyhteensa2;
        int i = 0;
        int jakoNum;
    }
}
