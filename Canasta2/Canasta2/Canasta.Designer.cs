using System.Collections.Generic;
namespace Canasta2
{
    partial class canasta
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
            this.tausta = new System.Windows.Forms.FlowLayoutPanel();
            this.pelaajatTausta = new System.Windows.Forms.FlowLayoutPanel();
            this.puolueLaatikko1 = new System.Windows.Forms.GroupBox();
            this.pelaajaNimiKentta2 = new System.Windows.Forms.TextBox();
            this.pelaajaNimiKentta1 = new System.Windows.Forms.TextBox();
            this.pelaajaLabel1 = new System.Windows.Forms.Label();
            this.pelaajaLabel2 = new System.Windows.Forms.Label();
            this.puolueLaatikko2 = new System.Windows.Forms.GroupBox();
            this.pelaajaLabel4 = new System.Windows.Forms.Label();
            this.pelaajaLabel3 = new System.Windows.Forms.Label();
            this.pelaajaNimiKentta4 = new System.Windows.Forms.TextBox();
            this.pelaajaNimiKentta3 = new System.Windows.Forms.TextBox();
            this.aloitaNappi = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tausta.SuspendLayout();
            this.pelaajatTausta.SuspendLayout();
            this.puolueLaatikko1.SuspendLayout();
            this.puolueLaatikko2.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tausta
            // 
            this.tausta.AutoScroll = true;
            this.tausta.Controls.Add(this.pelaajatTausta);
            this.tausta.Controls.Add(this.aloitaNappi);
            this.tausta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tausta.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tausta.Location = new System.Drawing.Point(0, 24);
            this.tausta.Name = "tausta";
            this.tausta.Size = new System.Drawing.Size(1047, 563);
            this.tausta.TabIndex = 1;
            // 
            // pelaajatTausta
            // 
            this.pelaajatTausta.AutoSize = true;
            this.pelaajatTausta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pelaajatTausta.Controls.Add(this.puolueLaatikko1);
            this.pelaajatTausta.Controls.Add(this.puolueLaatikko2);
            this.pelaajatTausta.Location = new System.Drawing.Point(3, 3);
            this.pelaajatTausta.Name = "pelaajatTausta";
            this.pelaajatTausta.Size = new System.Drawing.Size(238, 115);
            this.pelaajatTausta.TabIndex = 1;
            // 
            // puolueLaatikko1
            // 
            this.puolueLaatikko1.AutoSize = true;
            this.puolueLaatikko1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.puolueLaatikko1.Controls.Add(this.pelaajaNimiKentta2);
            this.puolueLaatikko1.Controls.Add(this.pelaajaNimiKentta1);
            this.puolueLaatikko1.Controls.Add(this.pelaajaLabel1);
            this.puolueLaatikko1.Controls.Add(this.pelaajaLabel2);
            this.puolueLaatikko1.Location = new System.Drawing.Point(0, 0);
            this.puolueLaatikko1.Margin = new System.Windows.Forms.Padding(0);
            this.puolueLaatikko1.Name = "puolueLaatikko1";
            this.puolueLaatikko1.Size = new System.Drawing.Size(119, 115);
            this.puolueLaatikko1.TabIndex = 0;
            this.puolueLaatikko1.TabStop = false;
            this.puolueLaatikko1.Text = "Puolue 1";
            // 
            // pelaajaNimiKentta2
            // 
            this.pelaajaNimiKentta2.Location = new System.Drawing.Point(13, 76);
            this.pelaajaNimiKentta2.Name = "pelaajaNimiKentta2";
            this.pelaajaNimiKentta2.Size = new System.Drawing.Size(100, 20);
            this.pelaajaNimiKentta2.TabIndex = 4;
            // 
            // pelaajaNimiKentta1
            // 
            this.pelaajaNimiKentta1.Location = new System.Drawing.Point(13, 37);
            this.pelaajaNimiKentta1.Name = "pelaajaNimiKentta1";
            this.pelaajaNimiKentta1.Size = new System.Drawing.Size(100, 20);
            this.pelaajaNimiKentta1.TabIndex = 1;
            // 
            // pelaajaLabel1
            // 
            this.pelaajaLabel1.AutoSize = true;
            this.pelaajaLabel1.Location = new System.Drawing.Point(10, 20);
            this.pelaajaLabel1.Name = "pelaajaLabel1";
            this.pelaajaLabel1.Size = new System.Drawing.Size(51, 13);
            this.pelaajaLabel1.TabIndex = 0;
            this.pelaajaLabel1.Text = "Pelaaja 1";
            // 
            // pelaajaLabel2
            // 
            this.pelaajaLabel2.AutoSize = true;
            this.pelaajaLabel2.Location = new System.Drawing.Point(10, 60);
            this.pelaajaLabel2.Name = "pelaajaLabel2";
            this.pelaajaLabel2.Size = new System.Drawing.Size(51, 13);
            this.pelaajaLabel2.TabIndex = 3;
            this.pelaajaLabel2.Text = "Pelaaja 2";
            // 
            // puolueLaatikko2
            // 
            this.puolueLaatikko2.AutoSize = true;
            this.puolueLaatikko2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.puolueLaatikko2.Controls.Add(this.pelaajaLabel4);
            this.puolueLaatikko2.Controls.Add(this.pelaajaLabel3);
            this.puolueLaatikko2.Controls.Add(this.pelaajaNimiKentta4);
            this.puolueLaatikko2.Controls.Add(this.pelaajaNimiKentta3);
            this.puolueLaatikko2.Location = new System.Drawing.Point(119, 0);
            this.puolueLaatikko2.Margin = new System.Windows.Forms.Padding(0);
            this.puolueLaatikko2.Name = "puolueLaatikko2";
            this.puolueLaatikko2.Size = new System.Drawing.Size(119, 115);
            this.puolueLaatikko2.TabIndex = 1;
            this.puolueLaatikko2.TabStop = false;
            this.puolueLaatikko2.Text = "Puolue 2";
            // 
            // pelaajaLabel4
            // 
            this.pelaajaLabel4.AutoSize = true;
            this.pelaajaLabel4.Location = new System.Drawing.Point(10, 60);
            this.pelaajaLabel4.Name = "pelaajaLabel4";
            this.pelaajaLabel4.Size = new System.Drawing.Size(51, 13);
            this.pelaajaLabel4.TabIndex = 2;
            this.pelaajaLabel4.Text = "Pelaaja 4";
            // 
            // pelaajaLabel3
            // 
            this.pelaajaLabel3.AutoSize = true;
            this.pelaajaLabel3.Location = new System.Drawing.Point(10, 20);
            this.pelaajaLabel3.Name = "pelaajaLabel3";
            this.pelaajaLabel3.Size = new System.Drawing.Size(51, 13);
            this.pelaajaLabel3.TabIndex = 0;
            this.pelaajaLabel3.Text = "Pelaaja 3";
            // 
            // pelaajaNimiKentta4
            // 
            this.pelaajaNimiKentta4.Location = new System.Drawing.Point(13, 76);
            this.pelaajaNimiKentta4.Name = "pelaajaNimiKentta4";
            this.pelaajaNimiKentta4.Size = new System.Drawing.Size(100, 20);
            this.pelaajaNimiKentta4.TabIndex = 3;
            // 
            // pelaajaNimiKentta3
            // 
            this.pelaajaNimiKentta3.Location = new System.Drawing.Point(13, 37);
            this.pelaajaNimiKentta3.Name = "pelaajaNimiKentta3";
            this.pelaajaNimiKentta3.Size = new System.Drawing.Size(100, 20);
            this.pelaajaNimiKentta3.TabIndex = 1;
            // 
            // aloitaNappi
            // 
            this.aloitaNappi.Location = new System.Drawing.Point(3, 124);
            this.aloitaNappi.Name = "aloitaNappi";
            this.aloitaNappi.Size = new System.Drawing.Size(75, 23);
            this.aloitaNappi.TabIndex = 2;
            this.aloitaNappi.Text = "Aloita";
            this.aloitaNappi.UseVisualStyleBackColor = true;
            this.aloitaNappi.Click += new System.EventHandler(this.aloitaNappi_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1047, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // canasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 587);
            this.Controls.Add(this.tausta);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "canasta";
            this.Text = "Canasta";
            this.tausta.ResumeLayout(false);
            this.tausta.PerformLayout();
            this.pelaajatTausta.ResumeLayout(false);
            this.pelaajatTausta.PerformLayout();
            this.puolueLaatikko1.ResumeLayout(false);
            this.puolueLaatikko1.PerformLayout();
            this.puolueLaatikko2.ResumeLayout(false);
            this.puolueLaatikko2.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel tausta;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel pelaajatTausta;
        private System.Windows.Forms.GroupBox puolueLaatikko1;
        private System.Windows.Forms.TextBox pelaajaNimiKentta2;
        private System.Windows.Forms.TextBox pelaajaNimiKentta1;
        private System.Windows.Forms.Label pelaajaLabel1;
        private System.Windows.Forms.GroupBox puolueLaatikko2;
        private System.Windows.Forms.TextBox pelaajaNimiKentta4;
        private System.Windows.Forms.TextBox pelaajaNimiKentta3;
        private System.Windows.Forms.Button aloitaNappi;
        private System.Windows.Forms.Label pelaajaLabel2;
        private System.Windows.Forms.Label pelaajaLabel4;
        private System.Windows.Forms.Label pelaajaLabel3;
        public List<jakoKontrolli> jakoLista;
    }
}

