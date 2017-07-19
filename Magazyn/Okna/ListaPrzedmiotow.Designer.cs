namespace Magazyn
{
    partial class ListaPrzedmiotow
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
            this.listBoxPrzedmioty = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.przedmiotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPrzedmioty
            // 
            this.listBoxPrzedmioty.FormattingEnabled = true;
            this.listBoxPrzedmioty.Location = new System.Drawing.Point(12, 51);
            this.listBoxPrzedmioty.Name = "listBoxPrzedmioty";
            this.listBoxPrzedmioty.Size = new System.Drawing.Size(433, 563);
            this.listBoxPrzedmioty.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przedmiotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // przedmiotToolStripMenuItem
            // 
            this.przedmiotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.przedmiotToolStripMenuItem.Name = "przedmiotToolStripMenuItem";
            this.przedmiotToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.przedmiotToolStripMenuItem.Text = "Przedmiot";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // ListaPrzedmiotow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 627);
            this.Controls.Add(this.listBoxPrzedmioty);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaPrzedmiotow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListaPrzedmiotow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxPrzedmioty;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem przedmiotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
    }
}