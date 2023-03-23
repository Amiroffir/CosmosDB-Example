using Cosmos_Example.Model;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CosmosDB_Example.BusinessLogic
{
	public class ImportFromNorthwind
	{
		 private static string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\SQLEXPRESS";

		public static object RunCommandResult(string sqlQ)
		{
			object ret = null;
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				string queryString = sqlQ;
				// Adapter
				using (SqlCommand command = new SqlCommand(queryString, connection))
				{
					try
					{
						connection.Open();

						//Reader
						using (SqlDataReader reader = command.ExecuteReader())
						{
							ret = setQueryResult(reader);
						}
					}
					catch (SqlException e)
					{
						throw e;
					}
				}
			}
			return ret;
		}


		private static object setQueryResult(SqlDataReader reader)
		{
			object ret = null;
			List<Product> products = new List<Product>();
			while (reader.Read())
			{
				Product p = new Product();
				int pid = (int)reader["ProductID"];
				p.ProductID = pid.ToString();		
				p.ProductName = (string)reader["ProductName"];
				p.SupplierID = (int)reader["SupplierID"];
				p.CategoryID = (int)reader["CategoryID"];
				p.QuantityPerUnit = (string)reader["QuantityPerUnit"];
				p.UnitPrice = (decimal)reader["UnitPrice"];
				//p.UnitsInStock = (int)reader["UnitsInStock"];
				//p.UnitsOnOrder = (int)reader["UnitsOnOrder"];
				//p.ReorderLevel = (int)reader["ReorderLevel"];
				p.Discontinued = (bool)reader["Discontinued"];
				products.Add(p);
			}
			return products;
		}


	}
}