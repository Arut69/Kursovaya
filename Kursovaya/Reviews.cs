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
			this.Hide();
			StartMenu openForm = new StartMenu();
			openForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("Заполните поле!");
			}
			else
			{
				MessageBox.Show(textBox1.Text, "Ваш отзыв принят");
				textBox1.Clear();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox2.TextLength == 0)
			{
				MessageBox.Show("Заполните поле!");
			}
			else
			{
				MessageBox.Show(textBox2.Text, "Ваш отзыв принят");
				textBox2.Clear();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox3.TextLength == 0)
			{
				MessageBox.Show("Заполните поле!");
			}
			else
			{
				MessageBox.Show(textBox3.Text, "Ваш отзыв принят");
				textBox3.Clear();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
	
		}

		private void Reviews_Load(object sender, EventArgs e)
		{

		}
	}
}
