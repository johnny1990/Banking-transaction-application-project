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
    public partial class Retragere_Depunere : Form
    {
        NumeCont IntroduceDepunereRetragere = new NumeCont();
        
        public Retragere_Depunere()
        {
            InitializeComponent();
        }

        SqlConnection con;    
        DataSet ds1;                                   
        DataRow[] returnedRows;                             
        SqlDataAdapter da, da1;                          
        float SoldCurent = 0;

        private void Retragere_Depunere_Load(object sender, EventArgs e)
        {
            if (this.Text == "Depunere")
            {
                grpBoxDepunere.Visible = true;
                grpBoxRetragere.Visible = false;
                btnDepune.Visible = true;
                btnRetrage.Visible = false;
            }

            else if (this.Text == "Retragere")
            {
                grpBoxDepunere.Visible = false;
                grpBoxRetragere.Visible = true;
                btnDepune.Visible = false;
                btnRetrage.Visible = true;
            }
            
            con = new SqlConnection();
            ds1 = new DataSet();
            con.ConnectionString = "Data source=MAN;Initial Catalog=Bank;Integrated Security=True";
            con.Open();

            string sql = "SELECT * From Conturi";
            string sql1 = "SELECT * From Tranzactii";
            da = new SqlDataAdapter(sql, con);
            da1 = new SqlDataAdapter(sql1, con);

            
            da.Fill(ds1, "Conturi");   
            da1.Fill(ds1, "Tranzactii");
            
            FindDisplayRecords();

            con.Close();
                    
        }

        private void FindDisplayRecords()
        {
            string findNrCont = tbText.Text;
            int result = 0;
            

            returnedRows = ds1.Tables["Conturi"].Select("Nr_cont='" + findNrCont + "'");

            result = returnedRows.Length;

            if (result > 0)
            {
                IntroduceDepunereRetragere.Close();

                DataRow dRow = returnedRows[0];

                txtId.Text = dRow["Id"].ToString();
                txtNrCont.Text = dRow["Nr_cont"].ToString();
                txtNume.Text = dRow["Nume"].ToString();           
                txtCompanie.Text = dRow["Companie"].ToString();
                txtAdresa.Text = dRow["Adresa"].ToString();            
                txtMobil.Text = dRow["Mobil"].ToString();
                txtSoldCurent.Text = dRow["Sold_curent"].ToString();
                SoldCurent = float.Parse(dRow["Sold_curent"].ToString());

                MakeReadOnly(this.groupBox1);

                
                
                if (grpBoxDepunere.Visible)
                {
                    this.ActiveControl = txtValDepusa;
                    txtValDepusa.Focus();
                }
                else
                {
                    this.ActiveControl = txtValRetrasa;
                    txtValRetrasa.Focus();
                }                
            }
            else
            {
                if (grpBoxDepunere.Visible)
                {
                    this.Close();                    
                    MessageBox.Show("Informatia nu a fost gasita!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    IntroduceDepunereRetragere.Text = "Introduce numarul contului pentru a depune";                  
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Informatia nu a fost gasita!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    IntroduceDepunereRetragere.Text = "Introduce numarul contului pentru a depune";
                }
                IntroduceDepunereRetragere.Show();
                txtNrCont.Focus();

            }
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

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepune_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb, cb1;
            cb = new SqlCommandBuilder(da);
            cb1 = new SqlCommandBuilder(da1);

            DataRow dRowDepunere = ds1.Tables["Tranzactii"].NewRow();

            int MaxRows = ds1.Tables["Tranzactii"].Rows.Count;

            dRowDepunere["Id"] = MaxRows + 1;
            dRowDepunere["Nr_cont"] = txtNrCont.Text;
            DateTime now = DateTime.Now;
            dRowDepunere["Data_tranzactie"] = now.ToString("G");
            dRowDepunere["Tip_tranzactie"] = "Depunere";
            dRowDepunere["Valoare_transferata"] = float.Parse(txtValDepusa.Text);
            dRowDepunere["Sold_initial"] = float.Parse(txtSoldCurent.Text);
            dRowDepunere["Sold_nou"] = SoldCurent + float.Parse(txtValDepusa.Text);

            ds1.Tables["Tranzactii"].Rows.Add(dRowDepunere);

            da1.Update(ds1, "Tranzactii");

            DataRow UpdatedRow = returnedRows[0];
            
            UpdatedRow["Sold_curent"] = SoldCurent + float.Parse(txtValDepusa.Text);

            da.Update(ds1, "Conturi");

            MessageBox.Show("Sold actualizat.");

            this.Close();
        }

        private void btnRetrage_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb, cb1;
            cb = new SqlCommandBuilder(da);
            cb1 = new SqlCommandBuilder(da1);

            DataRow dRowRetragere= ds1.Tables["Tranzactii"].NewRow();

            int MaxRows = ds1.Tables["Tranzactii"].Rows.Count;

            dRowRetragere["Id"] = MaxRows + 1;
            dRowRetragere["Nr_cont"] = txtNrCont.Text;
            DateTime now = DateTime.Now;
            dRowRetragere["Data_tranzactie"] = now.ToString("G");
            dRowRetragere["Tip_tranzactie"] = "Retragere";
            dRowRetragere["Valoare_transferata"] = float.Parse(txtValRetrasa.Text);
            dRowRetragere["Sold_initial"] = float.Parse(txtSoldCurent.Text);
            dRowRetragere["Sold_nou"] = SoldCurent - float.Parse(txtValRetrasa.Text);

            if (float.Parse(txtValRetrasa.Text) > SoldCurent)
            {
                MessageBox.Show("Insufficient Funds!");

                this.Refresh();
                this.Show();
            }
            else
            {
                ds1.Tables["Tranzactii"].Rows.Add(dRowRetragere);

                da1.Update(ds1, "Tranzactii");

                DataRow UpdatedRow = returnedRows[0];

                UpdatedRow["Sold_curent"] = SoldCurent - float.Parse(txtValRetrasa.Text);

                da.Update(ds1, "Conturi");

                MessageBox.Show("Retragere facuta cu succes. Sold bancar actualizat.");
            }

            this.Close();
        }

        private void txtValRetrasa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValDepunere_KeyPress(object sender, KeyPressEventArgs e)
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
