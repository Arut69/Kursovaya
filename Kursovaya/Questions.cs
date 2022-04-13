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
	public partial class Questions : Form
	{
		public Questions()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			StartMenu openForm = new StartMenu();
			openForm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("89000694458");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("В главном меню перейдите в раздел-обращение к персоналу");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("В главном меню перейдите в раздел-отзывы");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Наш обслуживающий персонал работает с 8:00 до 21:00");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Обновления выходят еженедельно");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("На нашем официальном сайте вы можете просмотреть в каких учереждениях наш персонал получал образование");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Помочь материально вы можете при помощи онлайн переводов на карту-5228198916542389");
		}
	}
}
