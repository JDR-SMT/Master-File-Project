using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
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
			Open("MalinStaffNamesV3.csv");
			DisplayListBoxReadOnly();
		}

		private void FormGeneral_KeyDown(object sender, KeyEventArgs e)
		{
			// 4.7.	Utilise a keyboard shortcut.
			if (e.Alt && e.KeyCode == Keys.I)
			{
				ClearFocus(TextBoxInputId);
			}
			// 4.6.	Utilise a keyboard shortcut.
			else if (e.Alt && e.KeyCode == Keys.N)
			{
				ClearFocus(TextBoxInputName);
			}
			// open admin menu
			else if (e.Alt && e.KeyCode == Keys.A)
			{
				Admin();
			}
			// close application
			else if (e.Alt && e.KeyCode == Keys.C)
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

				using (TextFieldParser parser = new TextFieldParser(file))
				{
					// sets delimiter as a comma
					parser.SetDelimiters(",");

					// while there is data
					while (!parser.EndOfData)
					{
						// assign fields on current line to string array
						string[] fields = parser.ReadFields();

						// if fields are not null or white space
						if (!string.IsNullOrWhiteSpace(fields[0]) || !string.IsNullOrWhiteSpace(fields[1]))
						{
							// add fields to dictionary
							MasterFile.Add(int.Parse(fields[0]), fields[1]);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ToolStripStatusLabel.Text = ex.Message;
			}
		}
		#endregion

		#region ListBoxReadOnly
		// 4.3.	Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
		private void DisplayListBoxReadOnly()
		{
			// clear list box
			ListBoxReadOnly.Items.Clear();

			foreach (var kvp in MasterFile)
			{
				// add kvp to list box
				ListBoxReadOnly.Items.Add($"{kvp.Key} {kvp.Value}");
			}
		}
		#endregion

		#region ListBoxFiltered
		// 4.4.	Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box.
		// This method must use a text box input and update as each character is entered. The list box must reflect the data in real time.
		private void FilterByName(string key)
		{
			// clear list box
			ListBoxFiltered.Items.Clear();

			// if key is not null or empty
			if (!string.IsNullOrEmpty(key))
			{
				foreach (var kvp in MasterFile)
				{
					// if kvp contains key while lowercase
					if (kvp.Value.ToLower().Contains(key.ToLower()))
					{
						// add kvp to list box
						ListBoxFiltered.Items.Add($"{kvp.Key} {kvp.Value}");
					}
				}
			}
		}

		// 4.5.	Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box.
		// This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
		private void FilterById(string key)
		{
			// clear list box
			ListBoxFiltered.Items.Clear();

			// if key is not null or empty
			if (!string.IsNullOrEmpty(key))
			{
				foreach (var kvp in MasterFile)
				{
					// if kvp contains key
					if (kvp.Key.ToString().Contains(key))
					{
						// add kvp to list box
						ListBoxFiltered.Items.Add($"{kvp.Key} {kvp.Value}");
					}
				}
			}
		}

		// 4.8.	Create a method for the filtered and selectable list box which will populate the two text boxes when
		// a staff record is selected. Utilise the Tab and keyboard keys.
		private void ListBoxFiltered_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] row = ListBoxFiltered.SelectedItem.ToString().Split(' ');

			TextBoxOutputId.Text = row[0];
			TextBoxOutputName.Text = $"{row[1]} {row[2]}";
		}
		#endregion

		#region Admin
		// 4.9.	Create a method that will open the Admin GUI when the Alt + A keys are pressed. Ensure the General GUI sends
		// the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal.
		// Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty.
		// Read the appropriate criteria in the Admin GUI for further information.
		private void Admin()
		{
			// open admin as modal, pass selected id and name
			FormAdmin formAdmin = new FormAdmin(TextBoxOutputId.Text, TextBoxOutputName.Text);
			formAdmin.ShowDialog();

			// when admin is closed
			Clear();
			Open("MalinStaffNamesV3.csv");
			DisplayListBoxReadOnly();
		}
		#endregion

		#region TextBox KeyPress & KeyChanged
		private void TextBoxInputId_KeyPress(object sender, KeyPressEventArgs e)
		{
			// allow digits and backspaces
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TextBoxInputName_KeyPress(object sender, KeyPressEventArgs e)
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

		// update ListBoxFiltered when text is changed in TextBoxId
		private void TextBoxInputId_TextChanged(object sender, EventArgs e)
		{
			FilterById(TextBoxInputId.Text);
		}

		// update ListBoxFiltered when text is changed in TextBoxName
		private void TextBoxInputName_TextChanged(object sender, EventArgs e)
		{
			FilterByName(TextBoxInputName.Text);
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

		// clear all and focus on TextBoxInputId
		private void Clear()
		{
			ListBoxReadOnly.Items.Clear();
			TextBoxInputName.Clear();
			TextBoxOutputId.Clear();
			TextBoxOutputName.Clear();

			ClearFocus(TextBoxInputId);
		}
		#endregion
	}
}
