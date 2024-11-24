// The NoKeyUpCombo class derives a new ComboBox whose WndProc
// method is overridden. This is required to address issues when
// It is this derived combobox that is added to the datagrid.
// When you TAB trough the DataGrid and you reach the DropDown Combobox
// the Focus is immediately moved to the next Column. 
using System;

namespace Akadia.DataGridBoundCombo
{
	public class myComboBox: System.Windows.Forms.ComboBox
	{
		private const int WM_KEYUP = 0x101;

		// The WndProc method corresponds exactly to the Windows WindowProc function.
		// For more information about processing Windows messages, see the WindowProc
		// function documentation in the Windows Platform SDK reference located in 
		// the MSDN Library.
		protected override void WndProc(ref System.Windows.Forms.Message theMessage)
		{
			// Ignore KeyUp event to avoid problem with tabbing the dropdown.
			if (theMessage.Msg == WM_KEYUP) 
			{
				return;
			}
			else 
			{
				base.WndProc(ref theMessage);
			}
		}
	} 
}
