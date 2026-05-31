using System;
using System.Windows.Forms;

namespace Gestion_Livres
{
    class Auteur
    {
        private int idAuteur;
        private string nomAut;
        private DateTime dateNais;
        private string postnomAut;
        private string prenomAut;

        public int IdAuteur
        {
            get { return idAuteur; }
            set { idAuteur = value; }
        }

        public string NomAut
        {
            get { return nomAut; }
            set { nomAut = value; }
        }

        public DateTime DateNais
        {
            get { return dateNais; }
            set { dateNais = value; }
        }

        public string PostnomAut
        {
            get { return postnomAut; }
            set { postnomAut = value; }
        }

        public string PrenomAut
        {
            get { return prenomAut; }
            set { prenomAut = value; }
        }

        public Auteur() { }

        public Auteur(int id, string nom, DateTime dat, string postnom, string prenom)
        {
            this.idAuteur = id;
            this.nomAut = nom;
            this.dateNais = dat;
            this.postnomAut = postnom;
            this.prenomAut = prenom;
        }

        
        public void enregistrer()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                
                string rqt = "INSERT INTO Auteur (idAuteur, nomAut, dateNais, postnomAut, prenomAut) VALUES ("
                    + this.idAuteur + ", '"
                    + this.nomAut.Replace("'", "''") + "', #"
                    + this.dateNais.ToString("MM/dd/yyyy") + "#, '"
                    + this.postnomAut.Replace("'", "''") + "', '"
                    + this.prenomAut.Replace("'", "''") + "')";
                con.executerRqt(rqt);
                MessageBox.Show("Enregistrement de l'auteur réussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Enregistrement : " + ex.Message);
            }
        }

       
        public void modifier()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                
                string rqt = "UPDATE Auteur SET nomAut = '"
                    + this.nomAut.Replace("'", "''") + "', dateNais = #"
                    + this.dateNais.ToString("MM/dd/yyyy") + "#, postnomAut = '"
                    + this.postnomAut.Replace("'", "''") + "', prenomAut = '"
                    + this.prenomAut.Replace("'", "''") + "' WHERE idAuteur = " + this.idAuteur;
                con.executerRqt(rqt);
                MessageBox.Show("Modification de l'auteur réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Modification : " + ex.Message);
            }
        }

        public void supprimer()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                con.executerRqt("DELETE FROM Auteur WHERE idAuteur = " + this.idAuteur);
                MessageBox.Show("Suppression de l'auteur réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Suppression : " + ex.Message);
            }
        }
    }
}