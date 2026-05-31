using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Gestion_Livres
{
    class ConnexionBD
    {
        public OleDbConnection cnx = new OleDbConnection();
        public OleDbCommand cmd = new OleDbCommand();
     

        public ConnexionBD()
        {
           
            cnx.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BARAKA\Documents\bd_examen_C.mdb";
        }

        public void connecter()
        {
            if (cnx.State == ConnectionState.Closed) cnx.Open();
        }

        public void deconnecter()
        {
            if (cnx.State == ConnectionState.Open) cnx.Close();
        }

        public void executerRqt(string rqt)
        {
            try
            {
                connecter();
                cmd.Connection = cnx;
                cmd.CommandText = rqt;
                cmd.ExecuteNonQuery();
                deconnecter();
            }
            catch (Exception ex) { MessageBox.Show("Erreur SQL : " + ex.Message); }
        }

   
        public void chargerDGV(string rqt, DataGridView dgv)
        {
            try
            {
                connecter();
                OleDbDataAdapter daLocal = new OleDbDataAdapter(rqt, cnx);
                DataTable dtLocal = new DataTable();
                daLocal.Fill(dtLocal);

                dgv.DataSource = dtLocal; 
                deconnecter();
            }
            catch (Exception ex) { MessageBox.Show("Erreur de chargement : " + ex.Message); }
        }

       
        public void chargerCBO(string rqt, ComboBox cbo, string valeur, string champs)
        {
            try
            {
                connecter();
                OleDbDataAdapter daLocal = new OleDbDataAdapter(rqt, cnx);
                DataTable dtLocal = new DataTable(); 
                daLocal.Fill(dtLocal);

                cbo.DataSource = dtLocal;
                cbo.DisplayMember = champs;
                cbo.ValueMember = valeur;
                deconnecter();
            }
            catch (Exception ex) { MessageBox.Show("Erreur ComboBox : " + ex.Message); }
        }
    }
}