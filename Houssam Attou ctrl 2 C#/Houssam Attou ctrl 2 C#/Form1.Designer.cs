namespace Houssam_Attou_ctrl_2_C_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtEditeur = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.cmbTri = new System.Windows.Forms.ComboBox();
            this.lblTri = new System.Windows.Forms.Label();

            // Labels to place beside the text boxes
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblEditeur = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivres
            // 
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Location = new System.Drawing.Point(340, 70);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.Size = new System.Drawing.Size(620, 360);
            this.dgvLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivres.SelectionChanged += new System.EventHandler(this.dgvLivres_SelectionChanged);
            // 
            // Labels Placement (Beside inputs)
            // 
            this.lblId.Text = "ID:"; this.lblId.Location = new System.Drawing.Point(15, 43); this.lblId.Size = new System.Drawing.Size(80, 20);
            this.lblTitre.Text = "Title:"; this.lblTitre.Location = new System.Drawing.Point(15, 83); this.lblTitre.Size = new System.Drawing.Size(80, 20);
            this.lblAuteur.Text = "Author:"; this.lblAuteur.Location = new System.Drawing.Point(15, 123); this.lblAuteur.Size = new System.Drawing.Size(80, 20);
            this.lblAnnee.Text = "Year:"; this.lblAnnee.Location = new System.Drawing.Point(15, 163); this.lblAnnee.Size = new System.Drawing.Size(80, 20);
            this.lblEditeur.Text = "Publisher:"; this.lblEditeur.Location = new System.Drawing.Point(15, 203); this.lblEditeur.Size = new System.Drawing.Size(80, 20);
            this.lblIsbn.Text = "ISBN:"; this.lblIsbn.Location = new System.Drawing.Point(15, 243); this.lblIsbn.Size = new System.Drawing.Size(80, 20);
            this.lblCategorie.Text = "Category:"; this.lblCategorie.Location = new System.Drawing.Point(15, 283); this.lblCategorie.Size = new System.Drawing.Size(80, 20);
            // 
            // Clean TextBoxes Layout (Completely removed incompatible PlaceholderText)
            // 
            this.txtId.Location = new System.Drawing.Point(100, 40); this.txtId.Size = new System.Drawing.Size(210, 20);
            this.txtTitre.Location = new System.Drawing.Point(100, 80); this.txtTitre.Size = new System.Drawing.Size(210, 20);
            this.txtAuteur.Location = new System.Drawing.Point(100, 120); this.txtAuteur.Size = new System.Drawing.Size(210, 20);
            this.txtAnnee.Location = new System.Drawing.Point(100, 160); this.txtAnnee.Size = new System.Drawing.Size(210, 20);
            this.txtEditeur.Location = new System.Drawing.Point(100, 200); this.txtEditeur.Size = new System.Drawing.Size(210, 20);
            this.txtIsbn.Location = new System.Drawing.Point(100, 240); this.txtIsbn.Size = new System.Drawing.Size(210, 20);
            this.txtCategorie.Location = new System.Drawing.Point(100, 280); this.txtCategorie.Size = new System.Drawing.Size(210, 20);
            // 
            // chkDisponible
            // 
            this.chkDisponible.Location = new System.Drawing.Point(100, 315);
            this.chkDisponible.Size = new System.Drawing.Size(210, 20);
            this.chkDisponible.Text = "Available for Rent";
            this.chkDisponible.Checked = true;
            // 
            // Action Buttons Layout
            // 
            this.btnAjouter.Location = new System.Drawing.Point(25, 360); this.btnAjouter.Size = new System.Drawing.Size(80, 30); this.btnAjouter.Text = "Add"; this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.btnModifier.Location = new System.Drawing.Point(120, 360); this.btnModifier.Size = new System.Drawing.Size(80, 30); this.btnModifier.Text = "Modify"; this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnSupprimer.Location = new System.Drawing.Point(215, 360); this.btnSupprimer.Size = new System.Drawing.Size(80, 30); this.btnSupprimer.Text = "Delete"; this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Filtering and Sorting Controls Layout
            // 
            this.lblRecherche.Text = "Filter/Search:"; this.lblRecherche.Location = new System.Drawing.Point(340, 25);
            this.txtRecherche.Location = new System.Drawing.Point(425, 22); this.txtRecherche.Size = new System.Drawing.Size(180, 20);
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.lblTri.Text = "Sort By:"; this.lblTri.Location = new System.Drawing.Point(660, 25);
            this.cmbTri.Location = new System.Drawing.Point(720, 22); this.cmbTri.Size = new System.Drawing.Size(150, 21);
            this.cmbTri.Items.AddRange(new object[] { "None", "Title", "Author", "Availability" });
            this.cmbTri.SelectedIndexChanged += new System.EventHandler(this.cmbTri_SelectedIndexChanged);
            // 
            // General Form1 Layout Settings
            // 
            this.ClientSize = new System.Drawing.Size(1000, 460);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvLivres, this.txtId, this.txtTitre, this.txtAuteur, this.txtAnnee, this.txtEditeur, this.txtIsbn, this.txtCategorie, this.chkDisponible, this.btnAjouter, this.btnModifier, this.btnSupprimer, this.txtRecherche, this.lblRecherche, this.cmbTri, this.lblTri,
                this.lblId, this.lblTitre, this.lblAuteur, this.lblAnnee, this.lblEditeur, this.lblIsbn, this.lblCategorie
            });
            this.Text = "Library Book Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtEditeur;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.ComboBox cmbTri;
        private System.Windows.Forms.Label lblTri;

        // Clean UI Label references
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblEditeur;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblCategorie;
    }
}