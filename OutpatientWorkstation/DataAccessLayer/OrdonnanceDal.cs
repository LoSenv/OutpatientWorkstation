using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OutpatientWorkstation.DataAccessLayer
{
    public  class OrdonnanceDal:IOrdonnanceDal
    {
        public int SelectCount(int no)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"SELECT COUNT(1)
                FROM tb_Ordonnance
                WHERE No=@No";
            sqlCommand.Parameters.AddWithValue("@No", no);
            sqlConnection.Open();
            int count = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return count;
        }
        public int Insert(Ordonnance ordonnance)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand insertCommand = new SqlCommand();
            SqlCommand insertDetailCommand = new SqlCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = "INSERT INTO tb_Ordonnance " +
                "(No,PatientNo,AgencyNo,Date)" +
                "VALUES(@No,@PatientNo,@AgencyNo,@Date)";
            insertCommand.Parameters.AddWithValue("@No", ordonnance.No);
            insertCommand.Parameters.AddWithValue("@PatientNo", ordonnance.PatientNo);
            insertCommand.Parameters.AddWithValue("@AgencyNo", ordonnance.AgencyNo);
            insertCommand.Parameters.AddWithValue("@Date", ordonnance.Date);
            sqlConnection.Open();
            int rowAffected= insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
        }
    }
}
