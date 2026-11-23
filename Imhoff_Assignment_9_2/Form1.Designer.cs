namespace Imhoff_Assignment_9_2
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
			picCola = new PictureBox();
			picRootBeer = new PictureBox();
			picLemonLime = new PictureBox();
			picGrape = new PictureBox();
			picCreamSoda = new PictureBox();
			lblTitle = new Label();
			grpCola = new GroupBox();
			txtColaQty = new TextBox();
			lblColaLeftText = new Label();
			lblColaPrice = new Label();
			grpRootBeer = new GroupBox();
			txtRootBeerQty = new TextBox();
			lblRootBeerLeftText = new Label();
			lblRootBeerPrice = new Label();
			grpLemonLime = new GroupBox();
			txtLemonLimeQty = new TextBox();
			lblLemonLimeLeftText = new Label();
			lblLemonLimePrice = new Label();
			grpGrape = new GroupBox();
			txtGrapeQty = new TextBox();
			lblGrapeLeftText = new Label();
			lblGrapePrice = new Label();
			grpCream = new GroupBox();
			txtCreamQty = new TextBox();
			lblCreamLeftText = new Label();
			lblCreamPrice = new Label();
			grpTotalSales = new GroupBox();
			lblTotalSalesText = new Label();
			txtTotalSales = new TextBox();
			btnExit = new Button();
			((System.ComponentModel.ISupportInitialize)picCola).BeginInit();
			((System.ComponentModel.ISupportInitialize)picRootBeer).BeginInit();
			((System.ComponentModel.ISupportInitialize)picLemonLime).BeginInit();
			((System.ComponentModel.ISupportInitialize)picGrape).BeginInit();
			((System.ComponentModel.ISupportInitialize)picCreamSoda).BeginInit();
			grpCola.SuspendLayout();
			grpRootBeer.SuspendLayout();
			grpLemonLime.SuspendLayout();
			grpGrape.SuspendLayout();
			grpCream.SuspendLayout();
			grpTotalSales.SuspendLayout();
			SuspendLayout();
			// 
			// picCola
			// 
			picCola.Image = Properties.Resources.Cola;
			picCola.Location = new Point(6, 14);
			picCola.Name = "picCola";
			picCola.Size = new Size(62, 62);
			picCola.TabIndex = 0;
			picCola.TabStop = false;
			picCola.Click += picCola_Click;
			// 
			// picRootBeer
			// 
			picRootBeer.Image = Properties.Resources.RootBeer;
			picRootBeer.Location = new Point(6, 14);
			picRootBeer.Name = "picRootBeer";
			picRootBeer.Size = new Size(63, 62);
			picRootBeer.TabIndex = 1;
			picRootBeer.TabStop = false;
			picRootBeer.Click += picRootBeer_Click;
			// 
			// picLemonLime
			// 
			picLemonLime.Image = Properties.Resources.LemonLime;
			picLemonLime.Location = new Point(7, 12);
			picLemonLime.Name = "picLemonLime";
			picLemonLime.Size = new Size(61, 64);
			picLemonLime.TabIndex = 2;
			picLemonLime.TabStop = false;
			picLemonLime.Click += picLemonLime_Click;
			// 
			// picGrape
			// 
			picGrape.Image = Properties.Resources.GrapeSoda;
			picGrape.Location = new Point(6, 12);
			picGrape.Name = "picGrape";
			picGrape.Size = new Size(63, 64);
			picGrape.TabIndex = 3;
			picGrape.TabStop = false;
			picGrape.Click += picGrape_Click;
			// 
			// picCreamSoda
			// 
			picCreamSoda.Image = Properties.Resources.CreamSoda;
			picCreamSoda.Location = new Point(7, 13);
			picCreamSoda.Name = "picCreamSoda";
			picCreamSoda.Size = new Size(61, 63);
			picCreamSoda.TabIndex = 4;
			picCreamSoda.TabStop = false;
			picCreamSoda.Click += picCreamSoda_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.Location = new Point(149, 39);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(134, 25);
			lblTitle.TabIndex = 6;
			lblTitle.Text = "Select a Drink";
			// 
			// grpCola
			// 
			grpCola.Controls.Add(txtColaQty);
			grpCola.Controls.Add(lblColaLeftText);
			grpCola.Controls.Add(lblColaPrice);
			grpCola.Controls.Add(picCola);
			grpCola.Location = new Point(23, 79);
			grpCola.Name = "grpCola";
			grpCola.Size = new Size(166, 82);
			grpCola.TabIndex = 7;
			grpCola.TabStop = false;
			// 
			// txtColaQty
			// 
			txtColaQty.Location = new Point(79, 52);
			txtColaQty.Name = "txtColaQty";
			txtColaQty.ReadOnly = true;
			txtColaQty.Size = new Size(81, 23);
			txtColaQty.TabIndex = 13;
			txtColaQty.Text = "20";
			txtColaQty.TextAlign = HorizontalAlignment.Center;
			// 
			// lblColaLeftText
			// 
			lblColaLeftText.AutoSize = true;
			lblColaLeftText.Location = new Point(84, 34);
			lblColaLeftText.Name = "lblColaLeftText";
			lblColaLeftText.Size = new Size(66, 15);
			lblColaLeftText.TabIndex = 13;
			lblColaLeftText.Text = "Drinks Left:";
			// 
			// lblColaPrice
			// 
			lblColaPrice.AutoSize = true;
			lblColaPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblColaPrice.Location = new Point(97, 19);
			lblColaPrice.Name = "lblColaPrice";
			lblColaPrice.Size = new Size(38, 15);
			lblColaPrice.TabIndex = 13;
			lblColaPrice.Text = "$1.00";
			// 
			// grpRootBeer
			// 
			grpRootBeer.Controls.Add(txtRootBeerQty);
			grpRootBeer.Controls.Add(lblRootBeerLeftText);
			grpRootBeer.Controls.Add(lblRootBeerPrice);
			grpRootBeer.Controls.Add(picRootBeer);
			grpRootBeer.Location = new Point(232, 79);
			grpRootBeer.Name = "grpRootBeer";
			grpRootBeer.Size = new Size(166, 82);
			grpRootBeer.TabIndex = 8;
			grpRootBeer.TabStop = false;
			// 
			// txtRootBeerQty
			// 
			txtRootBeerQty.Location = new Point(75, 52);
			txtRootBeerQty.Name = "txtRootBeerQty";
			txtRootBeerQty.ReadOnly = true;
			txtRootBeerQty.Size = new Size(81, 23);
			txtRootBeerQty.TabIndex = 16;
			txtRootBeerQty.Text = "20";
			txtRootBeerQty.TextAlign = HorizontalAlignment.Center;
			// 
			// lblRootBeerLeftText
			// 
			lblRootBeerLeftText.AutoSize = true;
			lblRootBeerLeftText.Location = new Point(84, 34);
			lblRootBeerLeftText.Name = "lblRootBeerLeftText";
			lblRootBeerLeftText.Size = new Size(66, 15);
			lblRootBeerLeftText.TabIndex = 15;
			lblRootBeerLeftText.Text = "Drinks Left:";
			// 
			// lblRootBeerPrice
			// 
			lblRootBeerPrice.AutoSize = true;
			lblRootBeerPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblRootBeerPrice.Location = new Point(96, 19);
			lblRootBeerPrice.Name = "lblRootBeerPrice";
			lblRootBeerPrice.Size = new Size(38, 15);
			lblRootBeerPrice.TabIndex = 14;
			lblRootBeerPrice.Text = "$1.00";
			// 
			// grpLemonLime
			// 
			grpLemonLime.Controls.Add(txtLemonLimeQty);
			grpLemonLime.Controls.Add(lblLemonLimeLeftText);
			grpLemonLime.Controls.Add(lblLemonLimePrice);
			grpLemonLime.Controls.Add(picLemonLime);
			grpLemonLime.Location = new Point(23, 178);
			grpLemonLime.Name = "grpLemonLime";
			grpLemonLime.Size = new Size(166, 82);
			grpLemonLime.TabIndex = 9;
			grpLemonLime.TabStop = false;
			// 
			// txtLemonLimeQty
			// 
			txtLemonLimeQty.Location = new Point(74, 52);
			txtLemonLimeQty.Name = "txtLemonLimeQty";
			txtLemonLimeQty.ReadOnly = true;
			txtLemonLimeQty.Size = new Size(81, 23);
			txtLemonLimeQty.TabIndex = 16;
			txtLemonLimeQty.Text = "20";
			txtLemonLimeQty.TextAlign = HorizontalAlignment.Center;
			// 
			// lblLemonLimeLeftText
			// 
			lblLemonLimeLeftText.AutoSize = true;
			lblLemonLimeLeftText.Location = new Point(84, 34);
			lblLemonLimeLeftText.Name = "lblLemonLimeLeftText";
			lblLemonLimeLeftText.Size = new Size(66, 15);
			lblLemonLimeLeftText.TabIndex = 15;
			lblLemonLimeLeftText.Text = "Drinks Left:";
			// 
			// lblLemonLimePrice
			// 
			lblLemonLimePrice.AutoSize = true;
			lblLemonLimePrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblLemonLimePrice.Location = new Point(97, 19);
			lblLemonLimePrice.Name = "lblLemonLimePrice";
			lblLemonLimePrice.Size = new Size(38, 15);
			lblLemonLimePrice.TabIndex = 14;
			lblLemonLimePrice.Text = "$1.00";
			// 
			// grpGrape
			// 
			grpGrape.Controls.Add(txtGrapeQty);
			grpGrape.Controls.Add(lblGrapeLeftText);
			grpGrape.Controls.Add(lblGrapePrice);
			grpGrape.Controls.Add(picGrape);
			grpGrape.Location = new Point(232, 178);
			grpGrape.Name = "grpGrape";
			grpGrape.Size = new Size(166, 82);
			grpGrape.TabIndex = 10;
			grpGrape.TabStop = false;
			// 
			// txtGrapeQty
			// 
			txtGrapeQty.Location = new Point(75, 52);
			txtGrapeQty.Name = "txtGrapeQty";
			txtGrapeQty.ReadOnly = true;
			txtGrapeQty.Size = new Size(81, 23);
			txtGrapeQty.TabIndex = 16;
			txtGrapeQty.Text = "20";
			txtGrapeQty.TextAlign = HorizontalAlignment.Center;
			// 
			// lblGrapeLeftText
			// 
			lblGrapeLeftText.AutoSize = true;
			lblGrapeLeftText.Location = new Point(84, 34);
			lblGrapeLeftText.Name = "lblGrapeLeftText";
			lblGrapeLeftText.Size = new Size(66, 15);
			lblGrapeLeftText.TabIndex = 15;
			lblGrapeLeftText.Text = "Drinks Left:";
			// 
			// lblGrapePrice
			// 
			lblGrapePrice.AutoSize = true;
			lblGrapePrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblGrapePrice.Location = new Point(96, 19);
			lblGrapePrice.Name = "lblGrapePrice";
			lblGrapePrice.Size = new Size(38, 15);
			lblGrapePrice.TabIndex = 14;
			lblGrapePrice.Text = "$1.50";
			// 
			// grpCream
			// 
			grpCream.Controls.Add(txtCreamQty);
			grpCream.Controls.Add(lblCreamLeftText);
			grpCream.Controls.Add(lblCreamPrice);
			grpCream.Controls.Add(picCreamSoda);
			grpCream.Location = new Point(23, 278);
			grpCream.Name = "grpCream";
			grpCream.Size = new Size(166, 82);
			grpCream.TabIndex = 11;
			grpCream.TabStop = false;
			// 
			// txtCreamQty
			// 
			txtCreamQty.Location = new Point(79, 52);
			txtCreamQty.Name = "txtCreamQty";
			txtCreamQty.ReadOnly = true;
			txtCreamQty.Size = new Size(81, 23);
			txtCreamQty.TabIndex = 14;
			txtCreamQty.Text = "20";
			txtCreamQty.TextAlign = HorizontalAlignment.Center;
			// 
			// lblCreamLeftText
			// 
			lblCreamLeftText.AutoSize = true;
			lblCreamLeftText.Location = new Point(84, 34);
			lblCreamLeftText.Name = "lblCreamLeftText";
			lblCreamLeftText.Size = new Size(66, 15);
			lblCreamLeftText.TabIndex = 14;
			lblCreamLeftText.Text = "Drinks Left:";
			// 
			// lblCreamPrice
			// 
			lblCreamPrice.AutoSize = true;
			lblCreamPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCreamPrice.Location = new Point(97, 19);
			lblCreamPrice.Name = "lblCreamPrice";
			lblCreamPrice.Size = new Size(38, 15);
			lblCreamPrice.TabIndex = 15;
			lblCreamPrice.Text = "$1.50";
			// 
			// grpTotalSales
			// 
			grpTotalSales.Controls.Add(lblTotalSalesText);
			grpTotalSales.Controls.Add(txtTotalSales);
			grpTotalSales.Location = new Point(232, 278);
			grpTotalSales.Name = "grpTotalSales";
			grpTotalSales.Size = new Size(166, 82);
			grpTotalSales.TabIndex = 12;
			grpTotalSales.TabStop = false;
			// 
			// lblTotalSalesText
			// 
			lblTotalSalesText.AutoSize = true;
			lblTotalSalesText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotalSalesText.Location = new Point(47, 16);
			lblTotalSalesText.Name = "lblTotalSalesText";
			lblTotalSalesText.Size = new Size(65, 15);
			lblTotalSalesText.TabIndex = 14;
			lblTotalSalesText.Text = "Total Sales";
			lblTotalSalesText.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtTotalSales
			// 
			txtTotalSales.Location = new Point(34, 43);
			txtTotalSales.Name = "txtTotalSales";
			txtTotalSales.ReadOnly = true;
			txtTotalSales.Size = new Size(100, 23);
			txtTotalSales.TabIndex = 13;
			txtTotalSales.Text = "$0.00";
			txtTotalSales.TextAlign = HorizontalAlignment.Center;
			// 
			// btnExit
			// 
			btnExit.Font = new Font("Segoe UI", 12F);
			btnExit.Location = new Point(161, 376);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(103, 31);
			btnExit.TabIndex = 13;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(429, 437);
			Controls.Add(btnExit);
			Controls.Add(grpTotalSales);
			Controls.Add(grpCream);
			Controls.Add(grpGrape);
			Controls.Add(grpLemonLime);
			Controls.Add(grpRootBeer);
			Controls.Add(grpCola);
			Controls.Add(lblTitle);
			Name = "Form1";
			Text = "Drink Machine";
			((System.ComponentModel.ISupportInitialize)picCola).EndInit();
			((System.ComponentModel.ISupportInitialize)picRootBeer).EndInit();
			((System.ComponentModel.ISupportInitialize)picLemonLime).EndInit();
			((System.ComponentModel.ISupportInitialize)picGrape).EndInit();
			((System.ComponentModel.ISupportInitialize)picCreamSoda).EndInit();
			grpCola.ResumeLayout(false);
			grpCola.PerformLayout();
			grpRootBeer.ResumeLayout(false);
			grpRootBeer.PerformLayout();
			grpLemonLime.ResumeLayout(false);
			grpLemonLime.PerformLayout();
			grpGrape.ResumeLayout(false);
			grpGrape.PerformLayout();
			grpCream.ResumeLayout(false);
			grpCream.PerformLayout();
			grpTotalSales.ResumeLayout(false);
			grpTotalSales.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox picCola;
		private PictureBox picRootBeer;
		private PictureBox picLemonLime;
		private PictureBox picGrape;
		private PictureBox picCreamSoda;
		private Label lblTitle;
		private GroupBox grpCola;
		private GroupBox grpRootBeer;
		private GroupBox grpLemonLime;
		private GroupBox grpGrape;
		private GroupBox grpCream;
		private GroupBox grpTotalSales;
		private Label lblColaPrice;
		private Label lblRootBeerPrice;
		private Label lblColaLeftText;
		private Label lblRootBeerLeftText;
		private Label lblLemonLimeLeftText;
		private Label lblLemonLimePrice;
		private Label lblGrapeLeftText;
		private Label lblGrapePrice;
		private Label lblCreamLeftText;
		private Label lblCreamPrice;
		private TextBox txtColaQty;
		private TextBox txtRootBeerQty;
		private TextBox txtLemonLimeQty;
		private TextBox txtGrapeQty;
		private TextBox txtCreamQty;
		private Label lblTotalSalesText;
		private TextBox txtTotalSales;
		private Button btnExit;
	}
}
