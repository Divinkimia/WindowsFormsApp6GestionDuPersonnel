using System.Data.SqlClient;

namespace WindowsFormsApp6GestionDuPersonnel
{
    public class Employe 
    {
        private string emp_nss;
        private string emp_nom;
        private string emp_prenom;
        private decimal emp_salaire;
        private string emp_qualif;
        private string emp_sce;


        public string GetEmpNss()
        {
            return emp_nss;
        }

        public string GetEmpNom()
        {
            return emp_nom;
        }

        public string GetEmpPrenom()
        {
            return emp_prenom;
        }

        public decimal GetEmpSalaire()
        {
            return emp_salaire;
        }

        public string GetEmpQualif() 
        { 
            return emp_qualif ;
        }

        public string GetEmpSce() 
        {
            return emp_sce ; 
        }

        public Employe (SqlDataReader reader) 
        { 
            int indiceEmpNss = reader.GetOrdinal("emp_nss");
            int indiceEmpNom = reader.GetOrdinal("emp_nom");
            int indiceEmpPreom = reader.GetOrdinal("emp_pnom");
            int indiceEmpSalaire = reader.GetOrdinal("emp_salaire");
            int indiceEmpQualif = reader.GetOrdinal("emp_qualif");
            int indiceEmSce = reader.GetOrdinal("emp_sce");


            emp_nss = reader.GetString(indiceEmpNss);
            emp_nom = reader.GetString(indiceEmpNom);
            emp_prenom = reader.GetString(indiceEmpPreom);
            emp_salaire = reader.GetDecimal(indiceEmpSalaire);
            emp_qualif = reader.GetString(indiceEmpQualif);
            emp_sce = reader.GetString(indiceEmSce);
        }
    }
}
