class Program {
  static void Main(string[] args) {
    DataTable table1 = new DataTable("patients");
	    table1.Columns.Add("name");
	    table1.Columns.Add("id");
	    table1.Rows.Add("ram", 1);
	    table1.Rows.Add("shyam", 2);
	    
    DataSet hospital = new DataSet("Hospital");
    	    hospital.Tables.Add(table1);
    
    //Editing/updating record in DataSet
    DataRow patient1 = table1.Rows[0];
    	    patient1["name"] = "khyam";
    
    //Adding new record in DataSet
    DataRow patient3 = table1.NewRow();
	    patient3["name"] = "dam";
	    patient3["id"] = 3;
	    table1.Rows.Add(patient3);
	
    //Deleting record in DataSet
	   table1.Rows[2].Delete();
	   
    Console.WriteLine(hospital.GetXml());
    Console.ReadLine();
  }
}
