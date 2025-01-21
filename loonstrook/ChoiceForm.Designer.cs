namespace loonstrook
{
	partial class ChoiceForm
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
			this.EmployeeButton = new System.Windows.Forms.Button();
			this.PdfButton = new System.Windows.Forms.Button();
			this.EmailButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EmployeeButton
			// 
			this.EmployeeButton.Location = new System.Drawing.Point(39, 104);
			this.EmployeeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.EmployeeButton.Name = "EmployeeButton";
			this.EmployeeButton.Size = new System.Drawing.Size(264, 332);
			this.EmployeeButton.TabIndex = 0;
			this.EmployeeButton.Text = "Medewerkers";
			this.EmployeeButton.UseVisualStyleBackColor = true;
			this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
			// 
			// PdfButton
			// 
			this.PdfButton.Location = new System.Drawing.Point(392, 104);
			this.PdfButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PdfButton.Name = "PdfButton";
			this.PdfButton.Size = new System.Drawing.Size(264, 332);
			this.PdfButton.TabIndex = 1;
			this.PdfButton.Text = "PDF";
			this.PdfButton.UseVisualStyleBackColor = true;
			this.PdfButton.Click += new System.EventHandler(this.PdfButton_Click);
			// 
			// EmailButton
			// 
			this.EmailButton.Location = new System.Drawing.Point(745, 104);
			this.EmailButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.EmailButton.Name = "EmailButton";
			this.EmailButton.Size = new System.Drawing.Size(264, 332);
			this.EmailButton.TabIndex = 2;
			this.EmailButton.Text = "Email";
			this.EmailButton.UseVisualStyleBackColor = true;
			// 
			// ChoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 562);
			this.Controls.Add(this.EmailButton);
			this.Controls.Add(this.PdfButton);
			this.Controls.Add(this.EmployeeButton);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ChoiceForm";
			this.Text = "ChoiceForm";
			this.Load += new System.EventHandler(this.ChoiceForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button EmployeeButton;
		private System.Windows.Forms.Button PdfButton;
		private System.Windows.Forms.Button EmailButton;
	}
}