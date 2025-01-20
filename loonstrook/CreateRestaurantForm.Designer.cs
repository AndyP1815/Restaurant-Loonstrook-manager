namespace loonstrook
{
	partial class CreateRestaurantForm
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
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.systenComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(75, 60);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(288, 26);
			this.emailTextBox.TabIndex = 0;
			this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(75, 132);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(288, 26);
			this.passwordTextBox.TabIndex = 1;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Location = new System.Drawing.Point(71, 99);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(77, 20);
			this.password.TabIndex = 2;
			this.password.Text = "password";
			this.password.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "email";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(246, 244);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(117, 45);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// systenComboBox
			// 
			this.systenComboBox.FormattingEnabled = true;
			this.systenComboBox.Location = new System.Drawing.Point(75, 195);
			this.systenComboBox.Name = "systenComboBox";
			this.systenComboBox.Size = new System.Drawing.Size(288, 28);
			this.systenComboBox.TabIndex = 4;
			this.systenComboBox.SelectedIndexChanged += new System.EventHandler(this.systenComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 172);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "systeem";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// CreateRestaurantForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 301);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.systenComboBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.password);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.emailTextBox);
			this.Name = "CreateRestaurantForm";
			this.Text = "createRestaurantForm";
			this.Load += new System.EventHandler(this.CreateRestaurantForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ComboBox systenComboBox;
		private System.Windows.Forms.Label label1;
	}
}