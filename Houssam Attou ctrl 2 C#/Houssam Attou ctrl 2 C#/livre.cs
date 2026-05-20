using System;

namespace Houssam_Attou_ctrl_2_C_
{
    // Task 1: Book Structure definition with all required exam fields
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }
        public string Editeur { get; set; }
        public string Isbn { get; set; }
        public string Categorie { get; set; }
        public bool Disponibilite { get; set; } // True = Available, False = Borrowed

        // Constructor to easily create a book item
        public Livre(int id, string titre, string auteur, int annee, string editeur, string isbn, string categorie, bool disponible)
        {
            Id = id;
            Titre = titre;
            Auteur = auteur;
            AnneePublication = annee;
            Editeur = editeur;
            Isbn = isbn;
            Categorie = categorie;
            Disponibilite = disponible;
        }
    }
}