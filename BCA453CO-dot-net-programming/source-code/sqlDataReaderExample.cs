using System;
using System.Data.SqlClient;
namespace SqlDataReaderExample {
  class Program {
    static void Main(string[] args) {
      new Program().GetData();
    }
    public void GetData() {
      SqlConnection con = null;
      try {
        // Creating Connection  
        con = new SqlConnection("data source=.; database=bca; integrated security=SSPI");
        // writing sql query  
        SqlCommand cm = new SqlCommand("select * from stu", con);
        // Opening Connection  
        con.Open();
        // Executing the SQL query  
        SqlDataReader sdr = cm.ExecuteReader();
        while (sdr.Read()) {
          Console.WriteLine(sdr["name"] + " " + sdr["address"]);
        }
      } catch (Exception e) {
        Console.WriteLine("Exception!" + e);
      }
      // Closing the connection  
      finally {
        con.Close();
      }
    }
  }
}