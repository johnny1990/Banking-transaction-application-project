namespace DomainModelling___Simulator
{
    partial class Acasa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuConturi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNou = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeschide = new System.Windows.Forms.ToolStripMenuItem();
            this.AfiseazaInformatiiPersonalerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIstoricTranzactii = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipTranzactii = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepunere = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRetragere = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.despreAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConturi,
            this.mnuTipTranzactii,
            this.despreAplicatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuConturi
            // 
            this.mnuConturi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNou,
            this.mnuDeschide,
            this.mnuIesire});
            this.mnuConturi.Name = "mnuConturi";
            this.mnuConturi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mnuConturi.Size = new System.Drawing.Size(69, 24);
            this.mnuConturi.Text = "&Conturi";
            // 
            // mnuNou
            // 
            this.mnuNou.Name = "mnuNou";
            this.mnuNou.Size = new System.Drawing.Size(191, 26);
            this.mnuNou.Text = "Creaza &cont nou";
            this.mnuNou.Click += new System.EventHandler(this.mnuNou_Click);
            // 
            // mnuDeschide
            // 
            this.mnuDeschide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AfiseazaInformatiiPersonalerToolStripMenuItem,
            this.mnuIstoricTranzactii});
            this.mnuDeschide.Name = "mnuDeschide";
            this.mnuDeschide.Size = new System.Drawing.Size(191, 26);
            this.mnuDeschide.Text = "Deschide cont ";
            // 
            // AfiseazaInformatiiPersonalerToolStripMenuItem
            // 
            this.AfiseazaInformatiiPersonalerToolStripMenuItem.Name = "AfiseazaInformatiiPersonalerToolStripMenuItem";
            this.AfiseazaInformatiiPersonalerToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.AfiseazaInformatiiPersonalerToolStripMenuItem.Text = "&Informatii personale";
            this.AfiseazaInformatiiPersonalerToolStripMenuItem.Click += new System.EventHandler(this.AfiseazaInformatiiPersonaleToolStripMenuItem_Click);
            // 
            // mnuIstoricTranzactii
            // 
            this.mnuIstoricTranzactii.Name = "mnuIstoricTranzactii";
            this.mnuIstoricTranzactii.Size = new System.Drawing.Size(218, 26);
            this.mnuIstoricTranzactii.Text = "Istoric &Tranzactii";
            this.mnuIstoricTranzactii.Click += new System.EventHandler(this.mnuIstoricTranzactii_Click);
            // 
            // mnuIesire
            // 
            this.mnuIesire.Name = "mnuIesire";
            this.mnuIesire.Size = new System.Drawing.Size(191, 26);
            this.mnuIesire.Text = "&Iesire";
            this.mnuIesire.Click += new System.EventHandler(this.mnuIesire_Click);
            // 
            // mnuTipTranzactii
            // 
            this.mnuTipTranzactii.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDepunere,
            this.mnuRetragere});
            this.mnuTipTranzactii.Name = "mnuTipTranzactii";
            this.mnuTipTranzactii.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.mnuTipTranzactii.Size = new System.Drawing.Size(109, 24);
            this.mnuTipTranzactii.Text = "Tip &Tranzactii";
            // 
            // mnuDepunere
            // 
            this.mnuDepunere.Name = "mnuDepunere";
            this.mnuDepunere.Size = new System.Drawing.Size(181, 26);
            this.mnuDepunere.Text = "&Depunere";
            this.mnuDepunere.Click += new System.EventHandler(this.mnuDepunere_Click);
            // 
            // mnuRetragere
            // 
            this.mnuRetragere.Name = "mnuRetragere";
            this.mnuRetragere.Size = new System.Drawing.Size(181, 26);
            this.mnuRetragere.Text = "&Retragere";
            this.mnuRetragere.Click += new System.EventHandler(this.mnuRetragere_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(67, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(67, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(67, 4);
            // 
            // despreAplicatieToolStripMenuItem
            // 
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.despreAplicatieToolStripMenuItem.Text = "Despre aplicatie";
            // 
            // Acasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Acasa";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domain Modelling Bank";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuConturi;
        private System.Windows.Forms.ToolStripMenuItem mnuNou;
        private System.Windows.Forms.ToolStripMenuItem mnuDeschide;
        private System.Windows.Forms.ToolStripMenuItem mnuIesire;
        private System.Windows.Forms.ToolStripMenuItem mnuTipTranzactii;
        private System.Windows.Forms.ToolStripMenuItem mnuDepunere;
        private System.Windows.Forms.ToolStripMenuItem mnuRetragere;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem AfiseazaInformatiiPersonalerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuIstoricTranzactii;
        private System.Windows.Forms.ToolStripMenuItem despreAplicatieToolStripMenuItem;
    }
}

