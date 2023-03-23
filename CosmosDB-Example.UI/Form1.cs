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
			return;
		}
	}
}