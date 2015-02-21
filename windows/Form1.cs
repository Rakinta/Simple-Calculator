using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Graphique1
{
    public partial class Form1 : Form
    {
        string ChaineCalcul;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void m_boutton1_Click(object sender, EventArgs e)
        {
            m_boutton1.Text = "*BOOM*";
            MessageBox.Show("Demerdez vous !!!",
                           "Superbe Citation",
                           MessageBoxButtons.OK);
            MessageBox.Show("BANDE DE FUMISTE !",
                "Il comprend rien le mec",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        #region Boutton Nombre 0->9
        private void b_calc0_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "0";
            ChaineCalcul += "0";
        }
        private void b_calc1_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "1";
            ChaineCalcul += "1";
        }

        private void b_calc2_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "2";
            ChaineCalcul += "2";
        }

        private void b_calc3_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "3";
            ChaineCalcul += "3";
        }

        private void b_calc4_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "4";
            ChaineCalcul += "4";
        }

        private void b_calc5_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "5";
            ChaineCalcul += "5";
        }

        private void b_calc6_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "6";
            ChaineCalcul += "6";
        }
        private void b_calc7_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "7";
            ChaineCalcul += "7";
        }
        private void b_calc8_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "8";
            ChaineCalcul += "8";
        }

        private void b_calc9_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += "9";
            ChaineCalcul += "9";
        }
        #endregion

        #region Bouttons Signe +-*/
        private void b_calcDiv_Click(object sender, EventArgs e)
        {
            tb_affichage.Text = calcul.VerificationChaine(tb_affichage.Text, true);
            tb_affichage.Text += "÷";
        }

        private void b_calcMin_Click(object sender, EventArgs e)
        {
            tb_affichage.Text = calcul.VerificationChaine(tb_affichage.Text, true);
            tb_affichage.Text += "-";
        }

        private void b_calcBy_Click(object sender, EventArgs e)
        {
            tb_affichage.Text = calcul.VerificationChaine(tb_affichage.Text, true);
            tb_affichage.Text += "*";
        }
        private void b_calcAdd_Click(object sender, EventArgs e)
        {
            tb_affichage.Text = calcul.VerificationChaine(tb_affichage.Text, true);
            tb_affichage.Text += "+";
        }
        #endregion

        private void b_calcPnt_Click(object sender, EventArgs e)
        {
            tb_affichage.Text += ",";
        }
        private void b_calcEq_Click(object sender, EventArgs e)
        {
            lb_total.Text = calcul.Calculer(tb_affichage.Text).ToString();
            tb_affichage.Text = lb_total.Text;
        }
        private void b_calcClear_Click(object sender, EventArgs e)
        {
            lb_total.Text = "";
            tb_affichage.Text = "";
        }
        private void tb_affichage_TextChanged(object sender, EventArgs e)
        {
            tb_affichage.Text = calcul.VerificationChaine(tb_affichage.Text);
        }
        private void secretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_boutton1.Visible)
            {
                m_boutton1.Visible = false;
            }
            else
            {
                m_boutton1.Visible = true;
            }

            if (lb_total.Visible)
            {
                lb_total.Visible = false;
            }
            else
            {
                lb_total.Visible = true;
            }

            if (lb_resultat.Visible)
            {
                lb_resultat.Visible = false;
            }
            else
            {
                lb_resultat.Visible = true;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?",
                                                "Quitter ?",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_affichage.Text.Length > 0)
            {
                tb_affichage.Text = tb_affichage.Text.Remove(tb_affichage.Text.Length - 1, 1);
            }
            
        }

        private void sm_copier_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_affichage.Text);
        }
        private void sm_coller_Click(object sender, EventArgs e)
        {
            tb_affichage.Text = Clipboard.GetText();
        }

    }
}