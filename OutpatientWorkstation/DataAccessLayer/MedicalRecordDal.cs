using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OutpatientWorkstation.Model;

namespace OutpatientWorkstation.DataAccessLayer
{
    public class MedicalRecordDal:IMedicalRecordDal
    {
        public void LoadInfo()
        {

        }
        public int Insert(string name, string doctorName,string situation,string registerNo)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = @"INSERT INTO tb_MedicalRecord
            (Name,DoctorNo,Situation,RegisterNo)
            VALUES
            (@Name,@DoctorNo,@Situation,@RegisterNo)";
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@DoctorNo", doctorName);
            sqlCommand.Parameters.AddWithValue("@Situation", situation);
            sqlCommand.Parameters.AddWithValue("@RegisterNo", registerNo);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
        }
        public DataTable SelectMedicalRecord()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = @"SELECT MR.No AS MRNo,P.Name AS PName,R.No AS RNo,MR.Name AS MRName,A.Name AS AName
            FROM tb_Register AS R
            JOIN tb_MedicalRecord AS MR ON MR.RegisterNo=R.No
            join tb_Agency AS A ON A.No=MR.DoctorNo
            JOIN tb_Patient AS P ON P.No=R.PatientNo";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
