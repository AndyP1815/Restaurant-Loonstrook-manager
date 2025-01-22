namespace loonstrook
{
	partial class EmployeeForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.IdNumUpDown = new System.Windows.Forms.NumericUpDown();
			this.EmployeelistBox = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.ImportButton = new System.Windows.Forms.Button();
			this.DownloadButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.IdNumUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "id";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(45, 223);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(264, 26);
			this.EmailTextBox.TabIndex = 1;
			// 
			// IdNumUpDown
			// 
			this.IdNumUpDown.Location = new System.Drawing.Point(45, 131);
			this.IdNumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.IdNumUpDown.Name = "IdNumUpDown";
			this.IdNumUpDown.Size = new System.Drawing.Size(264, 26);
			this.IdNumUpDown.TabIndex = 2;
			this.IdNumUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// EmployeelistBox
			// 
			this.EmployeelistBox.FormattingEnabled = true;
			this.EmployeelistBox.ItemHeight = 20;
			this.EmployeelistBox.Location = new System.Drawing.Point(325, 12);
			this.EmployeelistBox.Name = "EmployeelistBox";
			this.EmployeelistBox.Size = new System.Drawing.Size(319, 424);
			this.EmployeelistBox.TabIndex = 3;
			this.EmployeelistBox.SelectedIndexChanged += new System.EventHandler(this.EmployeelistBox_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 49);
			this.button1.TabIndex = 4;
			this.button1.Text = "Maak";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(229, 287);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 49);
			this.button2.TabIndex = 5;
			this.button2.Text = "Verwijder";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(120, 287);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 49);
			this.button3.TabIndex = 5;
			this.button3.Text = "Update";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Email";
			// 
			// ImportButton
			// 
			this.ImportButton.Location = new System.Drawing.Point(12, 378);
			this.ImportButton.Name = "ImportButton";
			this.ImportButton.Size = new System.Drawing.Size(124, 49);
			this.ImportButton.TabIndex = 7;
			this.ImportButton.Text = "Import";
			this.ImportButton.UseVisualStyleBackColor = true;
			this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
			// 
			// DownloadButton
			// 
			this.DownloadButton.Location = new System.Drawing.Point(170, 378);
			this.DownloadButton.Name = "DownloadButton";
			this.DownloadButton.Size = new System.Drawing.Size(128, 49);
			this.DownloadButton.TabIndex = 8;
			this.DownloadButton.Text = "Download";
			this.DownloadButton.UseVisualStyleBackColor = true;
			this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 450);
			this.Controls.Add(this.DownloadButton);
			this.Controls.Add(this.ImportButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.EmployeelistBox);
			this.Controls.Add(this.IdNumUpDown);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.label1);
			this.Name = "EmployeeForm";
			this.Text = "Employee";
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.IdNumUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.NumericUpDown IdNumUpDown;
		private System.Windows.Forms.ListBox EmployeelistBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ImportButton;
		private System.Windows.Forms.Button DownloadButton;
	}
}