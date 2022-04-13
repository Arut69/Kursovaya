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
				MessageBox.Show(textBox1.Text, "Персонал Антон принял ваш ответ в обработку, ожидайте ответ в ближайшее время");
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
				MessageBox.Show(textBox2.Text, "Персонал Виктор принял ваш ответ в обработку, ожидайте ответ в ближайшее время");
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
				MessageBox.Show(textBox3.Text, "Персонал Семен принял ваш ответ в обработку, ожидайте ответ в ближайшее время");
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		
		}
	}
}
