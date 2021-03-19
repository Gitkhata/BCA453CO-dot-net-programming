using System;
using System.Data;
using System.Data.SqlClient;
namespace DataTable_Datarow_DataColumn_Example {
  class Program {
    static void Main(string[] args) {
      //Step 1: Prepare Connection
      SqlConnection objConnection = new SqlConnection();
      objConnection.ConnectionString = @"Data Source=ComputerName\SQLInstance;Initial
Catalog=DatabaseName;Integrated Security=False; User ID=username;
Password=123;";
      objConnection.Open();
      //Step 2: Prepare & Execute Command
      SqlCommand objCommand = new SqlCommand();
      objCommand.Connection = objConnection;
      objCommand.CommandType = CommandType.Text;
      objCommand.CommandText = "SELECT CountryID, CountryName FROM Country ORDER BY
CountryName";
      SqlDataAdapter sda = new SqlDataAdapter(objCommand);
      DataTable dt = new DataTable();
      sda.Fill(dt);
      objConnection.Close();
    }
  }
}
