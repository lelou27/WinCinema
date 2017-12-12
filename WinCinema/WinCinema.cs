using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCinema
{
    public partial class WinCinema : Form
    {
        public WinCinema()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cacherElements()
        {

        }

        private void btn_CalculerTarif_Click(object sender, EventArgs e)
        {
            double total = 0;

            string horaire = cbx_Horaire.Text, jour = cbx_Jour.Text;
            bool erreur = false;

            if (horaire == "" || jour == "")
            {
                MessageBox.Show("Vous devez entrer un jour et un horaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erreur = true;
            }


            if (!erreur)
            {
                lbl_TarifApplicable.Text = "";

                if (horaire == "11H10")
                {
                    total = 5.20;
                    gpb_Tarif.Hide();
                }
                else
                {
                    if (jour != "Lundi" && horaire != "11H10" && !ckb_TarifCE.Checked && !rdb_TarifEtudiant.Checked && !rdb_TarifReduit.Checked)
                        total = 8.70;
                }

                if (jour == "Lundi")
                {
                    total = 5.70;
                    gpb_Tarif.Hide();
                }
                else
                {
                    if (horaire != "11H10" && !ckb_TarifCE.Checked && !rdb_TarifEtudiant.Checked && !rdb_TarifReduit.Checked)
                        total = 8.70;
                }

                if (ckb_TarifCE.Checked)
                    total = 5.20;

                if (rdb_TarifEtudiant.Checked)
                    total = 5.90;

                if (rdb_TarifReduit.Checked)
                    total = 6.90;

                if (ckb_Majoration3D.Checked)
                    total += 1.50;

                if (ckb_CouponReduc.Checked && !ckb_TarifCE.Checked)
                    total -= 1;

                lbl_TarifApplicable.Text = total + " Euros";
            }

        }

        private void ckb_TarifCE_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_TarifCE.Checked)
            {
                gpb_Tarif.Hide();
                ckb_CouponReduc.Hide();
            }
            else
            {
                gpb_Tarif.Show();
                ckb_CouponReduc.Show();
            }
        }
    }
}
