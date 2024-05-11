using System;
using System.Windows.Forms;

namespace Dictionary
{
	public partial class FormAdmin : Form
	{
		public FormAdmin()
		{
			InitializeComponent();
			Cursor.Hide();
		}

		#region Form Load & KeyDown
		// 5.2.	Create a method that will receive the Staff ID from the General GUI and then populate text boxes
		// with the related data. 
		private void FormAdmin_Load(object sender, System.EventArgs e)
		{
			FormGeneral formGeneral = (FormGeneral)Application.OpenForms["FormGeneral"];
			TextBoxInputId.Text = formGeneral.TextBoxOutputId.Text;
			TextBoxInputName.Text = formGeneral.TextBoxOutputName.Text;
		}

		private void FormAdmin_KeyDown(object sender, KeyEventArgs e)
		{
			// create a new user
			if (e.Alt && e.KeyCode == Keys.C)
			{
				Create(TextBoxInputName.Text);
				ToolStripStatusLabel.Text = "User added.";
			}
			// update an existing user
			else if (e.Alt && e.KeyCode == Keys.U)
			{
				Update(int.Parse(TextBoxInputId.Text), TextBoxInputName.Text);
				ToolStripStatusLabel.Text = "User updated.";
			}
			// delete an existing user
			else if (e.Alt && e.KeyCode == Keys.D)
			{
				Delete(int.Parse(TextBoxInputId.Text));
				ToolStripStatusLabel.Text = "User deleted.";
			}
			// 5.7.	Create a method that will close the Admin GUI when the Alt + L keys are pressed.
			else if (e.Alt && e.KeyCode == Keys.L)
			{
				Close();
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

		#region Create, Update & Delete
		// 5.3.	Create a method that will create a new Staff ID and input the staff name from the related text box.
		// The new staff member must be added to the Dictionary data structure.
		private void Create(string name)
		{
			FormGeneral.MasterFile.Add(Random(), name);
		}

		// 5.4.	Create a method that will Update the name of the current Staff ID.
		private void Update(int id, string name)
		{
			FormGeneral.MasterFile[id] = name;
		}

		// 5.5.	Create a method that will remove the current Staff ID and clear the text boxes.
		private void Delete(int id)
		{
			FormGeneral.MasterFile.Remove(id);
		}
		#endregion

		#region Random ID
		// 5.3.	The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
		private int Random()
		{
			// generate a random id
			Random random = new Random();
			int id = random.Next(770000000, 779999999);

			// continue to generate a random id until it is unique
			while (FormGeneral.MasterFile.ContainsKey(id))
			{
				id = random.Next(770000000, 779999999);
			}

			return id;
		}
		#endregion
	}
}
