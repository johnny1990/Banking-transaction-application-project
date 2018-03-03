using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DomainModelling___Simulator
{
    public partial class ContNou : Form
    {
        public ContNou()
        {
            InitializeComponent();
        }

        int MaxRows = 0;
        int LastRecord;

        SqlConnection con;    
        DataSet ds1;                                       
        DataTable dt;
        SqlDataAdapter da, da1;         

        private void ContNou_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection();
            ds1 = new DataSet();   
            dt = new DataTable("Conturi");
            con.ConnectionString = @"Data source=MAN;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
           
            string sql = "SELECT * From Conturi";
            string sql1 = "SELECT * From Tranzactii";

            da = new SqlDataAdapter(sql, con);
            da1 = new SqlDataAdapter(sql1, con);
              
            da.Fill(ds1, "Conturi");
            da1.Fill(ds1, "Tranzactii");

            InitializeBoxes();
            
            MaxRows = ds1.Tables["Conturi"].Rows.Count;
            txtId.Text = (MaxRows + 1).ToString();                        
                 
            if (MaxRows == 0)
            {
                LastRecord = 0;
            }
            else
            {
                LastRecord = (int)ds1.Tables["Conturi"].Rows[0][0];

                for (int i = 0; i < MaxRows; i++)
                {
                    if (LastRecord < (int)ds1.Tables["Conturi"].Rows[i][0])
                        LastRecord = (int)ds1.Tables["Conturi"].Rows[i][0];
                }
            }

            txtNrCont.Text = "1-" + (LastRecord + 1).ToString();
           
            con.Close();
                       
        }

        private void InitializeBoxes()
        {   
            txtNume.Clear();        
            txtCompanie.Clear();            
            txtAdresa.Clear();
            txtMobil.Clear();
            txtSoldInitial.Clear();
            chkBoxActiv.CheckState = CheckState.Unchecked;
            txtId.ReadOnly = true;
            txtNrCont.ReadOnly = true;
            this.txtNume.Select();
        }                
                
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb, cb1;
            cb = new SqlCommandBuilder(da);
            cb1 = new SqlCommandBuilder(da1);

            DataRow dRowAccounts = ds1.Tables["Conturi"].NewRow();

            dRowAccounts["Id"] = txtId.Text;
            dRowAccounts["Nr_cont"] = txtNrCont.Text;
            dRowAccounts["Nume"] = txtNume.Text;
            dRowAccounts["Companie"] = txtCompanie.Text;  
            dRowAccounts["Adresa"] = txtAdresa.Text;   
            dRowAccounts["Mobil"] = txtMobil.Text;
            dRowAccounts["Sold_curent"] = txtSoldInitial.Text;

            if (chkBoxActiv.Checked)
            {
                dRowAccounts["stare"] = "activ";
            }
            else
            {
                dRowAccounts["stare"] = "inactiv";
            }

            DateTime now = DateTime.Now;
            dRowAccounts["Data_deschidere_cont"] = now.ToString("G");

            ds1.Tables["Conturi"].Rows.Add(dRowAccounts);

            da.Update(ds1, "Conturi");

            DataRow dRowTranzactii = ds1.Tables["Tranzactii"].NewRow();

            int MaxRows = ds1.Tables["Tranzactii"].Rows.Count;

            dRowTranzactii["Id"] = MaxRows + 1;
            dRowTranzactii["Nr_cont"] = txtNrCont.Text;
            dRowTranzactii["Data_tranzactie"] = now.ToString("G");
            dRowTranzactii["Tip_tranzactie"] = "Cont deschis";
            dRowTranzactii["Valoare_transferata"] = 0;
            dRowTranzactii["Sold_initial"] = txtSoldInitial.Text;
            dRowTranzactii["Sold_nou"] = txtSoldInitial.Text;
            ds1.Tables["Tranzactii"].Rows.Add(dRowTranzactii);
            da1.Update(ds1, "Tranzactii");
            MessageBox.Show("Adaugat");
            this.Close();
        }        

        private void btnSterge_Click(object sender, EventArgs e)
        {
            InitializeBoxes();
        }

        

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoldInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }        
    }
}
