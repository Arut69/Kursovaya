using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kursovaya
{
	public partial class StartMenu : Form
	{
		public StartMenu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login Form1 = new Login();
			Form1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home Form1 = new Home();
			Form1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Employee Form1 = new Employee();
			Form1.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void StartMenu_Load(object sender, EventArgs e)
		{
		
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Questions Form1 = new Questions();
			Form1.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Reviews Form1 = new Reviews();
			Form1.ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
