using System;
using System.Windows.Forms;

namespace Gestion_Livres
{
    class Livre
    {
       
        private string idLivre;     
        private string titre;
        private int nbrepage;       

        public string IdLivre        
        {
            get { return idLivre; }
            set { idLivre = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public int Nbrepage        
        {
            get { return nbrepage; }
            set { nbrepage = value; }
        }

       
        public Livre() { }

        public Livre(string id, string tit, int nbr)
        {
            this.idLivre = id;
            this.titre = tit;
            this.nbrepage = nbr;
        }

        
        public void enregistrer()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                
                string rqt = "INSERT INTO Livre (idLivre, titre, nbrepage) VALUES ('"
                    + this.idLivre.Replace("'", "''") + "', '"
                    + this.titre.Replace("'", "''") + "', "
                    + this.nbrepage + ")";
                con.executerRqt(rqt);
                MessageBox.Show("Enregistrement du livre réussi");
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
                
                string rqt = "UPDATE Livre SET titre = '"
                    + this.titre.Replace("'", "''") + "', nbrepage = "
                    + this.nbrepage + " WHERE idLivre = '"
                    + this.idLivre.Replace("'", "''") + "'";
                con.executerRqt(rqt);
                MessageBox.Show("Modification du livre réussie");
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
                
                con.executerRqt("DELETE FROM Livre WHERE idLivre = '" + this.idLivre.Replace("'", "''") + "'");
                MessageBox.Show("Suppression du livre réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Suppression : " + ex.Message);
            }
        }
    }
}