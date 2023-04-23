using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutpatientWorkstation.Model;
using System.Windows.Forms;

namespace OutpatientWorkstation.DataAccessLayer
{
    public class RegisterDal:IRegisterDal
    {
        public DataTable SelectTechnicalOfficeTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT No,Name FROM tb_TechnicalOffice";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable technicalOfficeTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(technicalOfficeTable);
            sqlConnection.Close();
            return technicalOfficeTable;
        }
        public DataTable SelectDoctorTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT No,Name FROM tb_Agency " +
                "WHERE AgencyTypeNo='1'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable doctorTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(doctorTable);
            sqlConnection.Close();
            return doctorTable;
        }
        public DataTable SelectRegisterTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT R.No AS RNo,P.Name AS PName,A.Name AS AName,T.Name AS TName,R.Remark AS RRemark,R.DateTime AS RDateTime  
                FROM tb_Register AS R
                JOIN tb_Patient AS P ON P.No=R.PatientNo
                JOIN tb_Agency AS A ON A.No=R.DoctorNo
                JOIN tb_TechnicalOffice AS T ON T.No=R.TechnicalOfficeNo";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable registerTable = new DataTable();
            DataTable agencyTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(registerTable);
            sqlConnection.Close();
            return registerTable;
        }
        public Patient SelectPatient(string name)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Patient WHERE Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name",name);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Patient patient=new Patient();
            if (reader.Read())
            {
                patient = new Patient()
                {
                    No = (int)reader["No"],
                    Gender = (bool)reader["Gender"],
                    BirthDate= ((DateTime)reader["BirthDate"]),
                    Phone= reader["Phone"].ToString(),
                    Adress= reader["Adress"].ToString()
                };
            }
            reader.Close();
            return patient;
        }
        public int Insert(string patientNo, string technicalOfficeNo,string doctorNo,string registrarNo,string registerPrice,string remark,DateTime dateTime)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_Register
				(PatientNo,TechnicalOfficeNo,DoctorNo,RegistrarNo,RegisterPrice,Remark,DateTime)
				VALUES(@PatientNo,@TechnicalOfficeNo,@DoctorNo,@RegistrarNo,@RegisterPrice,@Remark,@DateTime)";
            insertCommand.Parameters.AddWithValue("@PatientNo", patientNo);
            insertCommand.Parameters.AddWithValue("@TechnicalOfficeNo", technicalOfficeNo);
            insertCommand.Parameters.AddWithValue("@DoctorNo", doctorNo);
            insertCommand.Parameters.AddWithValue("@RegistrarNo", registrarNo);
            insertCommand.Parameters.AddWithValue("@RegisterPrice", registerPrice);
            insertCommand.Parameters.AddWithValue("@Remark", remark);
            insertCommand.Parameters.AddWithValue("@DateTime", dateTime);
            sqlConnection.Open();
            int rowCount = (int)insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowCount;
        }
    }
}
