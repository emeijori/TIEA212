using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Ajastin
{
    public partial class aikaLaatikko : TextBox
    {
        public event EventHandler OK;
        public event EventHandler Virhe;


        public aikaLaatikko()
        {
            InitializeComponent();
        }

        public aikaLaatikko(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Validointi();
        }

        private void Validointi()
        {
            this.Validating += delegate(object sender, System.ComponentModel.CancelEventArgs e)
            {
                TextBox laatikko = (TextBox)sender;
                string formaatti = "^(([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9])$|^24:00:00$";
                if (laatikko != null)
                {
                    if (!Regex.IsMatch(laatikko.Text, formaatti, RegexOptions.CultureInvariant))
                    {
                        virheenTarjoaja.SetError(laatikko, "Syöta aika muodossa; HH:MM:SS");
                        laatikko.BackColor = Color.Red;
                        e.Cancel = true;
                        if (Virhe != null)
                        {
                            Virhe(this, new EventArgs());
                        }
                    }
                }
            };

            this.Validated += delegate(object sender, System.EventArgs e)
            {
                TextBox laatikko = (TextBox)sender;
                virheenTarjoaja.SetError(laatikko, string.Empty);
                laatikko.BackColor = Color.White;
                if (OK != null)
                {
                    OK(this, new EventArgs());
                }
            };
        }
    }
}
