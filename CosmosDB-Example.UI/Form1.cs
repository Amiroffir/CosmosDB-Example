using Cosmos_Example.Model;
using CosmosDB_Example.BusinessLogic;

namespace CosmosDB_Example.UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e) { }
		private void ImportToCosmosBtn_Click(object sender, EventArgs e)
		{
			CosmosOperations co = new CosmosOperations();
			co.InsertProductsToCosmos();

		}

		private async void IdFilterBtn_Click(object sender, EventArgs e)
		{
			CosmosOperations co = new CosmosOperations();
			List<Product> p = await co.FilterProductsById(textBoxSID.Text);
			richTextBox1.Text = string.Join(Environment.NewLine, p.Select(x => x.ProductName));
		}
		private async void priceFilterBtn_Click(object sender, EventArgs e)
		{
			CosmosOperations co = new CosmosOperations();
			List<Product> p = await co.FilterProductsByPrice(textBoxPrice.Text);
			richTextBox1.Text = string.Join(Environment.NewLine, p.Select(x => x.ProductName));
		}

		private async void NameFilterBtn_Click(object sender, EventArgs e)
		{
			CosmosOperations co = new CosmosOperations();
			List<Product> products = await co.FilterProductsByName(textBoxName.Text);
			richTextBox1.Text = string.Join(Environment.NewLine, products.Select(x => x.ProductName));
		}
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}	
	}
}