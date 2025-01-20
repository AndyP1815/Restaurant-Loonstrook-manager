namespace loonstrook
{
	partial class Form1
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
			this.selectButton = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.createButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.initializeButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// selectButton
			// 
			this.selectButton.Location = new System.Drawing.Point(342, 51);
			this.selectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(215, 83);
			this.selectButton.TabIndex = 0;
			this.selectButton.Text = "Kies";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(31, 51);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(256, 304);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(426, 350);
			this.createButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(233, 81);
			this.createButton.TabIndex = 2;
			this.createButton.Text = "Maak";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(13, 376);
			this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(135, 29);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// initializeButton
			// 
			this.initializeButton.Location = new System.Drawing.Point(342, 174);
			this.initializeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.initializeButton.Name = "initializeButton";
			this.initializeButton.Size = new System.Drawing.Size(215, 83);
			this.initializeButton.TabIndex = 4;
			this.initializeButton.Text = "token";
			this.initializeButton.UseVisualStyleBackColor = true;
			this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(175, 376);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(135, 29);
			this.DeleteButton.TabIndex = 5;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 445);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.initializeButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.selectButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button selectButton;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button initializeButton;
		private System.Windows.Forms.Button DeleteButton;
	}
}

