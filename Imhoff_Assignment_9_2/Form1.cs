namespace Imhoff_Assignment_9_2
{
	public partial class Form1 : Form
	{
		// Create a structure to hold the information for each drink.
		private struct Drink
		{
			// Store the name of the drink.
			public string Name;

			// Store the price of the drink.
			public decimal Cost;

			// Store the number of drinks currently in the machine.
			public int Quantity;
		}

		// Create an array that can hold five Drink structures.
		private Drink[] drinks = new Drink[5];

		// Create a variable to keep track of all sales.
		private decimal totalSales = 0.00m;

		public Form1()
		{
			InitializeComponent();
			// Store the Cola information in the first array element.
			drinks[0].Name = "Cola";
			drinks[0].Cost = 1.00m;
			drinks[0].Quantity = 20;

			// Store the Root Beer information in the second array element.
			drinks[1].Name = "Root Beer";
			drinks[1].Cost = 1.00m;
			drinks[1].Quantity = 20;

			// Store the Lemon Lime information in the third array element.
			drinks[2].Name = "Lemon Lime";
			drinks[2].Cost = 1.00m;
			drinks[2].Quantity = 20;

			// Store the Grape Soda information in the fourth array element.
			drinks[3].Name = "Grape Soda";
			drinks[3].Cost = 1.50m;
			drinks[3].Quantity = 20;

			// Store the Cream Soda information in the fifth array element.
			drinks[4].Name = "Cream Soda";
			drinks[4].Cost = 1.50m;
			drinks[4].Quantity = 20;
		}

		private void picCola_Click(object sender, EventArgs e)
		{
			// Check whether there is at least one Cola left in the machine.
			if (drinks[0].Quantity > 0)
			{
				// Subtract one Cola from the inventory.
				drinks[0].Quantity--;

				// Add the Cola price to the total sales.
				totalSales += drinks[0].Cost;

				// Update the Cola quantity shown on the form.
				txtColaQty.Text = drinks[0].Quantity.ToString();

				// Update the total sales shown on the form.
				txtTotalSales.Text = totalSales.ToString("C");
			}
			else
			{
				// Tell the user that Cola is sold out.
				MessageBox.Show("Cola is sold out.");
			}
		}

		private void picRootBeer_Click(object sender, EventArgs e)
		{
			// Check whether there is at least one Root Beer left in the machine.
			if (drinks[1].Quantity > 0)
			{
				// Subtract one Root Beer from the inventory.
				drinks[1].Quantity--;

				// Add the Root Beer price to the total sales.
				totalSales += drinks[1].Cost;

				// Update the Root Beer quantity shown on the form.
				txtRootBeerQty.Text = drinks[1].Quantity.ToString();

				// Update the total sales shown on the form.
				txtTotalSales.Text = totalSales.ToString("C");
			}
			else
			{
				// Tell the user that Root Beer is sold out.
				MessageBox.Show("Root Beer is sold out.");
			}
		}

		private void picLemonLime_Click(object sender, EventArgs e)
		{
			// Check whether there is at least one Lemon Lime left in the machine.
			if (drinks[2].Quantity > 0)
			{
				// Subtract one Lemon Lime from the inventory.
				drinks[2].Quantity--;

				// Add the Lemon Lime price to the total sales.
				totalSales += drinks[2].Cost;

				// Update the Lemon Lime quantity shown on the form.
				txtLemonLimeQty.Text = drinks[2].Quantity.ToString();

				// Update the total sales shown on the form.
				txtTotalSales.Text = totalSales.ToString("C");
			}
			else
			{
				// Tell the user that Lemon Lime is sold out.
				MessageBox.Show("Lemon Lime is sold out.");
			}
		}

		private void picGrape_Click(object sender, EventArgs e)
		{
			// Check whether there is at least one Grape Soda left in the machine.
			if (drinks[3].Quantity > 0)
			{
				// Subtract one Grape Soda from the inventory.
				drinks[3].Quantity--;

				// Add the Grape Soda price to the total sales.
				totalSales += drinks[3].Cost;

				// Update the Grape Soda quantity shown on the form.
				txtGrapeQty.Text = drinks[3].Quantity.ToString();

				// Update the total sales shown on the form.
				txtTotalSales.Text = totalSales.ToString("C");
			}
			else
			{
				// Tell the user that Grape Soda is sold out.
				MessageBox.Show("Grape Soda is sold out.");
			}

		}

		private void picCreamSoda_Click(object sender, EventArgs e)
		{
			// Check whether there is at least one Cream Soda left in the machine.
			if (drinks[4].Quantity > 0)
			{
				// Subtract one Cream Soda from the inventory.
				drinks[4].Quantity--;

				// Add the Cream Soda price to the total sales.
				totalSales += drinks[4].Cost;

				// Update the Cream Soda quantity shown on the form.
				txtCreamQty.Text = drinks[4].Quantity.ToString();

				// Update the total sales shown on the form.
				txtTotalSales.Text = totalSales.ToString("C");
			}
			else
			{
				// Tell the user that Cream Soda is sold out.
				MessageBox.Show("Cream Soda is sold out.");
			}

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			// Close the program when Exit Button is clicked
			this.Close();
		}
	}
}
