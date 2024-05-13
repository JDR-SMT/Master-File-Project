using System;
using System.IO;
using System.Windows.Forms;

namespace Dictionary
{
	public partial class FormAdmin : Form
	{
		// 5.2.	Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
		public FormAdmin(string id, string name)
		{
			InitializeComponent();
			Cursor.Hide();

			TextBoxInputId.Text = id;
			TextBoxInputName.Text = name;
		}

		#region Form KeyDown
		private void FormAdmin_KeyDown(object sender, KeyEventArgs e)
		{
			// create a new user
			if (e.Alt && e.KeyCode == Keys.C)
			{
				// if name is null or empty
				if (string.IsNullOrEmpty(TextBoxInputName.Text))
				{
					ToolStripStatusLabel.Text = "User was not added. Please enter a name.";
				}
				else
				{
					Create(TextBoxInputName.Text);
					ToolStripStatusLabel.Text = "User added.";
				}
			}
			// update an existing user
			else if (e.Alt && e.KeyCode == Keys.U)
			{
				// if key does not exist
				if (!FormGeneral.MasterFile.ContainsKey(int.Parse(TextBoxInputId.Text)))
				{
					ToolStripStatusLabel.Text = "User was not deleted. Please enter an existing ID.";
				}
				else
				{
					Update(int.Parse(TextBoxInputId.Text), TextBoxInputName.Text);
					ToolStripStatusLabel.Text = "User updated.";
				}
			}
			// delete an existing user
			else if (e.Alt && e.KeyCode == Keys.D)
			{
				// if key does not exist
				if (!FormGeneral.MasterFile.ContainsKey(int.Parse(TextBoxInputId.Text)))
				{
					ToolStripStatusLabel.Text = "User was not deleted. Please enter an existing ID.";
				}
				else
				{
					Delete(int.Parse(TextBoxInputId.Text));
					Clear();
					ToolStripStatusLabel.Text = "User deleted.";
				}
			}
			// 5.7.	Create a method that will close the Admin GUI when the Alt + L keys are pressed.
			else if (e.Alt && e.KeyCode == Keys.L)
			{
				Save("MalinStaffNamesV3.csv");
				Close();
			}
		}
		#endregion

		#region Create, Update & Delete
		// 5.3.	Create a method that will create a new Staff ID and input the staff name from the related text box.
		// The new staff member must be added to the Dictionary data structure.
		private void Create(string name)
		{
			FormGeneral.MasterFile.Add(UniqueId(), name);
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
				// overwrite existing file
				using (var writer = new StreamWriter(@file, false))
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

		#region TextBoxName KeyPress
		private void TextBoxInputName_KeyPress(object sender, KeyPressEventArgs e)
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

		#region Clear
		// 5.5.	Clear the text boxes.
		private void Clear()
		{
			TextBoxInputId.Clear();
			TextBoxInputName.Clear();
		}
		#endregion
	}
}
