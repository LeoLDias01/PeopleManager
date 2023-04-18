using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleManager.Screens
{
	public partial class WorkSpace : Form
	{
		public WorkSpace()
		{
			InitializeComponent();
		}

		private void tsbDash_Click(object sender, EventArgs e)
		{
			FieldsActivation(notepad: true, appointment: false, dashboard: true);
		}

		private void FieldsActivation(bool notepad, bool appointment, bool dashboard)
		{
			pnlNotepad.Visible = notepad;
			pnlAppointment.Visible = appointment;
			tlpDashboard.Visible = dashboard;
		}

		private void tspAppointment_Click(object sender, EventArgs e)
		{
			FieldsActivation(notepad: false, appointment: true, dashboard: false);
		}

		private void WorkSpace_Load(object sender, EventArgs e)
		{
			FieldsActivation(notepad: true, appointment: false, dashboard: true);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
