namespace Ajastin
{
    partial class aikaLaatikko
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ajanAsetusLaatikko = new System.Windows.Forms.TextBox();
            this.virheenTarjoaja = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.virheenTarjoaja)).BeginInit();
            this.SuspendLayout();
            // 
            // ajanAsetusLaatikko
            // 
            this.ajanAsetusLaatikko.Location = new System.Drawing.Point(0, 0);
            this.ajanAsetusLaatikko.Name = "ajanAsetusLaatikko";
            this.ajanAsetusLaatikko.Size = new System.Drawing.Size(100, 20);
            this.ajanAsetusLaatikko.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this.virheenTarjoaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ajanAsetusLaatikko;
        private System.Windows.Forms.ErrorProvider virheenTarjoaja;
    }
}
