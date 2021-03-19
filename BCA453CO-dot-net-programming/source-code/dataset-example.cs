using System;
using System.Data;
class Program {
  static void Main() {
    // Create two DataTable instances.
    DataTable table1 = new DataTable("patients");
	    table1.Columns.Add("name");
	    table1.Columns.Add("id");
	    table1.Rows.Add("ram", 1);
	    table1.Rows.Add("shyam", 2);
    DataTable table2 = new DataTable("medications");
	    table2.Columns.Add("id");
	    table2.Columns.Add("medication");
	    table2.Rows.Add(1, "massage");
	    table2.Rows.Add(2, "therapy");
    // Create a DataSet and put both tables in it.
    DataSet set = new DataSet("office");
	    set.Tables.Add(table1);
	    set.Tables.Add(table2);
    // Visualize DataSet.
    Console.WriteLine(set.GetXml());
  }
}

