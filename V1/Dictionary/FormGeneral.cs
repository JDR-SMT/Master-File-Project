using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Dictionary
{
	public partial class FormGeneral : Form
	{
		public FormGeneral()
		{
			InitializeComponent();
			Cursor.Hide();
		}

		// 4.1.	Create a Dictionary data structure with a TKey of type integer and a TValue of type string, name the new data structure “MasterFile”.
		// 4.10. Ensure the Dictionary is static and public.
		public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

		#region Form Load & KeyDown
		private void FormGeneral_Load(object sender, System.EventArgs e)
		{
			Open("MalinStaffNames.csv");
			DisplayListBoxRecords();
		}

		private void FormGeneral_KeyDown(object sender, KeyEventArgs e)
		{
			// 4.7.	Utilise a keyboard shortcut.
			if (e.Alt && e.KeyCode == Keys.I)
			{
				ClearFocus(TextBoxId);
			}
			// 4.6.	Utilise a keyboard shortcut.
			else if (e.Alt && e.KeyCode == Keys.N)
			{
				ClearFocus(TextBoxName);
			}
			// open admin menu
			else if (e.Alt && e.KeyCode == Keys.A)
			{
				Admin();
			}
			// close application
			else if (e.Alt && e.KeyCode == Keys.L)
			{
				Application.Exit();
			}
		}
		#endregion

		#region Open
		// 4.2.	Create a method that will read the data from the .csv file into the Dictionary data structure when the GUI loads.
		private void Open(string file)
		{
			try
			{
				// clear dictionary
				MasterFile.Clear();

				// read file
				using (var reader = new StreamReader(@file))
				{
					// until end of stream
					while (!reader.EndOfStream)
					{
						// assign fields on current line to string array
						string[] fields = reader.ReadLine().Split(',');

						// add fields to dictionary
						MasterFile.Add(int.Parse(fields[0]), fields[1]);
					}
				}
			}
			catch (Exception ex)
			{
				ToolStripStatusLabel.Text = ex.Message;
			}
		}
		#endregion

		#region ListBoxRecords
		// 4.3.	Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
		private void DisplayListBoxRecords()
		{
			// clear list box
			ListBoxRecords.Items.Clear();

			foreach (var kvp in MasterFile)
			{
				// add kvp to list box
				ListBoxRecords.Items.Add($"{kvp.Key} {kvp.Value}");
			}
		}
		#endregion

		#region ListBoxFilter
		// 4.4.	Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box.
		// This method must use a text box input and update as each character is entered. The list box must reflect the data in real time.
		private void FilterByName(string key)
		{
			// clear list box
			ListBoxFilter.Items.Clear();

			// if key is not null or empty
			if (!string.IsNullOrEmpty(key))
			{
				foreach (var kvp in MasterFile)
				{
					// if kvp starts with key
					if (kvp.Value.ToLower().StartsWith(key.ToLower()))
					{
						// add kvp to list box
						ListBoxFilter.Items.Add($"{kvp.Key} {kvp.Value}");
					}
				}
			}
		}

		// 4.5.	Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box.
		// This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
		private void FilterById(string key)
		{
			// clear list box
			ListBoxFilter.Items.Clear();

			// if key is not null or empty
			if (!string.IsNullOrEmpty(key))
			{
				foreach (var kvp in MasterFile)
				{
					// if kvp starts with key
					if (kvp.Key.ToString().StartsWith(key))
					{
						// add kvp to list box
						ListBoxFilter.Items.Add($"{kvp.Key} {kvp.Value}");
					}
				}
			}
		}

		// 4.8.	Create a method for the filtered and selectable list box which will populate the two text boxes when
		// a staff record is selected. Utilise the Tab and keyboard keys.
		private void ListBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				// if no record is selected
				if (ListBoxFilter.SelectedItem == null)
				{
					ToolStripStatusLabel.Text = "Please select a record before pressing enter.";
				}
				// if a record is selected
				else
				{
					string[] record = ListBoxFilter.SelectedItem.ToString().Split();

					if (record.Length == 3)
					{
						TextBoxId.Text = record[0];
						TextBoxName.Text = $"{record[1]} {record[2]}";
					}
					else
					{
						TextBoxId.Text = record[0];
						TextBoxName.Text = $"{record[1]}";
					}
				}
			}
		}
		#endregion

		#region Admin
		// 4.9.	Create a method that will open the Admin GUI when the Alt + A keys are pressed. Ensure the General GUI sends
		// the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal.
		// Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty.
		// Read the appropriate criteria in the Admin GUI for further information.
		private void Admin()
		{
			// if id is null or 77 and name is empty
			if (string.IsNullOrEmpty(TextBoxId.Text) || (int.Parse(TextBoxId.Text).Equals(77)
				&& string.IsNullOrEmpty(TextBoxName.Text)))
			{
				// open admin as modal, generate a new id
				FormAdmin formAdmin = new FormAdmin();
				formAdmin.ShowDialog();
			}
			// existing user
			else if (MasterFile.ContainsKey(int.Parse(TextBoxId.Text)))
			{
				// open admin as modal, pass selected id and name
				FormAdmin formAdmin = new FormAdmin(TextBoxId.Text, TextBoxName.Text);
				formAdmin.ShowDialog();
			}

			// when admin is closed
			Clear();
			DisplayListBoxRecords();
		}
		#endregion

		#region TextBox KeyPress & KeyChanged
		private void TextBoxId_KeyPress(object sender, KeyPressEventArgs e)
		{
			// allow digits and backspaces
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// allow letters, white spaces and backspaces
			if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			// allow a single white space
			if (e.KeyChar == ' ' && (sender as TextBox).Text.IndexOf(' ') > -1)
			{
				e.Handled = true;
			}

			// do not allow a white space at the beginning
			if (e.KeyChar == ' ' && (sender as TextBox).Text.Length == 0)
			{
				e.Handled = true;
			}
		}

		// update ListBoxFilter when text is changed in TextBoxId
		private void TextBoxId_TextChanged(object sender, EventArgs e)
		{
			FilterById(TextBoxId.Text);
		}

		// update ListBoxFilter when text is changed in TextBoxName
		private void TextBoxName_TextChanged(object sender, EventArgs e)
		{
			FilterByName(TextBoxName.Text);
		}
		#endregion

		#region ClearFocus & Clear
		// 4.6.	Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box.
		// 4.7.	Create a method for the Staff ID text box which will clear the contents and place the focus into the Staff ID text box.
		private void ClearFocus(TextBox textBox)
		{
			textBox.Clear();
			textBox.Focus();
		}

		// clear all and focus on TextBoxId
		private void Clear()
		{
			ListBoxRecords.Items.Clear();
			TextBoxName.Clear();
			TextBoxId.Clear();
			TextBoxName.Clear();

			ClearFocus(TextBoxId);
		}
		#endregion
	}
}
