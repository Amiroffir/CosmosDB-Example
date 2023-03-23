namespace CosmosDB_Example.UI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ImportToCosmosBtn = new System.Windows.Forms.Button();
			this.priceFilterBtn = new System.Windows.Forms.Button();
			this.IdFilterBtn = new System.Windows.Forms.Button();
			this.NameFilterBtn = new System.Windows.Forms.Button();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxSID = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// ImportToCosmosBtn
			// 
			this.ImportToCosmosBtn.Location = new System.Drawing.Point(56, 12);
			this.ImportToCosmosBtn.Name = "ImportToCosmosBtn";
			this.ImportToCosmosBtn.Size = new System.Drawing.Size(238, 23);
			this.ImportToCosmosBtn.TabIndex = 0;
			this.ImportToCosmosBtn.Text = "Import products from Northwind";
			this.ImportToCosmosBtn.Click += new System.EventHandler(this.ImportToCosmosBtn_Click);
			// 
			// priceFilterBtn
			// 
			this.priceFilterBtn.Location = new System.Drawing.Point(23, 79);
			this.priceFilterBtn.Name = "priceFilterBtn";
			this.priceFilterBtn.Size = new System.Drawing.Size(202, 23);
			this.priceFilterBtn.TabIndex = 1;
			this.priceFilterBtn.Text = "Products that cheaper than";
			this.priceFilterBtn.UseVisualStyleBackColor = true;
			this.priceFilterBtn.Click += new System.EventHandler(this.priceFilterBtn_Click);
			// 
			// IdFilterBtn
			// 
			this.IdFilterBtn.Location = new System.Drawing.Point(23, 136);
			this.IdFilterBtn.Name = "IdFilterBtn";
			this.IdFilterBtn.Size = new System.Drawing.Size(202, 23);
			this.IdFilterBtn.TabIndex = 2;
			this.IdFilterBtn.Text = "Product by ID";
			this.IdFilterBtn.UseVisualStyleBackColor = true;
			this.IdFilterBtn.Click += new System.EventHandler(this.IdFilterBtn_Click);
			// 
			// NameFilterBtn
			// 
			this.NameFilterBtn.Location = new System.Drawing.Point(23, 181);
			this.NameFilterBtn.Name = "NameFilterBtn";
			this.NameFilterBtn.Size = new System.Drawing.Size(202, 23);
			this.NameFilterBtn.TabIndex = 3;
			this.NameFilterBtn.Text = "Search by name";
			this.NameFilterBtn.UseVisualStyleBackColor = true;
			this.NameFilterBtn.Click += new System.EventHandler(this.NameFilterBtn_Click);
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(231, 80);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
			this.textBoxPrice.TabIndex = 4;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(231, 182);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 23);
			this.textBoxName.TabIndex = 5;
			// 
			// textBoxSID
			// 
			this.textBoxSID.Location = new System.Drawing.Point(231, 136);
			this.textBoxSID.Name = "textBoxSID";
			this.textBoxSID.Size = new System.Drawing.Size(100, 23);
			this.textBoxSID.TabIndex = 6;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(352, 57);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(207, 251);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 352);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBoxSID);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.NameFilterBtn);
			this.Controls.Add(this.IdFilterBtn);
			this.Controls.Add(this.priceFilterBtn);
			this.Controls.Add(this.ImportToCosmosBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button ImportToCosmosBtn;
		private Button priceFilterBtn;
		private Button IdFilterBtn;
		private Button NameFilterBtn;
		private TextBox textBoxPrice;
		private TextBox textBoxName;
		private TextBox textBoxSID;
		private RichTextBox richTextBox1;
	}
}