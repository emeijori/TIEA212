namespace Ajastin
{
    partial class keittioAjastin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.aikaNaytto = new System.Windows.Forms.Label();
            this.aloitaNappi = new System.Windows.Forms.Button();
            this.resettausNappi = new System.Windows.Forms.Button();
            this.stopNappi = new System.Windows.Forms.Button();
            this.jatkaNappi = new System.Windows.Forms.Button();
            this.taukoNappi = new System.Windows.Forms.Button();
            this.valiaikaNappi = new System.Windows.Forms.Button();
            this.aikaLaatikko1 = new Ajastin.aikaLaatikko(this.components);
            this.kello1 = new Ajastin.Kello(this.components);
            this.valiaikaLaatikko = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // aikaNaytto
            // 
            this.aikaNaytto.AutoSize = true;
            this.aikaNaytto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaNaytto.Location = new System.Drawing.Point(12, 9);
            this.aikaNaytto.Name = "aikaNaytto";
            this.aikaNaytto.Size = new System.Drawing.Size(151, 39);
            this.aikaNaytto.TabIndex = 0;
            this.aikaNaytto.Text = "00:00:00";
            // 
            // aloitaNappi
            // 
            this.aloitaNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aloitaNappi.Location = new System.Drawing.Point(19, 51);
            this.aloitaNappi.Name = "aloitaNappi";
            this.aloitaNappi.Size = new System.Drawing.Size(100, 46);
            this.aloitaNappi.TabIndex = 1;
            this.aloitaNappi.Text = "Start";
            this.aloitaNappi.UseVisualStyleBackColor = true;
            this.aloitaNappi.Click += new System.EventHandler(this.aloitaNappi_Click);
            // 
            // resettausNappi
            // 
            this.resettausNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resettausNappi.Location = new System.Drawing.Point(19, 138);
            this.resettausNappi.Name = "resettausNappi";
            this.resettausNappi.Size = new System.Drawing.Size(100, 46);
            this.resettausNappi.TabIndex = 3;
            this.resettausNappi.Text = "Reset";
            this.resettausNappi.UseVisualStyleBackColor = true;
            this.resettausNappi.Click += new System.EventHandler(this.resettausNappi_Click);
            // 
            // stopNappi
            // 
            this.stopNappi.Enabled = false;
            this.stopNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopNappi.Location = new System.Drawing.Point(19, 51);
            this.stopNappi.Name = "stopNappi";
            this.stopNappi.Size = new System.Drawing.Size(100, 46);
            this.stopNappi.TabIndex = 5;
            this.stopNappi.Text = "Stop";
            this.stopNappi.UseVisualStyleBackColor = true;
            this.stopNappi.Visible = false;
            this.stopNappi.Click += new System.EventHandler(this.stopNappi_Click);
            // 
            // jatkaNappi
            // 
            this.jatkaNappi.Enabled = false;
            this.jatkaNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jatkaNappi.Location = new System.Drawing.Point(125, 51);
            this.jatkaNappi.Name = "jatkaNappi";
            this.jatkaNappi.Size = new System.Drawing.Size(100, 46);
            this.jatkaNappi.TabIndex = 6;
            this.jatkaNappi.Text = "Jatka";
            this.jatkaNappi.UseVisualStyleBackColor = true;
            this.jatkaNappi.Visible = false;
            this.jatkaNappi.Click += new System.EventHandler(this.jatkaNappi_Click);
            // 
            // taukoNappi
            // 
            this.taukoNappi.Enabled = false;
            this.taukoNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taukoNappi.Location = new System.Drawing.Point(125, 51);
            this.taukoNappi.Name = "taukoNappi";
            this.taukoNappi.Size = new System.Drawing.Size(100, 46);
            this.taukoNappi.TabIndex = 7;
            this.taukoNappi.Text = "Tauko";
            this.taukoNappi.UseVisualStyleBackColor = true;
            this.taukoNappi.Visible = false;
            this.taukoNappi.Click += new System.EventHandler(this.taukoNappi_Click);
            // 
            // valiaikaNappi
            // 
            this.valiaikaNappi.Enabled = false;
            this.valiaikaNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valiaikaNappi.Location = new System.Drawing.Point(125, 138);
            this.valiaikaNappi.Name = "valiaikaNappi";
            this.valiaikaNappi.Size = new System.Drawing.Size(100, 46);
            this.valiaikaNappi.TabIndex = 8;
            this.valiaikaNappi.Text = "Väliaika";
            this.valiaikaNappi.UseVisualStyleBackColor = true;
            this.valiaikaNappi.Visible = false;
            this.valiaikaNappi.Click += new System.EventHandler(this.valiaikaNappi_Click);
            // 
            // aikaLaatikko1
            // 
            this.aikaLaatikko1.Location = new System.Drawing.Point(19, 103);
            this.aikaLaatikko1.Name = "aikaLaatikko1";
            this.aikaLaatikko1.Size = new System.Drawing.Size(100, 20);
            this.aikaLaatikko1.TabIndex = 4;
            this.aikaLaatikko1.Text = "00:00:00";
            // 
            // kello1
            // 
            this.kello1.aika = "00:00:00";
            this.kello1.ajastusAika = "00:00:00";
            this.kello1.aloitettu = 0;
            this.kello1.Interval = 1000;
            this.kello1.lasketaankoYlos = true;
            this.kello1.pysaytetty = 0;
            // 
            // valiaikaLaatikko
            // 
            this.valiaikaLaatikko.FormattingEnabled = true;
            this.valiaikaLaatikko.Location = new System.Drawing.Point(19, 190);
            this.valiaikaLaatikko.Name = "valiaikaLaatikko";
            this.valiaikaLaatikko.Size = new System.Drawing.Size(206, 277);
            this.valiaikaLaatikko.TabIndex = 9;
            // 
            // keittioAjastin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 488);
            this.Controls.Add(this.valiaikaLaatikko);
            this.Controls.Add(this.valiaikaNappi);
            this.Controls.Add(this.taukoNappi);
            this.Controls.Add(this.jatkaNappi);
            this.Controls.Add(this.stopNappi);
            this.Controls.Add(this.aikaLaatikko1);
            this.Controls.Add(this.resettausNappi);
            this.Controls.Add(this.aloitaNappi);
            this.Controls.Add(this.aikaNaytto);
            this.Name = "keittioAjastin";
            this.Text = "Ajastin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Suljetaan);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private aikaLaatikko aikaLaatikko1;
        private Kello kello1;
        private System.Windows.Forms.Label aikaNaytto;
        private System.Windows.Forms.Button aloitaNappi;
        private System.Windows.Forms.Button resettausNappi;
        private System.Windows.Forms.Button stopNappi;
        private System.Windows.Forms.Button jatkaNappi;
        private System.Windows.Forms.Button taukoNappi;
        private System.Windows.Forms.Button valiaikaNappi;
        private System.Windows.Forms.ListBox valiaikaLaatikko;
    }
}

