using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public class MedicalRecordDal:IMedicalRecordDal
    {
        public void Insert()
        {

        }
        public DataTable Select()
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
