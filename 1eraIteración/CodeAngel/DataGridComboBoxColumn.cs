// How do I add databound comboboxes to the WinForms DataGrid?
// This page includes a C# sample that displays a DataGrid
// containing 3 regular textbox columns and 1 column containing
// databound ComboBoxes.
//
// To use databound comboboxes in the datagrid the sample derives a
// new datagrid column style from the DataGridTextBoxColumn class and
// adds overrides for the SetColumnValueAtRow, GetColumnValueAtRow,
// Edit, Commit and ConcedeFocus methods. This is performed in the
// DataGridComboBoxColumn class. 
//
// The Edit event is raised when the user sets the focus to the cell
// containing the combobox. In this event the dimensions of the combobox
// are set and an event handler is assigned to handle scrolling of the combobox.
//
// When a value is changed in the combobox and you leave the grid cell
// the new value must update the corresponding value in the bound data
// source. This requires tracking when the user starts to edit the combobox
// value and then commiting the changes to the data source.
// Hence the override to the Edit and Commit events.
//
// A second NoKeyUpCombo class derives a new ComboBox whose WndProc
// method is overridden. This is required to address issues when
// TAB-bing through the grid so as not to leave focus on the combobox.
// It is this derived combobox that is added to the datagrid. 
//
// While there are a number of methods that you must think about,
// the code is not complicated.
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//
// Derive a custom column style from DataGridTextBoxColumn that:
//  - adds a ComboBox member
//  - tracks when the combobox has focus in the Enter and Leave events
//  - overrides Edit event so the ComboBox replaces the TextBox
//  - overrides Commit event to save the changed data
//
namespace Akadia.DataGridBoundCombo
{
	public class DataGridComboBoxColumn : DataGridTextBoxColumn
	{
		public myComboBox myComboBox;
		private System.Windows.Forms.CurrencyManager _currencyManager;
		private int _rowNum;
		private bool _Editing;

		// Constructor, create our own customized Combobox
		public DataGridComboBoxColumn()
		{
			_currencyManager = null;
			_Editing = false;

			// Create our own customized Combobox, which is used in the DataGrid
			// DropDownList: The user cannot directly edit the text portion.
			//               The user must click the arrow button to display the
			//               list portion.
			//     DropDown: The text portion is editable. The user must click 
			//               the arrow button to display the list portion.
			//       Simple: The text portion is editable. The list portion is
			//               always visible.
			myComboBox = new myComboBox();
			myComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			// My own Combobox subscribes to the Leave Event. It occurs when the
			// input focus leaves the ComboBox.
			this.myComboBox.Leave += 
				new System.EventHandler(LeaveComboBox);

			// My own Combobox subscribes to the SelectionChangeCommitted Event.
			// It occurs when the selected item has changed and that change
			// is committed (save the changed data to the DataGrid TextBox).
			this.myComboBox.SelectionChangeCommitted += 
				new System.EventHandler(SelectionChangeCommit);
		}

		// Make current Combobox invisible when user scrolls
		// the DataGrid control using the ScrollBar.
		private void HandleScroll(Object sender, EventArgs e)
		{
			if (myComboBox.Visible) 
			{
				myComboBox.Hide();
			}
		}
	
		// The ColumnStartedEditing method allows the DataGrid
		// to show a pencil in the row header indicating the row
		// is being edited. (base is the parent DataGridTextBoxColumn)
		private void SelectionChangeCommit(Object sender, EventArgs e)
		{
			_Editing = true;
			base.ColumnStartedEditing((System.Windows.Forms.Control) sender);
		}

		// Handle Combobox Behaviour when Focus leaves the Combobox.
		private void LeaveComboBox(Object sender, EventArgs e)
		{
			if (_Editing)
			{
				// Set the Combobox ValueMember to the current RowColumn
				// when the Focus leaves the Combobox.
				SetColumnValueAtRow(_currencyManager, _rowNum, myComboBox.Text);
				_Editing = false;

				// Redraws the column 
				Invalidate();
			}
			// Hide the current Combobox when Focus on Combobox is loosen
			myComboBox.Hide();

			// Let current Combobox visible when user scrolls
			// the DataGrid control using the ScrollBar.
			this.DataGridTableStyle.DataGrid.Scroll += new System.EventHandler(HandleScroll);
		}

		// The SetColumnValueAtRow method updates the bound
		// DataTable "Titles" with the ValueMember
		// for a given DisplayMember = myComboBox.Text from the Combobox.
		protected override void SetColumnValueAtRow (CurrencyManager source, int rowNum, Object value)
		{
			Object tbDisplay = value;
			DataView dv = (DataView)this.myComboBox.DataSource;
			int rowCount = dv.Count;
			int i  = 0;
			Object cbDisplay;
			Object cbValue;

			// Loop through the Combobox DisplayMember values
			// until you find the selected value, then read the
			// ValueMember from the Combobox and update it in the
			// DataTable "Titles"
			while (i < rowCount)
			{
				cbDisplay = dv[i][this.myComboBox.DisplayMember];

				if ((cbDisplay != DBNull.Value) &&
					(tbDisplay.Equals(cbDisplay)))
				{
					break;
				}
				i += 1;
			}
			if (i < rowCount)
			{
				cbValue = dv[i][this.myComboBox.ValueMember];
			}
			else
			{
				cbValue = DBNull.Value;
			}
			base.SetColumnValueAtRow(source, rowNum, cbValue);
		}		

		// The GetColumnValueAtRow method updates the bound
		// Combobox with the DisplayMember
		// for a given Row Number = rowNum from the DataTable "Titles".
		protected override Object GetColumnValueAtRow(CurrencyManager source, int rowNum)
		{
			// Get the ValueMember from the DataTable "Titles"
			Object tbValue = base.GetColumnValueAtRow(source, rowNum);

			// Associate a DataView to the Combox, so we can search
			// the DisplayMember in the Combox corresponding to the
			// ValueMember from the DataTable "Titles"
			DataView dv = (DataView)this.myComboBox.DataSource;
			int rowCount = dv.Count;
			int i = 0;
			Object cbValue;

			// Loop through the Combox Entries and search the DisplayMember
			while (i < rowCount)
			{
				cbValue = dv[i][this.myComboBox.ValueMember];
				if ((cbValue != DBNull.Value) &&
					(tbValue != DBNull.Value) &&
					(tbValue.Equals(cbValue)))
				{
					break; // We found the DisplayMember - exit the Loop
				}
				i += 1;
			}

			// If we are within the Combox Entries, return now the DisplayMember
			// for the found ValueMember above. If we are at the End of the Combox
			// Entries, return NULL
			if (i < rowCount)
			{
				return dv[i][this.myComboBox.DisplayMember];
			}
			else
			{
				return DBNull.Value;
			}
		}

		// The Edit event is raised when the user sets the focus to the cell
		// containing the combobox. In this event the dimensions of the combobox
		// are set and an event handler is assigned to handle scrolling of the combobox.
		protected override void Edit(
			CurrencyManager source,
			int rowNum,
			Rectangle bounds,
			bool readOnly, 
			string instantText, 
			bool cellIsVisible)
		{
			base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible);

			// Set current Rownum and Postion Manager
			_rowNum = rowNum;
			_currencyManager = source;

			// Calculate Location of the Combox relative to the TextBox
			// of the DataGrid which have the Focus
			Point NewLoc;
			NewLoc = this.TextBox.Location;
			NewLoc.X -= 3;
			NewLoc.Y -= 3;
			myComboBox.Location = NewLoc;

			// Attach the Combobox to the same Parent Control
			// as the TextBox of the DataGrid
			myComboBox.Parent = this.TextBox.Parent;

			// Position the Combox at the same Location as the TextBox
			myComboBox.Size = new Size(this.TextBox.Size.Width + 3, myComboBox.Size.Height);

			// Select the Entry in the Combobox corresponding to the Text in
			// in the TextBox. 
			myComboBox.SelectedIndex = myComboBox.FindStringExact(this.TextBox.Text);
			// myComboBox.Text = this.TextBox.Text;

			// Make the TextBox invisible and then show the Combobox
			this.TextBox.Visible = false;
			myComboBox.Visible = true;
			myComboBox.BringToFront();
			myComboBox.Focus();

			// Make Combobox invisible id User scrolls uo or down the DataGrid
			this.DataGridTableStyle.DataGrid.Scroll += new System.EventHandler(HandleScroll);
		}

		// The Commit method can be used to put the Combomox ValueMember
		// into the TextBox ValueMember. This can be handled in the 
		// LeaveComboBox EventHandler as well.
		protected override bool Commit(
			System.Windows.Forms.CurrencyManager dataSource,int rowNum) 
		{
			if (_Editing)
			{
				_Editing = false;
				SetColumnValueAtRow(dataSource, rowNum, myComboBox.Text);
			}
			return true;
		}
	}
} 
