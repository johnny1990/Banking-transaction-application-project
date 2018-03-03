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
    public partial class AfiseazaInformatiiClient : Form
    {
        NumeCont ContVizualizare = new NumeCont();

        public AfiseazaInformatiiClient()
        {
            InitializeComponent();
        }
        
        SqlConnection con; 
        DataSet ds1;                                      
        DataRow[] returnedRows;                            
        SqlDataAdapter da;    

        private void AfiseazaInformatiiClient_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            ds1 = new DataSet();
            con.ConnectionString = "Data Source=MAN;Initial Catalog=Bank;Integrated Security=True";     
            con.Open();
            string sql = "SELECT * From Conturi";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds1, "Conturi");
            AfiseazaInformatii();
            con.Close();
        } 

        private void AfiseazaInformatii()
        {
            string findNrCont = tbText.Text;
            int result = 0;
            
           
            returnedRows = ds1.Tables["Conturi"].Select("Nr_cont='" + findNrCont + "'");            

            result = returnedRows.Length;

            if (result > 0)
            {                
                ContVizualizare.Close();                

                DataRow dRow = returnedRows[0];                
                
                txtId.Text = dRow["Id"].ToString();                
                txtNrCont.Text = dRow["Nr_cont"].ToString();                
                txtNume.Text = dRow["Nume"].ToString();      
                txtCompanie.Text = dRow["Companie"].ToString();
                txtAdresa.Text = dRow["Adresa"].ToString();       
                txtMobil.Text = dRow["Mobil"].ToString();
                txtSoldCurent.Text = dRow["Sold_curent"].ToString();
                txtStare.Text = dRow["Stare"].ToString();

                this.ActiveControl = btnInchide;

                MakeReadOnly(this); 
            }
            else
            {
                this.Close();
                
                MessageBox.Show("Informatia nu a fost gasita!");
                ContVizualizare.Text = "Introduce numarul contului pentru a vizualiza informatiile personale";
                ContVizualizare.Show();
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

        private void btnInchide_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
