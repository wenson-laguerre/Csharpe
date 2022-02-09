using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Finale__Hinde_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            txtPatientPrenom.Text = "";
            txtPatientNom.Text = string.Empty;
            txtMedcinNom.Text = string.Empty;
            //txtMatricule.Text = string.Empty;
            cboxMatricule.Text = string.Empty;
            rbGeneralist.Checked = false;
            rbSpecialiste.Checked = false;
            rbOui.Checked = false;
            rbNon.Checked = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtPatientPrenom.Text == "" || txtPatientNom.Text == "" /*|| txtMedcinNom.Text == ""*/ || cboxMatricule.Text == "")
                MessageBox.Show("Veuillez Remplir les champs manquants !!");
            else if (rbGeneralist.Checked == false && rbSpecialiste.Checked == false)
            {
                MessageBox.Show("Veuillez selectionner le type de consultation (Generaliste ou Specialiste) !!");
            }
            else
            {
                if (rbOui.Checked == true)

                    dgvListeConsultation.Rows.Add(txtPatientNom.Text, txtPatientPrenom.Text, txtMedcinNom.Text, cboxMatricule.Text, rbOui.Text);
                else if(rbNon.Checked == true)
                    dgvListeConsultation.Rows.Add(txtPatientNom.Text, txtPatientPrenom.Text, txtMedcinNom.Text, cboxMatricule.Text ,rbNon.Text);
                else
                    MessageBox.Show("Est ce que c'est une urgence? (Veuillez choisir oui ou non) !!");

            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (txtPatientNom.Text == "" || txtPatientPrenom.Text == "")
                MessageBox.Show("Vous n'avez pas spécifié la consultation de qui à supprimer");
            else
            {
                try
                {
                    if (dgvListeConsultation.Rows.Count == 0) throw new Exception();
                    else
                    {
                        DialogResult suppression = MessageBox.Show("Voulez vous vraiment faire la suppression ?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (suppression == DialogResult.Yes)
                        {
                            for (int i = 0; i < dgvListeConsultation.Rows.Count; i++)
                            {
                                if (txtPatientNom.Text != "" && txtPatientPrenom.Text != "" && dgvListeConsultation.Rows[i].Cells[0].Value.ToString().Equals(txtPatientNom))
                                {
                                    dgvListeConsultation.Rows.RemoveAt(i);
                                    existe = true;
                                }
                            }
                            if (existe == false)
                                MessageBox.Show("La nom du patient ne figure pas dans la liste !");

                        }
                    }
                    }
                catch (Exception)
                {
                    MessageBox.Show("Votre liste est vide !!");
                }
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMatricule.Text == "JAD123")
                txtMedcinNom.Text = "Jaques Dubois";
            else if (cboxMatricule.Text == "NAH234")
                txtMedcinNom.Text = "Nassim Hilali";
            else if (cboxMatricule.Text == "QA567")
                txtMedcinNom.Text = "Quan";
            else
                txtMedcinNom.Text = "Souliere";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            StreamWriter saveListe = new StreamWriter("Consultations.txt", false);

            foreach(DataGridViewRow colonne in dgvListeConsultation.Rows)
            {
                string nomPatient = colonne.Cells[0].Value.ToString();
                string prenomPatient = colonne.Cells[1].Value.ToString();
                string nomMedcin = colonne.Cells[2].Value.ToString();
                string matricule = colonne.Cells[3].Value.ToString();
                string typeConsultation = colonne.Cells[4].Value.ToString();
                string urgence = colonne.Cells[5].Value.ToString();
                saveListe.WriteLine(nomPatient + "/"+prenomPatient + "/" + nomMedcin + "/" + matricule + "/" + typeConsultation + "/" + urgence);
            }
        }
    }
}
