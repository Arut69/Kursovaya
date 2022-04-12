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
	public partial class Reviews : Form
	{
		public Reviews()
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
			MessageBox.Show(textBox1.Text,"Ваш отзыв принят");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(textBox2.Text,"Ваш отзыв принят");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show(textBox3.Text,"Ваш отзыв принят");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
