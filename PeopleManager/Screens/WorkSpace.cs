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



		private void WorkSpace_Load(object sender, EventArgs e)
		{
			
		}



		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnExit_Click_1(object sender, EventArgs e)
		{
			if(MessageBox.Show("Deseja encerrar toda a aplicação?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
			else
			{
				this.Close();
				new Login().ShowDialog();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void btnCompany_Click(object sender, EventArgs e)
		{
			new Company().ShowDialog();
		}
	}
}
