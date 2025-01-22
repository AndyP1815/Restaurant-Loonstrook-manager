namespace loonstrook
{
	partial class EmailForm
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
			this.SelectButton = new System.Windows.Forms.Button();
			this.MailFolderTxtbx = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.Titletxtbx = new System.Windows.Forms.TextBox();
			this.MessageTextbx = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SendButton = new System.Windows.Forms.Button();
			this.SendListBox = new System.Windows.Forms.ListBox();
			this.NotSendListBox = new System.Windows.Forms.ListBox();
			this.addEmployeeButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SelectButton
			// 
			this.SelectButton.Location = new System.Drawing.Point(49, 55);
			this.SelectButton.Name = "SelectButton";
			this.SelectButton.Size = new System.Drawing.Size(168, 46);
			this.SelectButton.TabIndex = 0;
			this.SelectButton.Text = "Select";
			this.SelectButton.UseVisualStyleBackColor = true;
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			// 
			// MailFolderTxtbx
			// 
			this.MailFolderTxtbx.Enabled = false;
			this.MailFolderTxtbx.Location = new System.Drawing.Point(232, 65);
			this.MailFolderTxtbx.Name = "MailFolderTxtbx";
			this.MailFolderTxtbx.Size = new System.Drawing.Size(354, 26);
			this.MailFolderTxtbx.TabIndex = 1;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(57, 129);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(66, 20);
			this.label.TabIndex = 2;
			this.label.Text = "Mail titel";
			// 
			// Titletxtbx
			// 
			this.Titletxtbx.Location = new System.Drawing.Point(49, 152);
			this.Titletxtbx.Name = "Titletxtbx";
			this.Titletxtbx.Size = new System.Drawing.Size(354, 26);
			this.Titletxtbx.TabIndex = 3;
			// 
			// MessageTextbx
			// 
			this.MessageTextbx.Location = new System.Drawing.Point(482, 152);
			this.MessageTextbx.Name = "MessageTextbx";
			this.MessageTextbx.Size = new System.Drawing.Size(354, 26);
			this.MessageTextbx.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(490, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Mail bericht";
			// 
			// SendButton
			// 
			this.SendButton.Location = new System.Drawing.Point(825, 543);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(168, 46);
			this.SendButton.TabIndex = 6;
			this.SendButton.Text = "Verzend ";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// SendListBox
			// 
			this.SendListBox.FormattingEnabled = true;
			this.SendListBox.ItemHeight = 20;
			this.SendListBox.Location = new System.Drawing.Point(620, 245);
			this.SendListBox.Name = "SendListBox";
			this.SendListBox.Size = new System.Drawing.Size(189, 344);
			this.SendListBox.TabIndex = 7;
			this.SendListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// NotSendListBox
			// 
			this.NotSendListBox.FormattingEnabled = true;
			this.NotSendListBox.ItemHeight = 20;
			this.NotSendListBox.Location = new System.Drawing.Point(29, 245);
			this.NotSendListBox.Name = "NotSendListBox";
			this.NotSendListBox.Size = new System.Drawing.Size(203, 344);
			this.NotSendListBox.TabIndex = 8;
			// 
			// addEmployeeButton
			// 
			this.addEmployeeButton.Location = new System.Drawing.Point(263, 312);
			this.addEmployeeButton.Name = "addEmployeeButton";
			this.addEmployeeButton.Size = new System.Drawing.Size(124, 75);
			this.addEmployeeButton.TabIndex = 9;
			this.addEmployeeButton.Text = "Add";
			this.addEmployeeButton.UseVisualStyleBackColor = true;
			this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(482, 312);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 75);
			this.button2.TabIndex = 10;
			this.button2.Text = "Remove";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(665, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Verzenden";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(66, 211);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Niet Verzenden";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// EmailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 601);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.addEmployeeButton);
			this.Controls.Add(this.NotSendListBox);
			this.Controls.Add(this.SendListBox);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MessageTextbx);
			this.Controls.Add(this.Titletxtbx);
			this.Controls.Add(this.label);
			this.Controls.Add(this.MailFolderTxtbx);
			this.Controls.Add(this.SelectButton);
			this.Name = "EmailForm";
			this.Text = "EmailForm";
			this.Load += new System.EventHandler(this.EmailForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SelectButton;
		private System.Windows.Forms.TextBox MailFolderTxtbx;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox Titletxtbx;
		private System.Windows.Forms.TextBox MessageTextbx;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.ListBox SendListBox;
		private System.Windows.Forms.ListBox NotSendListBox;
		private System.Windows.Forms.Button addEmployeeButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}