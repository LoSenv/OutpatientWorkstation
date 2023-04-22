using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation.DataAccessLayer
{
    public class MedicineDal:IMedicineDal
    {
       public DataTable SelectMedicineTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = @"SELECT * FROM tb_Medicine";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataTable  MedicineTable = new DataTable();
            MedicineTable.TableName = "Medicine";
            DataColumn rowIdColumn = new DataColumn();
            rowIdColumn.ColumnName = "RowId";
            rowIdColumn.DataType = typeof(int);
            rowIdColumn.AutoIncrement = true;
            rowIdColumn.AutoIncrementSeed = 1;
            rowIdColumn.AutoIncrementStep = 1;
            MedicineTable.Columns.Add(rowIdColumn);
            sqlConnection.Open();
            sqlDataAdapter.Fill(MedicineTable);
            sqlConnection.Close();
            return MedicineTable;
        }
        public DataTable SelectUnitTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Unit";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable unitTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(unitTable);
            sqlConnection.Close();
            return unitTable;
        }
        public int Update(DataTable medicineTable)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText =
                $@"UPDATE tb_Medicine
                SET Name=@Name,Spec=@Spec,UnitNo=@UnitNo,Efficacy=@Efficacy,Price=@Price,Count=@Count
                WHERE No=@No";
            updateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
            updateCommand.Parameters.Add("@Spec", SqlDbType.VarChar, 0, "Spec");
            updateCommand.Parameters.Add("@UnitNo", SqlDbType.Int, 0, "UnitNo");
            updateCommand.Parameters.Add("@Efficacy", SqlDbType.VarChar, 0, "Efficacy");
            updateCommand.Parameters.Add("@Price", SqlDbType.Money, 0, "Price");
            updateCommand.Parameters.Add("@Count", SqlDbType.Int, 0, "Count");
            updateCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.UpdateCommand = updateCommand;
            DataTable dataTable = medicineTable;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(dataTable);
            sqlConnection.Close();
            return rowAffected;
        }
        public int Delete(DataTable medicineTable)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_Medicine WHERE No=@No";
            deleteCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable dataTable = medicineTable;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(dataTable);
            sqlConnection.Close();
            return rowAffected;
        }
    }
}
