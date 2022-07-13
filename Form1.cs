using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3._4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string fileName = textBox2.Text;
			if (File.Exists(fileName))
			{
				string redFile = File.ReadAllText(fileName);
				textBox1.Text = redFile;
			}
			else {
				MessageBox.Show("Taki plik nie istnieje");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string fileName = textBox2.Text;
			string saveText=textBox1.Text;
			if (File.Exists(fileName))
			{
				const string message =
				"Czy chcesz nadpisać ten plik";
				const string caption = "Zmiany";
				var result = MessageBox.Show(message, caption,
											 MessageBoxButtons.YesNo,
											 MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					
					File.WriteAllText(fileName, saveText);
				}

				
			}
			else {
				MessageBox.Show("Taki plik nie istnieje");
				
			}
		}
	}
}
