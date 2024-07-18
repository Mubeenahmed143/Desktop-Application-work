using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__dot_net_class
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random guess = new Random();

			int number = Convert.ToInt32(guess.Next(0, 20));
			Console.WriteLine(number);

			int num = Convert.ToInt32(textBox1.Text);

			if (num == number)
			{
				label1.Text = "You won";
				MessageBox.Show("Awesome!");
			}
			else
			{
				label1.Text = "Sorry you lost!";
			}
		}
	}
}
