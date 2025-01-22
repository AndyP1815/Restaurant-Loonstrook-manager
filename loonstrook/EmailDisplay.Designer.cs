namespace loonstrook
{
	partial class EmailDisplay
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
			this.ToSendListBox = new System.Windows.Forms.ListBox();
			this.SendListBox = new System.Windows.Forms.ListBox();
			this.FailureListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.sendingTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ToSendListBox
			// 
			this.ToSendListBox.FormattingEnabled = true;
			this.ToSendListBox.ItemHeight = 20;
			this.ToSendListBox.Location = new System.Drawing.Point(57, 61);
			this.ToSendListBox.Name = "ToSendListBox";
			this.ToSendListBox.Size = new System.Drawing.Size(220, 444);
			this.ToSendListBox.TabIndex = 0;
			// 
			// SendListBox
			// 
			this.SendListBox.FormattingEnabled = true;
			this.SendListBox.ItemHeight = 20;
			this.SendListBox.Location = new System.Drawing.Point(746, 45);
			this.SendListBox.Name = "SendListBox";
			this.SendListBox.Size = new System.Drawing.Size(205, 184);
			this.SendListBox.TabIndex = 1;
			// 
			// FailureListBox
			// 
			this.FailureListBox.FormattingEnabled = true;
			this.FailureListBox.ItemHeight = 20;
			this.FailureListBox.Location = new System.Drawing.Point(746, 321);
			this.FailureListBox.Name = "FailureListBox";
			this.FailureListBox.Size = new System.Drawing.Size(205, 184);
			this.FailureListBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(802, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Verzonden";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Te verzenden mails";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(823, 298);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Gefaald";
			// 
			// sendingTextBox
			// 
			this.sendingTextBox.Location = new System.Drawing.Point(330, 254);
			this.sendingTextBox.Name = "sendingTextBox";
			this.sendingTextBox.Size = new System.Drawing.Size(410, 26);
			this.sendingTextBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(409, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(224, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Email die aan het verzenden is";
			// 
			// EmailDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 534);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.sendingTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FailureListBox);
			this.Controls.Add(this.SendListBox);
			this.Controls.Add(this.ToSendListBox);
			this.Name = "EmailDisplay";
			this.Text = "EmailDisplay";
			this.Load += new System.EventHandler(this.EmailDisplay_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ToSendListBox;
		private System.Windows.Forms.ListBox SendListBox;
		private System.Windows.Forms.ListBox FailureListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox sendingTextBox;
		private System.Windows.Forms.Label label4;
	}
}