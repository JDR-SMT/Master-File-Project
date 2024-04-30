namespace GeneralGUI
{
	partial class GeneralForm
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
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.ListBoxReadOnly = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TextBoxInputId = new System.Windows.Forms.TextBox();
			this.TextBoxInputName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ListBoxFiltered = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TextBoxOutputName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TextBoxOutputId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// StatusStrip
			// 
			this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusStrip.Location = new System.Drawing.Point(0, 561);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(662, 22);
			this.StatusStrip.TabIndex = 0;
			this.StatusStrip.Text = "StatusStrip";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "All Staff Members";
			// 
			// ListBoxReadOnly
			// 
			this.ListBoxReadOnly.FormattingEnabled = true;
			this.ListBoxReadOnly.ItemHeight = 16;
			this.ListBoxReadOnly.Location = new System.Drawing.Point(20, 50);
			this.ListBoxReadOnly.Name = "ListBoxReadOnly";
			this.ListBoxReadOnly.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.ListBoxReadOnly.Size = new System.Drawing.Size(300, 388);
			this.ListBoxReadOnly.TabIndex = 2;
			this.ListBoxReadOnly.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(340, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(230, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Search for a staff member";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(340, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Staff ID";
			// 
			// TextBoxInputId
			// 
			this.TextBoxInputId.Location = new System.Drawing.Point(340, 100);
			this.TextBoxInputId.Name = "TextBoxInputId";
			this.TextBoxInputId.Size = new System.Drawing.Size(110, 22);
			this.TextBoxInputId.TabIndex = 0;
			// 
			// TextBoxInputName
			// 
			this.TextBoxInputName.Location = new System.Drawing.Point(470, 100);
			this.TextBoxInputName.Name = "TextBoxInputName";
			this.TextBoxInputName.Size = new System.Drawing.Size(170, 22);
			this.TextBoxInputName.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(470, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Staff Name";
			// 
			// ListBoxFiltered
			// 
			this.ListBoxFiltered.FormattingEnabled = true;
			this.ListBoxFiltered.ItemHeight = 16;
			this.ListBoxFiltered.Location = new System.Drawing.Point(340, 180);
			this.ListBoxFiltered.Name = "ListBoxFiltered";
			this.ListBoxFiltered.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.ListBoxFiltered.Size = new System.Drawing.Size(300, 260);
			this.ListBoxFiltered.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(340, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(202, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Filtered Staff Members";
			// 
			// TextBoxOutputName
			// 
			this.TextBoxOutputName.Location = new System.Drawing.Point(470, 520);
			this.TextBoxOutputName.Name = "TextBoxOutputName";
			this.TextBoxOutputName.Size = new System.Drawing.Size(170, 22);
			this.TextBoxOutputName.TabIndex = 14;
			this.TextBoxOutputName.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(470, 500);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Staff Name";
			// 
			// TextBoxOutputId
			// 
			this.TextBoxOutputId.Location = new System.Drawing.Point(340, 520);
			this.TextBoxOutputId.Name = "TextBoxOutputId";
			this.TextBoxOutputId.Size = new System.Drawing.Size(110, 22);
			this.TextBoxOutputId.TabIndex = 12;
			this.TextBoxOutputId.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(340, 500);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Staff ID";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(340, 470);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(199, 20);
			this.label8.TabIndex = 10;
			this.label8.Text = "Selected staff member";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(20, 460);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(172, 20);
			this.label9.TabIndex = 15;
			this.label9.Text = "Keyboard shortcuts";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(20, 490);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "Alt + I";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(20, 510);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 16);
			this.label11.TabIndex = 17;
			this.label11.Text = "Alt + N";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(20, 530);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(44, 16);
			this.label12.TabIndex = 18;
			this.label12.Text = "Alt + A";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(80, 530);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(116, 16);
			this.label13.TabIndex = 21;
			this.label13.Text = "Open admin menu";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(80, 510);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(132, 16);
			this.label14.TabIndex = 20;
			this.label14.Text = "Search by staff name";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(80, 490);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(111, 16);
			this.label15.TabIndex = 19;
			this.label15.Text = "Search by staff ID";
			// 
			// GeneralForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 583);
			this.ControlBox = false;
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.TextBoxOutputName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TextBoxOutputId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ListBoxFiltered);
			this.Controls.Add(this.TextBoxInputName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TextBoxInputId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ListBoxReadOnly);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.StatusStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "GeneralForm";
			this.Text = "General GUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox ListBoxReadOnly;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBoxInputId;
		private System.Windows.Forms.TextBox TextBoxInputName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox ListBoxFiltered;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TextBoxOutputName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TextBoxOutputId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
	}
}
