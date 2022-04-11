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
			Login Form1 = new Login();
			Form1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Home Form1 = new Home();
			Form1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
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
	}
}
