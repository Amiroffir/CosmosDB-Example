using Cosmos_Example.Model;
using Microsoft.Azure.Cosmos;
using System.Drawing;
using System.Net;

namespace CosmosDB_Example.BusinessLogic
{
	public class CosmosOperations
	{
		// The Azure Cosmos DB endpoint for running this sample.
		private static readonly string EndpointUri = "https://localhost:8081";

		// The primary key for the Azure Cosmos account.
		private static readonly string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

		// The Cosmos client instance
		private CosmosClient cosmosClient;

		// The database we will create
		private Database database;

		// The container we will create.
		private Container container;

		// The name of the database and container we will create
		private string databaseId = "productsFromNorthwind";
		private string containerId = "products";
		public List<Product> products;
		public async Task InsertProductsToCosmos()
		{
			// Create a new instance of the Cosmos Client
			this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey, new CosmosClientOptions() { ApplicationName = "Cosmos-Example" });
			products = (List<Product>)ImportFromNorthwind.RunCommandResult("SELECT * FROM Products");
			await this.CreateDatabaseAsync();
			await this.CreateContainerAsync();
			await this.AddItemsToContainerAsync();
		}

		// <CreateDatabaseAsync>
		/// <summary>
		/// Create the database if it does not exist
		/// </summary>
		private async Task CreateDatabaseAsync()
		{
			// Create a new database
			this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
			Console.WriteLine("Created Database: {0}\n", this.database.Id);
		}
		// </CreateDatabaseAsync>

		// <CreateContainerAsync>
		/// <summary>
		/// Create the container if it does not exist. 
		/// </summary>
		/// <returns></returns>
		private async Task CreateContainerAsync()
		{
			// Create a new container
			this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "/ProductName");
			Console.WriteLine("Created Container: {0}\n", this.container.Id);
		}
		// </CreateContainerAsync>

		// <AddItemsToContainerAsync>
		/// <summary>
		/// Add Family items to the container
		/// </summary>
		private async Task AddItemsToContainerAsync()
		{
			foreach (Product product in products)
			{
				try
				{
					// Read the item to see if it exists.  
					ItemResponse<Product> productResponse = await this.container.ReadItemAsync<Product>(product.ProductName+product.ProductID, new PartitionKey(product.ProductName));
					Console.WriteLine("Item in database with id: {0} already exists\n", productResponse.Resource.ProductID);
				}
				catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
				{
					try
					{
						// Create an item in the container representing the product
						ItemResponse<Product> productResponse = await this.container.CreateItemAsync<Product>(product, new PartitionKey(product.ProductName));
					}
					catch (Exception exc)
					{
						Console.WriteLine(exc.Message);
					}
				}
			}
		}
		// </AddItemsToContainerAsync>	
	}
}
