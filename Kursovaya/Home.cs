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
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			StartMenu openForm = new StartMenu();
			openForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Employee Form1 = new Employee();
			Form1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Questions Form1 = new Questions();
			Form1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Reviews Form1 = new Reviews();
			Form1.ShowDialog();
		}
	}
}
