string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
using(SqlConnection connection = new SqlConnection(ConnectionString)) {
  SqlDataAdapter dataAdapter = new SqlDataAdapter("spGetProductAndCategoriesData", connection);
  	dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
	  DataSet dataset = new DataSet();
	  dataAdapter.Fill(dataset);
	  GridViewProducts.DataSource = dataset.Tables[0];
	  GridViewProducts.DataBind();
	  GridViewCategories.DataSource = dataset.Tables[1];
	  GridViewCategories.DataBind();
}
