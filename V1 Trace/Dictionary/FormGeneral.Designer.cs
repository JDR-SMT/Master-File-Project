namespace Dictionary
{
	partial class FormGeneral
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
			this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.ListBoxRecords = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TextBoxId = new System.Windows.Forms.TextBox();
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ListBoxFilter = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// StatusStrip
			// 
			this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 491);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(661, 22);
			this.StatusStrip.TabIndex = 0;
			this.StatusStrip.Text = "StatusStrip";
			// 
			// ToolStripStatusLabel
			// 
			this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
			this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
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
			// ListBoxRecords
			// 
			this.ListBoxRecords.FormattingEnabled = true;
			this.ListBoxRecords.ItemHeight = 16;
			this.ListBoxRecords.Location = new System.Drawing.Point(20, 50);
			this.ListBoxRecords.Name = "ListBoxRecords";
			this.ListBoxRecords.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.ListBoxRecords.Size = new System.Drawing.Size(300, 420);
			this.ListBoxRecords.TabIndex = 2;
			this.ListBoxRecords.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(340, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(230, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Search for a staff member";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(340, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Staff ID";
			// 
			// TextBoxId
			// 
			this.TextBoxId.Location = new System.Drawing.Point(340, 70);
			this.TextBoxId.Name = "TextBoxId";
			this.TextBoxId.Size = new System.Drawing.Size(90, 22);
			this.TextBoxId.TabIndex = 0;
			this.TextBoxId.TextChanged += new System.EventHandler(this.TextBoxId_TextChanged);
			this.TextBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxId_KeyPress);
			// 
			// TextBoxName
			// 
			this.TextBoxName.Location = new System.Drawing.Point(450, 70);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(190, 22);
			this.TextBoxName.TabIndex = 1;
			this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
			this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(450, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Staff Name";
			// 
			// ListBoxFilter
			// 
			this.ListBoxFilter.FormattingEnabled = true;
			this.ListBoxFilter.ItemHeight = 16;
			this.ListBoxFilter.Location = new System.Drawing.Point(340, 150);
			this.ListBoxFilter.Name = "ListBoxFilter";
			this.ListBoxFilter.Size = new System.Drawing.Size(300, 180);
			this.ListBoxFilter.TabIndex = 2;
			this.ListBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListBoxFilter_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(340, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(202, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Filtered Staff Members";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(340, 360);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(172, 20);
			this.label9.TabIndex = 15;
			this.label9.Text = "Keyboard shortcuts";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(340, 390);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "Alt + I";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(340, 410);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 16);
			this.label11.TabIndex = 17;
			this.label11.Text = "Alt + N";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(340, 430);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(44, 16);
			this.label12.TabIndex = 18;
			this.label12.Text = "Alt + A";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(400, 430);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(116, 16);
			this.label13.TabIndex = 21;
			this.label13.Text = "Open admin menu";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(400, 410);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(132, 16);
			this.label14.TabIndex = 20;
			this.label14.Text = "Search by staff name";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(400, 390);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(111, 16);
			this.label15.TabIndex = 19;
			this.label15.Text = "Search by staff ID";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(400, 450);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(111, 16);
			this.label16.TabIndex = 23;
			this.label16.Text = "Close application";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(340, 450);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(42, 16);
			this.label17.TabIndex = 22;
			this.label17.Text = "Alt + L";
			// 
			// FormGeneral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 513);
			this.ControlBox = false;
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ListBoxFilter);
			this.Controls.Add(this.TextBoxName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TextBoxId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ListBoxRecords);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.StatusStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(679, 560);
			this.MinimumSize = new System.Drawing.Size(679, 560);
			this.Name = "FormGeneral";
			this.Text = "General";
			this.Load += new System.EventHandler(this.FormGeneral_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGeneral_KeyDown);
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox ListBoxRecords;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBoxId;
		private System.Windows.Forms.TextBox TextBoxName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox ListBoxFilter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
	}
}

