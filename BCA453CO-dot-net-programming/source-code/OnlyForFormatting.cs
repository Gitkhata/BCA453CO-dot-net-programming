
string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
using (SqlConnection connection = new SqlConnection(ConnectionString))
{
connection.Open();
SqlCommand command = new SqlCommand("Select * from tblProductInventory", connection);
using (SqlDataReader reader = command.ExecuteReader())
{
    ProductsGridView.DataSource = reader;
    ProductsGridView.DataBind();
    }
}