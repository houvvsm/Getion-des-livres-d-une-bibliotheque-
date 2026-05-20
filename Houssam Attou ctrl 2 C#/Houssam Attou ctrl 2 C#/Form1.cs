using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Houssam_Attou_ctrl_2_C_
{
    public partial class Form1 : Form
    {
        // Start with a completely empty database collection
        private List<Livre> listeLivres = new List<Livre>();

        public Form1()
        {
            InitializeComponent();

            // Autofit grid columns so they adjust beautifully on your screen
            dgvLivres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // REMOVED: No pre-inserted data here anymore. It starts totally blank!
            ActualInterface();
        }

        private void ActualInterface()
        {
            string filtre = txtRecherche.Text.ToLower();
            var listeAffichee = listeLivres.Where(l =>
                l.Titre.ToLower().Contains(filtre) ||
                l.Auteur.ToLower().Contains(filtre) ||
                l.Categorie.ToLower().Contains(filtre)
            ).ToList();

            switch (cmbTri.SelectedItem?.ToString())
            {
                case "Title": listeAffichee = listeAffichee.OrderBy(l => l.Titre).ToList(); break;
                case "Author": listeAffichee = listeAffichee.OrderBy(l => l.Auteur).ToList(); break;
                case "Availability": listeAffichee = listeAffichee.OrderByDescending(l => l.Disponibilite).ToList(); break;
            }

            dgvLivres.DataSource = null;
            dgvLivres.DataSource = listeAffichee;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id) || !int.TryParse(txtAnnee.Text, out int annee))
            {
                MessageBox.Show("ID and Year must be valid numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listeLivres.Exists(l => l.Id == id))
            {
                MessageBox.Show("This Book ID reference already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and append the new entry directly from user runtime inputs
            listeLivres.Add(new Livre(id, txtTitre.Text, txtAuteur.Text, annee, txtEditeur.Text, txtIsbn.Text, txtCategorie.Text, chkDisponible.Checked));
            ActualInterface();
            NettoyerChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvLivres.CurrentRow == null) return;

            int idSelectionne = (int)dgvLivres.CurrentRow.Cells["Id"].Value;
            Livre livre = listeLivres.Find(l => l.Id == idSelectionne);

            if (livre != null)
            {
                livre.Titre = txtTitre.Text;
                livre.Auteur = txtAuteur.Text;
                livre.AnneePublication = int.Parse(txtAnnee.Text);
                livre.Editeur = txtEditeur.Text;
                livre.Isbn = txtIsbn.Text;
                livre.Categorie = txtCategorie.Text;
                livre.Disponibilite = chkDisponible.Checked;

                ActualInterface();
                MessageBox.Show("Book entry modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvLivres.CurrentRow == null) return;

            int idSelectionne = (int)dgvLivres.CurrentRow.Cells["Id"].Value;
            Livre livre = listeLivres.Find(l => l.Id == idSelectionne);

            if (livre != null)
            {
                listeLivres.Remove(livre);
                ActualInterface();
                NettoyerChamps();
                MessageBox.Show("Book deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e) => ActualInterface();
        private void cmbTri_SelectedIndexChanged(object sender, EventArgs e) => ActualInterface();

        private void dgvLivres_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLivres.CurrentRow != null && dgvLivres.CurrentRow.Cells["Id"].Value != null)
            {
                txtId.Text = dgvLivres.CurrentRow.Cells["Id"].Value.ToString();
                txtId.Enabled = false; // Prevent modifying the primary key key value during edits
                txtTitre.Text = dgvLivres.CurrentRow.Cells["Titre"].Value?.ToString();
                txtAuteur.Text = dgvLivres.CurrentRow.Cells["Auteur"].Value?.ToString();
                txtAnnee.Text = dgvLivres.CurrentRow.Cells["AnneePublication"].Value?.ToString();
                txtEditeur.Text = dgvLivres.CurrentRow.Cells["Editeur"].Value?.ToString();
                txtIsbn.Text = dgvLivres.CurrentRow.Cells["Isbn"].Value?.ToString();
                txtCategorie.Text = dgvLivres.CurrentRow.Cells["Categorie"].Value?.ToString();
                chkDisponible.Checked = (bool)dgvLivres.CurrentRow.Cells["Disponibilite"].Value;
            }
        }

        private void NettoyerChamps()
        {
            txtId.Enabled = true;
            txtId.Text = txtTitre.Text = txtAuteur.Text = txtAnnee.Text = txtEditeur.Text = txtIsbn.Text = txtCategorie.Text = "";
            chkDisponible.Checked = true;
        }
    }
}