using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ajastin
{
    public partial class Kello : Timer
    {
        private TimeSpan aikaJana;
        private TimeSpan alkuperainenAika;
        private bool lasketaanYlos;
        private int pysaytysKerrat;
        private int aloitusKerrat;
        private DateTime vanhaTimingOver;
        private DateTime vanhaIdleOver;

        public event EventHandler Sekunti;
        public event EventHandler Halytys;
        public event EventHandler ValiaikaTallennettu;
        public event EventHandler TimingOver;
        public event EventHandler IdleOver;

        public Kello()
        {
            InitializeComponent();
            Sekunnit();
            Start();
            Stop();
        }

        public Kello(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Sekunnit();
            Start();
            Stop();
        }

        public bool lasketaankoYlos
        {
            get
            {
                return lasketaanYlos;
            }
            set
            {
                lasketaanYlos = value;
            }
        }

        public string aikaaKulunut
        {
            get
            {
                TimeSpan bufferi = alkuperainenAika.Subtract(aikaJana);
                return string.Format("{0:00}:{1:00}:{2:00}", (int)bufferi.Hours, bufferi.Minutes, bufferi.Seconds);
            }
        }

        public string aika
        {
            get
            {
                return string.Format("{0:00}:{1:00}:{2:00}", (int)aikaJana.Hours, aikaJana.Minutes, aikaJana.Seconds);
            }
            set
            {
                ajastusAika = value;
                aikaJana = alkuperainenAika;
            }
        }

        public string ajastusAika
        {
            get
            {
                return string.Format("{0:00}:{1:00}:{2:00}", alkuperainenAika.Hours, alkuperainenAika.Minutes, alkuperainenAika.Seconds);
            }
            set
            {
                string[] taulukko = value.Split(':');
                alkuperainenAika = new TimeSpan(int.Parse(taulukko[0]), int.Parse(taulukko[1]), int.Parse(taulukko[2]));

                if (0 == alkuperainenAika.CompareTo(new TimeSpan(0, 0, 0)))
                {
                    lasketaankoYlos = true;
                }

                else lasketaankoYlos = false;
            }
        }

        public int pysaytetty
        {
            get
            {
                return pysaytysKerrat;
            }
            set
            {
                pysaytysKerrat += value;
            }
        }

        public int aloitettu
        {
            get
            {
                return aloitusKerrat;
            }
            set
            {
                aloitusKerrat += value;
            }
        }

        public void Valiaika()
        {
            TimeSpan valiaika = aikaJana;
            ValiaikaTallennettu(valiaika, new EventArgs());
        }

        public new void Stop()
        {
            TimeSpan ajastusBufferi;
            ajastusBufferi = DateTime.Now - vanhaTimingOver;

            if (TimingOver != null)
            {
                TimingOver(ajastusBufferi, new EventArgs());
            }

            vanhaTimingOver = DateTime.Now;
            base.Stop();
        }

        public new void Start()
        {
            TimeSpan taukoBufferi;
            taukoBufferi = DateTime.Now - vanhaIdleOver;

            if (IdleOver != null)
            {
                IdleOver(taukoBufferi, new EventArgs());
            }

            vanhaIdleOver = DateTime.Now;
            base.Start();

        }

        private void Restart()
        {
            aloitettu = 0;
            pysaytetty = 0;
        }

        private void Sekunnit()
        {
            this.Tick += delegate
            {
                if (!lasketaanYlos)
                {
                    if (0 < aikaJana.CompareTo(new TimeSpan(0, 0, 0)))
                    {
                        aikaJana += new TimeSpan(0, 0, -1);
                        Sekunti(this, new EventArgs());
                    }
                    else
                    {
                        Halytys(this, new EventArgs());
                    }
                }

                else
                {
                    aikaJana += new TimeSpan(0, 0, 1);
                    Sekunti(this, new EventArgs());
                }
            };
        }
    }
}
