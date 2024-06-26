﻿namespace Dictionary
{
	partial class FormAdmin
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
			this.TextBoxId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Staff Member Details";
			// 
			// TextBoxId
			// 
			this.TextBoxId.Location = new System.Drawing.Point(20, 70);
			this.TextBoxId.Name = "TextBoxId";
			this.TextBoxId.ReadOnly = true;
			this.TextBoxId.Size = new System.Drawing.Size(90, 22);
			this.TextBoxId.TabIndex = 1;
			this.TextBoxId.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Staff ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(130, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Staff Name";
			// 
			// TextBoxName
			// 
			this.TextBoxName.Location = new System.Drawing.Point(130, 70);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(190, 22);
			this.TextBoxName.TabIndex = 0;
			this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(20, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Keyboard shortcuts";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Alt + C";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(80, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "Create a new staff member";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(80, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(198, 16);
			this.label7.TabIndex = 9;
			this.label7.Text = "Update an existing staff member";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 170);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "Alt + U";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(80, 190);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(193, 16);
			this.label9.TabIndex = 11;
			this.label9.Text = "Delete an existing staff member";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(20, 190);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 16);
			this.label10.TabIndex = 10;
			this.label10.Text = "Alt + D";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(80, 210);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(118, 16);
			this.label11.TabIndex = 13;
			this.label11.Text = "Close admin menu";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(20, 210);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 16);
			this.label12.TabIndex = 12;
			this.label12.Text = "Alt + L";
			// 
			// StatusStrip
			// 
			this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 239);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(341, 24);
			this.StatusStrip.TabIndex = 14;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// ToolStripStatusLabel
			// 
			this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
			this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 18);
			// 
			// FormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 263);
			this.ControlBox = false;
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TextBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TextBoxId);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(359, 310);
			this.MinimumSize = new System.Drawing.Size(359, 310);
			this.Name = "FormAdmin";
			this.Text = "Admin";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAdmin_KeyDown);
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBoxName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
	}
}