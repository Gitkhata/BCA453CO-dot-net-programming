using System;
using System.Data.SqlClient;
namespace SqlConnectionExample {
  class Program {
    static void Main(string[] args) {
      new Program().Connecting();
    }
    public void Connecting() {
      using(SqlConnection con = new SqlConnection("data source=.; database=bca; integrated security=SSPI")) {
        con.Open();
        Console.WriteLine("Connection to database successful.");
      }
    }
  }
}