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
			Reviews openForm = new Reviews();
			openForm.Show();
			this.Hide();
		}
	}
}
