//Step 1: Prepare Connection
SqlConnection objConnection = new SqlConnection();
objConnection.ConnectionString = @ "Data Source=ComputerName\SQLInstance;InitialCatalog = DatabaseName;Integrated Security = False;User ID = username;Password = 123;";
objConnection.Open();
//Step 2: Prepare & Execute Command
	SqlCommand objCommand = new SqlCommand();
	objCommand.Connection = objConnection;
	objCommand.CommandType = CommandType.Text;
	objCommand.CommandText = "SELECT CountryID, CountryName FROM Country ORDER BY CountryName";
//Step 3: Collect Data to DataReader object which has been received as a result of Command
		SqlDataReader objSDR = objCommand.ExecuteReader();
		gvCountry.DataSource = objSDR;
		gvCountry.DataBind();
objConnection.Close();
