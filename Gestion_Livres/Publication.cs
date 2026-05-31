using System;
using System.Windows.Forms;

namespace Gestion_Livres
{
    class Publication
    {
        private int idAuteur;
        private string idLivre;
        private DateTime datPub;
        private int nbrePag;

        public int IdAuteur
        {
            get { return idAuteur; }
            set { idAuteur = value; }
        }

        public string IdLivre
        {
            get { return idLivre; }
            set { idLivre = value; }
        }

        public DateTime DatPub
        {
            get { return datPub; }
            set { datPub = value; }
        }

        public int NbrePag
        {
            get { return nbrePag; }
            set { nbrePag = value; }
        }

        public Publication() { }

        public Publication(int idAut, string idLiv, DateTime dateP, int nbrP)
        {
            this.idAuteur = idAut;
            this.idLivre = idLiv;
            this.datPub = dateP;
            this.nbrePag = nbrP;
        }

        public void enregistrer()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                string rqt = "INSERT INTO Ecrire (idAuteur, idLivre, datPub, nbrePag) VALUES (" +
                             this.idAuteur + ", '" +
                             this.idLivre.Replace("'", "''") + "', #" +
                             this.datPub.ToString("MM/dd/yyyy") + "#, " + this.nbrePag + ")";
                con.executerRqt(rqt);
                MessageBox.Show("Liaison Auteur-Livre réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Publication : " + ex.Message);
            }
        }

        public void modifier()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                string rqt = "UPDATE Ecrire SET datPub = #" + this.datPub.ToString("MM/dd/yyyy") +
                             "#, nbrePag = " + this.nbrePag +
                             " WHERE idAuteur = " + this.idAuteur + " AND idLivre = '" +
                             this.idLivre.Replace("'", "''") + "'";
                con.executerRqt(rqt);
                MessageBox.Show("Mise à jour de la publication réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Modification Publication : " + ex.Message);
            }
        }

        public void supprimer()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                string rqt = "DELETE FROM Ecrire WHERE idAuteur = " + this.idAuteur +
                             " AND idLivre = '" + this.idLivre.Replace("'", "''") + "'";
                con.executerRqt(rqt);
                MessageBox.Show("Liaison supprimée avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Suppression Publication : " + ex.Message);
            }
        }
    }
}