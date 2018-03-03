using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DomainModelling___Simulator
{
    public partial class NumeCont : Form
    {
        public NumeCont()
        {
            InitializeComponent();
        }

        private void btnDeschide_Click(object sender, EventArgs e)
        {
            if (this.Text == "Introduce numarul contului pentru a vizualiza informatiile personale")
            {
                AfiseazaInformatiiClient aAfiseazaInformatiiClient = new AfiseazaInformatiiClient();

                aAfiseazaInformatiiClient.tbText.Text = this.txtNrCont.Text;

                this.Close();

                aAfiseazaInformatiiClient.Show();
            }
            
             else if (this.Text == "Introduce numarul contului pentru a depune")
            {
                Retragere_Depunere Retragere_Depunere = new Retragere_Depunere();

                Retragere_Depunere.tbText.Text = this.txtNrCont.Text;

                this.Close();
                Retragere_Depunere.Text = "Depunere";
                Retragere_Depunere.Show();
            }
            else if (this.Text == "Introduce numarul contului pentru a retrage")
            {
                Retragere_Depunere Retragere_Depunere = new Retragere_Depunere();

               
                Retragere_Depunere.tbText.Text = this.txtNrCont.Text;

                this.Close();
                Retragere_Depunere.Text = "Retragere";
                Retragere_Depunere.Show();
            }
            
            else if (this.Text == "Introduce numarul contului pentru a vizualiza tranzactiile")
            {
               IstoricTranzactii IstoricTranzactii = new IstoricTranzactii();

               
                IstoricTranzactii.tbText.Text = this.txtNrCont.Text;

                this.Close();
                IstoricTranzactii.Show();
            }
        }

        private void txtNrCont_Leave(object sender, EventArgs e)
        {
            if (txtNrCont.Text == "")
            {
                MessageBox.Show("Campul este gol!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Refresh();
                txtNrCont.Focus();
            }
        }         
    }
}
