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
    public class PatientDal:IPatientDal
    {
        public DataTable Select()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT No AS 编号,Name AS 姓名,IIF(Gender=1,'男','女') AS 性别
                ,BirthDate AS 出生日期,Phone AS 电话,Adress AS 地址
                FROM tb_Patient";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataTable PatientTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(PatientTable);
            sqlConnection.Close();
            return PatientTable;
        }
    }
}
