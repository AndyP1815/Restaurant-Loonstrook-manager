namespace loonstrook
{
	partial class Pdf
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.convertButton = new System.Windows.Forms.Button();
			this.SelectPdfButton = new System.Windows.Forms.Button();
			this.PdfDirectory = new System.Windows.Forms.TextBox();
			this.BestandNaam = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FileNameTextBox = new System.Windows.Forms.TextBox();
			this.MapNameTextBox = new System.Windows.Forms.TextBox();
			this.mapLocationTextBox = new System.Windows.Forms.TextBox();
			this.MapLocationButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(552, 277);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(166, 94);
			this.convertButton.TabIndex = 0;
			this.convertButton.Text = "Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// SelectPdfButton
			// 
			this.SelectPdfButton.Location = new System.Drawing.Point(30, 31);
			this.SelectPdfButton.Name = "SelectPdfButton";
			this.SelectPdfButton.Size = new System.Drawing.Size(137, 65);
			this.SelectPdfButton.TabIndex = 2;
			this.SelectPdfButton.Text = "PDF Loonstrook";
			this.SelectPdfButton.UseVisualStyleBackColor = true;
			this.SelectPdfButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// PdfDirectory
			// 
			this.PdfDirectory.Enabled = false;
			this.PdfDirectory.Location = new System.Drawing.Point(196, 50);
			this.PdfDirectory.Name = "PdfDirectory";
			this.PdfDirectory.Size = new System.Drawing.Size(463, 26);
			this.PdfDirectory.TabIndex = 3;
			// 
			// BestandNaam
			// 
			this.BestandNaam.AutoSize = true;
			this.BestandNaam.Location = new System.Drawing.Point(54, 240);
			this.BestandNaam.Name = "BestandNaam";
			this.BestandNaam.Size = new System.Drawing.Size(113, 20);
			this.BestandNaam.TabIndex = 4;
			this.BestandNaam.Text = "Bestand naam";
			this.BestandNaam.Click += new System.EventHandler(this.BestandNaam_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 314);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Map naam";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// FileNameTextBox
			// 
			this.FileNameTextBox.Location = new System.Drawing.Point(58, 273);
			this.FileNameTextBox.Name = "FileNameTextBox";
			this.FileNameTextBox.Size = new System.Drawing.Size(456, 26);
			this.FileNameTextBox.TabIndex = 6;
			this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
			// 
			// MapNameTextBox
			// 
			this.MapNameTextBox.Location = new System.Drawing.Point(58, 348);
			this.MapNameTextBox.Name = "MapNameTextBox";
			this.MapNameTextBox.Size = new System.Drawing.Size(456, 26);
			this.MapNameTextBox.TabIndex = 7;
			this.MapNameTextBox.TextChanged += new System.EventHandler(this.MapNameTextBox_TextChanged);
			// 
			// mapLocationTextBox
			// 
			this.mapLocationTextBox.Enabled = false;
			this.mapLocationTextBox.Location = new System.Drawing.Point(196, 145);
			this.mapLocationTextBox.Name = "mapLocationTextBox";
			this.mapLocationTextBox.Size = new System.Drawing.Size(463, 26);
			this.mapLocationTextBox.TabIndex = 9;
			// 
			// MapLocationButton
			// 
			this.MapLocationButton.Location = new System.Drawing.Point(30, 126);
			this.MapLocationButton.Name = "MapLocationButton";
			this.MapLocationButton.Size = new System.Drawing.Size(137, 65);
			this.MapLocationButton.TabIndex = 8;
			this.MapLocationButton.Text = "Map locatie";
			this.MapLocationButton.UseVisualStyleBackColor = true;
			this.MapLocationButton.Click += new System.EventHandler(this.MapLocationButton_Click);
			// 
			// Pdf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 496);
			this.Controls.Add(this.mapLocationTextBox);
			this.Controls.Add(this.MapLocationButton);
			this.Controls.Add(this.MapNameTextBox);
			this.Controls.Add(this.FileNameTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BestandNaam);
			this.Controls.Add(this.PdfDirectory);
			this.Controls.Add(this.SelectPdfButton);
			this.Controls.Add(this.convertButton);
			this.Name = "Pdf";
			this.Text = "Pdf";
			this.Load += new System.EventHandler(this.Pdf_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.Button SelectPdfButton;
		private System.Windows.Forms.TextBox PdfDirectory;
		private System.Windows.Forms.Label BestandNaam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FileNameTextBox;
		private System.Windows.Forms.TextBox MapNameTextBox;
		private System.Windows.Forms.TextBox mapLocationTextBox;
		private System.Windows.Forms.Button MapLocationButton;
	}
}