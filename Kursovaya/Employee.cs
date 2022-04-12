using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
	public partial class Employee : Form
	{
		public Employee()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			StartMenu openForm = new StartMenu();
			openForm.Show();
			this.Hide();
		}
	}
}
