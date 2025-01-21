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
			((System.ComponentModel.ISupportInitialize)(this.IdNumUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 135);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "id";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(60, 279);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(351, 31);
			this.EmailTextBox.TabIndex = 1;
			// 
			// IdNumUpDown
			// 
			this.IdNumUpDown.Location = new System.Drawing.Point(60, 164);
			this.IdNumUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.IdNumUpDown.Name = "IdNumUpDown";
			this.IdNumUpDown.Size = new System.Drawing.Size(352, 31);
			this.IdNumUpDown.TabIndex = 2;
			this.IdNumUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// EmployeelistBox
			// 
			this.EmployeelistBox.FormattingEnabled = true;
			this.EmployeelistBox.ItemHeight = 25;
			this.EmployeelistBox.Location = new System.Drawing.Point(433, 15);
			this.EmployeelistBox.Margin = new System.Windows.Forms.Padding(4);
			this.EmployeelistBox.Name = "EmployeelistBox";
			this.EmployeelistBox.Size = new System.Drawing.Size(424, 529);
			this.EmployeelistBox.TabIndex = 3;
			this.EmployeelistBox.SelectedIndexChanged += new System.EventHandler(this.EmployeelistBox_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 359);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 61);
			this.button1.TabIndex = 4;
			this.button1.Text = "Maak";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(305, 359);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 61);
			this.button2.TabIndex = 5;
			this.button2.Text = "Verwijder";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(160, 359);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 61);
			this.button3.TabIndex = 5;
			this.button3.Text = "Update";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 250);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Email";
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 562);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.EmployeelistBox);
			this.Controls.Add(this.IdNumUpDown);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "EmployeeForm";
			this.Text = "Employee";
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
	}
}