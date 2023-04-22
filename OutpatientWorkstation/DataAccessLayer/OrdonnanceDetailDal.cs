using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation.DataAccessLayer
{
    public class OrdonnanceDetailDal:IOrdonnanceDetailDal
    {
        public DataTable SelectOrdonnanceDetail()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT O.OrdonnanceNo AS '处方编号',O.Type AS '处方类型'
                ,O.Encod AS '处方明细编号',O.MedicineNo AS '药品编号'
                ,M.Name AS '药品名称',UM.Name AS '用药方式',UF.Name AS '用药频率',O.Remark AS '备注' FROM tb_OrdonnanceDetail AS O
                JOIN tb_Medicine AS M ON M.No=O.MedicineNo
                JOIN tb_UseMethod AS UM ON UM.No=O.UseMethodNo
                JOIN tb_UseFrequency AS UF ON UF.No=O.UseFrequencyNo";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable SelectMedicineTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Medicine";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable medicineTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(medicineTable);
            sqlConnection.Close();
            return medicineTable;
        }
        public DataTable SelectListTable(int ordonnanceNo)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Unit";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlCommand.CommandText =
               @"SELECT OD.Type,OD.Encod,OD.MedicineNo,M.Name,OD.UseMethodNo,OD.UseFrequencyNo,OD.Remark
                FROM tb_OrdonnanceDetail AS OD
                JOIN tb_Medicine AS M ON M.No=OD.MedicineNo
                WHERE OD.OrdonnanceNo=@OrdonnanceNo";
            DataTable listTable = new DataTable();
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@OrdonnanceNo", ordonnanceNo);
            sqlDataAdapter.Fill(listTable);
            sqlConnection.Close();
            return listTable;
        }
        public DataTable SelectUseMethodTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_UseMethod";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable useMethodTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(useMethodTable);
            sqlConnection.Close();
            return useMethodTable;
            
        }
        public DataTable SelectFrequencyTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_UseFrequency";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable useFrequencyTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(useFrequencyTable);
            sqlConnection.Close();
            return useFrequencyTable;
        }
        public int Insert(DataTable listTable, int ordonnanceNo)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = "INSERT INTO tb_OrdonnanceDetail" +
                "(OrdonnanceNo,Type,Encod,MedicineNo,UseMethodNo,UseFrequencyNo,Remark)" +
                "values(@OrdonnanceNo,@Type,@Encod,@MedicineNo,@UseMethodNo,@UseFrequencyNo,@Remark)";
            insertCommand.Parameters.AddWithValue("@OrdonnanceNo", ordonnanceNo);
            insertCommand.Parameters.Add("@Type", SqlDbType.VarChar, 0, "Type");
            insertCommand.Parameters.Add("@Encod", SqlDbType.VarChar, 0, "Encod");
            insertCommand.Parameters.Add("@MedicineNo", SqlDbType.Int, 0, "MedicineNo");
            insertCommand.Parameters.Add("@UseMethodNo", SqlDbType.Int, 0, "UseMethodNo");
            insertCommand.Parameters.Add("@UseFrequencyNo", SqlDbType.Int, 0, "UseFrequencyNo");
            insertCommand.Parameters.Add("@Remark", SqlDbType.VarChar, 0, "Remark");
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText = "DELETE tb_OrdonnanceDetail WHERE Encod=@Encod";
            deleteCommand.Parameters.Add("@Encod", SqlDbType.VarChar, 0, "Encod");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable dataTable= new DataTable();
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(dataTable);
            sqlConnection.Close();
            return rowAffected;
        }
    }
}
