using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kursovaya
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		private MySqlConnection conn;
		private string connStr = ("server=chuc.caseum.ru;port=33333;user=st_1_19_14;database=is_1_19_14_KURS;password=55389811;");
		private MySqlDataAdapter MyDA = new MySqlDataAdapter();
		private BindingSource bSource = new BindingSource();
		private DataSet ds = new DataSet();
		private DataTable table = new DataTable();

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_19_14;" + "database=is_1_19_14_KURS;password=55389811;";
			conn = new MySqlConnection(connStr);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "Persona" && textBox2.Text == "persona123")
			{
				this.Hide();
				StartMenu Form2 = new StartMenu();
				Form2.ShowDialog();
			}
			else
			{
				MessageBox.Show("Адрес пользователя или пароль введены неправильно, попробуйте еще раз");
				textBox1.Clear();
				textBox2.Clear();
				textBox1.Focus();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox1.Focus();
		}
	}
}
