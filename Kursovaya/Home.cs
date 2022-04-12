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
			StartMenu openForm = new StartMenu();
			openForm.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Employee Form1 = new Employee();
			Form1.ShowDialog();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Questions Form1 = new Questions();
			Form1.ShowDialog();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Reviews Form1 = new Reviews();
			Form1.ShowDialog();
			this.Hide();
		}
	}
}
