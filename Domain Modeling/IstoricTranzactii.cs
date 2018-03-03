using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DomainModelling___Simulator
{
    public partial class IstoricTranzactii : Form
    {
        NumeCont IntroduceNrCont = new NumeCont();

        public IstoricTranzactii()
        {
            InitializeComponent();
        }

        SqlConnection con;
        DataTable dt;
        DataRow[] returnedRows;
        SqlDataAdapter da;

        private void IstoricTranzactii_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            dt = new DataTable();

            con.ConnectionString = "Data source=MAN;Initial Catalog=Bank;Integrated Security=True";          
            string sql = "SELECT * From Tranzactii";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            AfiseazaIstoric();         
            this.ActiveControl = btnInchide;
        }

        private void AfiseazaIstoric()
        {
            txtNrCont.Text = tbText.Text;
            returnedRows = dt.Select("Nr_cont='" + tbText.Text + "'");
            int result = returnedRows.Length;
            if (result > 0)
            {
                DataTable dt1 = returnedRows.CopyToDataTable();
                IntroduceNrCont.Close();
                dataGridViewIstTr.DataSource = dt1;
                dataGridViewIstTr.ClearSelection();
                this.ActiveControl = btnInchide;
                MakeReadOnly(txtNrCont);

            }
            else
            {
                this.Close();
                MessageBox.Show("Informatia nu a fost gasita!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IntroduceNrCont.Text = "Introduce numarul contului pentru a vizualiza tranzactiile";
                IntroduceNrCont.Show();
                txtNrCont.Focus();
            }
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TextBox tbText
        {
            get
            {
                return txtNrCont;
            }
        }

        void MakeReadOnly(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls != null && c.Controls.Count > 0)
                {
                    MakeReadOnly(c);
                }
                else if (c is TextBox)
                {
                    (c as TextBox).ReadOnly = true;
                }
            }
        }

        

        
    }
}
