namespace loonstrook
{
	partial class UpdateRestaurant
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
			this.systenComboBox = new System.Windows.Forms.ComboBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(134, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "systeem";
			// 
			// systenComboBox
			// 
			this.systenComboBox.FormattingEnabled = true;
			this.systenComboBox.Location = new System.Drawing.Point(138, 190);
			this.systenComboBox.Name = "systenComboBox";
			this.systenComboBox.Size = new System.Drawing.Size(288, 28);
			this.systenComboBox.TabIndex = 11;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(309, 239);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(117, 45);
			this.saveButton.TabIndex = 10;
			this.saveButton.Text = "save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(134, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "email";
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Location = new System.Drawing.Point(134, 94);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(77, 20);
			this.password.TabIndex = 9;
			this.password.Text = "password";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(138, 127);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(288, 26);
			this.passwordTextBox.TabIndex = 7;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(138, 55);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(288, 26);
			this.emailTextBox.TabIndex = 6;
			// 
			// UpdateRestaurant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 307);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.systenComboBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.password);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.emailTextBox);
			this.Name = "UpdateRestaurant";
			this.Text = "UpdateRestaurant";
			this.Load += new System.EventHandler(this.UpdateRestaurant_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox systenComboBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
	}
}