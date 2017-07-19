namespace Magazyn
{
    partial class DodawaniePrzedmiotu
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
            this.etykietaNazwa = new System.Windows.Forms.Label();
            this.poleTekstoweNazwa = new System.Windows.Forms.TextBox();
            this.przyciskDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etykietaNazwa
            // 
            this.etykietaNazwa.AutoSize = true;
            this.etykietaNazwa.Location = new System.Drawing.Point(29, 13);
            this.etykietaNazwa.Name = "etykietaNazwa";
            this.etykietaNazwa.Size = new System.Drawing.Size(85, 13);
            this.etykietaNazwa.TabIndex = 0;
            this.etykietaNazwa.Text = "Nazwa produktu";
            // 
            // poleTekstoweNazwa
            // 
            this.poleTekstoweNazwa.Location = new System.Drawing.Point(12, 29);
            this.poleTekstoweNazwa.Name = "poleTekstoweNazwa";
            this.poleTekstoweNazwa.Size = new System.Drawing.Size(111, 20);
            this.poleTekstoweNazwa.TabIndex = 1;
            // 
            // przyciskDodaj
            // 
            this.przyciskDodaj.Location = new System.Drawing.Point(118, 145);
            this.przyciskDodaj.Name = "przyciskDodaj";
            this.przyciskDodaj.Size = new System.Drawing.Size(104, 23);
            this.przyciskDodaj.TabIndex = 2;
            this.przyciskDodaj.Text = "Dodaj produkt";
            this.przyciskDodaj.UseVisualStyleBackColor = true;
            this.przyciskDodaj.Click += new System.EventHandler(this.przyciskDodaj_Click);
            // 
            // DodawaniePrzedmiotu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 275);
            this.Controls.Add(this.przyciskDodaj);
            this.Controls.Add(this.poleTekstoweNazwa);
            this.Controls.Add(this.etykietaNazwa);
            this.Location = new System.Drawing.Point(650, 10);
            this.Name = "DodawaniePrzedmiotu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DodawaniePrzedmiotu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etykietaNazwa;
        private System.Windows.Forms.TextBox poleTekstoweNazwa;
        private System.Windows.Forms.Button przyciskDodaj;
    }
}