using System;
using System.IO;
using System.Windows.Forms;

namespace Dictionary
{
	public partial class FormAdmin : Form
	{
		// display generated id
		public FormAdmin()
		{
			InitializeComponent();
			Cursor.Hide();
			DisplayTextBoxes(UniqueId());
		}

		// display passed id and name
		public FormAdmin(string id, string name)
		{
			InitializeComponent();
			Cursor.Hide();
			DisplayTextBoxes(id, name);
		}

		#region Form KeyDown
		private void FormAdmin_KeyDown(object sender, KeyEventArgs e)
		{
			// create a new user
			if (e.Alt && e.KeyCode == Keys.C)
			{
				// if key does not exist and a name has been entered
				if (!FormGeneral.MasterFile.ContainsKey(int.Parse(TextBoxId.Text)) && !string.IsNullOrEmpty(TextBoxName.Text))
				{
					Create(TextBoxName.Text);
					Save("MalinStaffNames.csv");
					Close();
				}
				// if name is null or empty
				else if (string.IsNullOrEmpty(TextBoxName.Text))
				{
					ToolStripStatusLabel.Text = "Please enter a name.";
				}
				// if key exists
				else
				{
					ToolStripStatusLabel.Text = "User already exists.";
				}
			}
			// update an existing user
			else if (e.Alt && e.KeyCode == Keys.U)
			{
				// if key exists
				if (FormGeneral.MasterFile.ContainsKey(int.Parse(TextBoxId.Text)))
				{
					Update(int.Parse(TextBoxId.Text), TextBoxName.Text);
					Save("MalinStaffNames.csv");
					Close();
				}
				// if key does not exist
				else
				{
					ToolStripStatusLabel.Text = "User could not be found.";
				}
			}
			// delete an existing user
			else if (e.Alt && e.KeyCode == Keys.D)
			{
				// if key exists
				if (FormGeneral.MasterFile.ContainsKey(int.Parse(TextBoxId.Text)))
				{
					Delete(int.Parse(TextBoxId.Text));
					Save("MalinStaffNames.csv");
					Close();
				}
				// if key does not exist
				else
				{
					ToolStripStatusLabel.Text = "User could not be found.";
				}
			}
			// 5.7.	Create a method that will close the Admin GUI when the Alt + L keys are pressed.
			else if (e.Alt && e.KeyCode == Keys.L)
			{
				Close();
			}
		}
		#endregion

		#region Create, Update & Delete
		// 5.3.	Create a method that will create a new Staff ID and input the staff name from the related text box.
		// The new staff member must be added to the Dictionary data structure.
		private void Create(string name)
		{
			// if id has been generated via new user shortcut
			if (!string.IsNullOrEmpty(TextBoxId.Text))
			{
				FormGeneral.MasterFile.Add(int.Parse(TextBoxId.Text), name);
			}
			// if id needs to be generated
			else
			{
				FormGeneral.MasterFile.Add(UniqueId(), name);
			}
		}

		// 5.4.	Create a method that will Update the name of the current Staff ID.
		private void Update(int id, string name)
		{
			FormGeneral.MasterFile[id] = name;
		}

		// 5.5.	Create a method that will remove the current Staff ID.
		private void Delete(int id)
		{
			FormGeneral.MasterFile.Remove(id);
		}
		#endregion

		#region Unique ID
		// 5.3.	The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
		private int UniqueId()
		{
			// generate a random id
			Random random = new Random();
			int id = random.Next(770000000, 779999999);

			// continue to generate a random id until it is unique
			while (FormGeneral.MasterFile.ContainsKey(id))
			{
				id = random.Next(770000000, 779999999);
			}

			// return unique id
			return id;
		}
		#endregion

		#region Save
		// 5.6.	Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
		private void Save(string file)
		{
			try
			{
				// overwrite existing file with TextWriter
				using (var writer = File.CreateText(@file))
				{
					foreach (var kvp in FormGeneral.MasterFile)
					{
						// write kvp to new line with a comma delimiter
						writer.WriteLine($"{kvp.Key},{kvp.Value}");
					}
				}
			}
			catch (Exception ex)
			{
				ToolStripStatusLabel.Text = ex.Message;
			}
		}
		#endregion

		#region TextBox Display & KeyPress
		// 5.2.	Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
		private void DisplayTextBoxes(int id)
		{
			// if a new id is generated
			TextBoxId.Text = id.ToString();
		}

		private void DisplayTextBoxes(string id, string name)
		{
			// if id and name are passed
			TextBoxId.Text = id;
			TextBoxName.Text = name;
		}

		private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// allow letters, a single white space and backspaces
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
		#endregion
	}
}
