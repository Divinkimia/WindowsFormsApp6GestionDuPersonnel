using System.Data.SqlClient;

namespace WindowsFormsApp6GestionDuPersonnel
{
    
        public class Service 
        {
            private string sce_code;
            private string sce_des;
            private string sce_type;
            private decimal sce_budget;


           public string  GetSceCode() 
           {
            return sce_code;
           }

            public string GetSceDes()
            {
                return sce_des;
            }

            public string GetSceType()
            {
                return sce_type;
            }

            public decimal GetSceBudget()
            {
                return sce_budget;
            }


            public Service (SqlDataReader reader) 
            {
            int indiceSceCode = reader.GetOrdinal("sce_code");
            int indiceSceDes = reader.GetOrdinal("sce_des");
            int indiceSceType = reader.GetOrdinal("sce_type");
            int indiceSceBudget = reader.GetOrdinal("sce_budget");

            sce_code = reader.GetString(indiceSceCode);
            sce_des = reader.GetString(indiceSceDes);
            sce_type = reader.GetString(indiceSceType);
            sce_budget = reader.GetDecimal(indiceSceBudget);
            }
        }

        


   
}
