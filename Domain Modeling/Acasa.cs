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
    public partial class Acasa : Form
    {
        public Acasa()
        {
            InitializeComponent();
        }

        private void mnuIesire_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa iesi?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        NumeCont cNumeCont = new NumeCont();
        private void AfiseazaInformatiiPersonaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cNumeCont.IsDisposed || cNumeCont == null)
            {
                cNumeCont = new NumeCont();
                cNumeCont.Text = "Introduce numarul contului pentru a vizualiza informatiile personale";
                cNumeCont.Show();
            }
            else
            {
                cNumeCont.Text = "Introduce numarul contului pentru a vizualiza informatiile personale";
                cNumeCont.Show();
            }
        }

        ContNou ContNou = new ContNou();

        private void mnuNou_Click(object sender, EventArgs e)
        {
            if (ContNou.IsDisposed || ContNou == null)
            {
                ContNou = new ContNou();
                ContNou.Show();
                ContNou.Activate();
            }
            else
            {
                ContNou.Show();

                ContNou.Activate();
            }
        }

        NumeCont dNumeCont = new NumeCont();

        private void mnuDepunere_Click(object sender, EventArgs e)
        {
            if (dNumeCont.IsDisposed || dNumeCont == null)
            {
                dNumeCont = new NumeCont();
                dNumeCont.Text = "Introduce numarul contului pentru a depune";
                dNumeCont.Show();
            }
            else
            {
               dNumeCont.Text = "Introduce numarul contului pentru a depune";
               dNumeCont.Show();
            }
        }

        NumeCont rNumeCont = new NumeCont();
        private void mnuRetragere_Click(object sender, EventArgs e)
        {
            if (rNumeCont.IsDisposed || rNumeCont == null)
            {
                rNumeCont = new NumeCont();
                rNumeCont.Text = "Introduce numarul contului pentru a retrage";
                rNumeCont.Show();
            }
            else
            {
                rNumeCont.Text = "Introduce numarul contului pentru a retrage";
                rNumeCont.Show();
            }
        }

        NumeCont tNumeCont = new NumeCont();

        private void mnuIstoricTranzactii_Click(object sender, EventArgs e)
        {
            if (tNumeCont.IsDisposed || tNumeCont == null)
            {
                tNumeCont = new NumeCont();
                tNumeCont.Text = "Introduce numarul contului pentru a vizualiza tranzactiile";
                tNumeCont.Show();
            }
            else
            {
                tNumeCont.Text = "Introduce numarul contului pentru a vizualiza tranzactiile";
                tNumeCont.Show();
            }
        }

        }        
    }

