namespace DomainModelling___Simulator
{
    partial class NumeCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumeCont));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNrCont = new System.Windows.Forms.TextBox();
            this.btnDeschide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr cont";
            // 
            // txtNrCont
            // 
            this.txtNrCont.Location = new System.Drawing.Point(125, 20);
            this.txtNrCont.Name = "txtNrCont";
            this.txtNrCont.Size = new System.Drawing.Size(184, 20);
            this.txtNrCont.TabIndex = 1;
            this.txtNrCont.Leave += new System.EventHandler(this.txtNrCont_Leave);
            // 
            // btnDeschide
            // 
            this.btnDeschide.Location = new System.Drawing.Point(234, 61);
            this.btnDeschide.Name = "btnDeschide";
            this.btnDeschide.Size = new System.Drawing.Size(75, 23);
            this.btnDeschide.TabIndex = 2;
            this.btnDeschide.Text = "Deschide";
            this.btnDeschide.UseVisualStyleBackColor = true;
            this.btnDeschide.Click += new System.EventHandler(this.btnDeschide_Click);
            // 
            // NumeCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 96);
            this.Controls.Add(this.btnDeschide);
            this.Controls.Add(this.txtNrCont);
            this.Controls.Add(this.label1);           
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumeCont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeschide;
        private System.Windows.Forms.TextBox txtNrCont;
    }
}