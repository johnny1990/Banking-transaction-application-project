namespace DomainModelling___Simulator
{
    partial class IstoricTranzactii
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNrCont = new System.Windows.Forms.Label();
            this.txtNrCont = new System.Windows.Forms.TextBox();
            this.dataGridViewIstTr = new System.Windows.Forms.DataGridView();
            this.datatranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiptranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoaretransferataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldinitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldnouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranzactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Domain_Modeling.BankDataSet();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tranzactiiTableAdapter = new Domain_Modeling.BankDataSetTableAdapters.TranzactiiTableAdapter();
            this.btnInchide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstTr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrCont
            // 
            this.lblNrCont.AutoSize = true;
            this.lblNrCont.Location = new System.Drawing.Point(31, 15);
            this.lblNrCont.Name = "lblNrCont";
            this.lblNrCont.Size = new System.Drawing.Size(43, 13);
            this.lblNrCont.TabIndex = 1;
            this.lblNrCont.Text = "Nr Cont";
            // 
            // txtNrCont
            // 
            this.txtNrCont.Location = new System.Drawing.Point(146, 12);
            this.txtNrCont.Name = "txtNrCont";
            this.txtNrCont.Size = new System.Drawing.Size(144, 20);
            this.txtNrCont.TabIndex = 2;
            // 
            // dataGridViewIstTr
            // 
            this.dataGridViewIstTr.AutoGenerateColumns = false;
            this.dataGridViewIstTr.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIstTr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIstTr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIstTr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datatranzactieDataGridViewTextBoxColumn,
            this.tiptranzactieDataGridViewTextBoxColumn,
            this.valoaretransferataDataGridViewTextBoxColumn,
            this.soldinitialDataGridViewTextBoxColumn,
            this.soldnouDataGridViewTextBoxColumn});
            this.dataGridViewIstTr.DataSource = this.tranzactiiBindingSource;
            this.dataGridViewIstTr.GridColor = System.Drawing.Color.White;
            this.dataGridViewIstTr.Location = new System.Drawing.Point(36, 56);
            this.dataGridViewIstTr.Name = "dataGridViewIstTr";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIstTr.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIstTr.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewIstTr.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewIstTr.Size = new System.Drawing.Size(752, 243);
            this.dataGridViewIstTr.TabIndex = 3;
            // 
            // datatranzactieDataGridViewTextBoxColumn
            // 
            this.datatranzactieDataGridViewTextBoxColumn.DataPropertyName = "Data_tranzactie";
            this.datatranzactieDataGridViewTextBoxColumn.HeaderText = "Data_tranzactie";
            this.datatranzactieDataGridViewTextBoxColumn.Name = "datatranzactieDataGridViewTextBoxColumn";
            // 
            // tiptranzactieDataGridViewTextBoxColumn
            // 
            this.tiptranzactieDataGridViewTextBoxColumn.DataPropertyName = "Tip_tranzactie";
            this.tiptranzactieDataGridViewTextBoxColumn.HeaderText = "Tip_tranzactie";
            this.tiptranzactieDataGridViewTextBoxColumn.Name = "tiptranzactieDataGridViewTextBoxColumn";
            // 
            // valoaretransferataDataGridViewTextBoxColumn
            // 
            this.valoaretransferataDataGridViewTextBoxColumn.DataPropertyName = "Valoare_transferata";
            this.valoaretransferataDataGridViewTextBoxColumn.HeaderText = "Valoare_transferata";
            this.valoaretransferataDataGridViewTextBoxColumn.Name = "valoaretransferataDataGridViewTextBoxColumn";
            // 
            // soldinitialDataGridViewTextBoxColumn
            // 
            this.soldinitialDataGridViewTextBoxColumn.DataPropertyName = "Sold_initial";
            this.soldinitialDataGridViewTextBoxColumn.HeaderText = "Sold_initial";
            this.soldinitialDataGridViewTextBoxColumn.Name = "soldinitialDataGridViewTextBoxColumn";
            // 
            // soldnouDataGridViewTextBoxColumn
            // 
            this.soldnouDataGridViewTextBoxColumn.DataPropertyName = "Sold_nou";
            this.soldnouDataGridViewTextBoxColumn.HeaderText = "Sold_nou";
            this.soldnouDataGridViewTextBoxColumn.Name = "soldnouDataGridViewTextBoxColumn";
            // 
            // tranzactiiBindingSource
            // 
            this.tranzactiiBindingSource.DataMember = "Tranzactii";
            this.tranzactiiBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tranzactiiTableAdapter
            // 
            this.tranzactiiTableAdapter.ClearBeforeFill = true;
            // 
            // btnInchide
            // 
            this.btnInchide.Location = new System.Drawing.Point(689, 319);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(75, 23);
            this.btnInchide.TabIndex = 5;
            this.btnInchide.Text = "Inchide";
            this.btnInchide.UseVisualStyleBackColor = true;
            // 
            // IstoricTranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 354);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.dataGridViewIstTr);
            this.Controls.Add(this.txtNrCont);
            this.Controls.Add(this.lblNrCont);
            this.Name = "IstoricTranzactii";
            this.Text = "Istoric tranzactii";
            this.Load += new System.EventHandler(this.IstoricTranzactii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstTr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrCont;
        private System.Windows.Forms.TextBox txtNrCont;
        private System.Windows.Forms.DataGridView dataGridViewIstTr;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Domain_Modeling.BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource tranzactiiBindingSource;
        private Domain_Modeling.BankDataSetTableAdapters.TranzactiiTableAdapter tranzactiiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datatranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiptranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoaretransferataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldinitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldnouDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInchide;
    }
}