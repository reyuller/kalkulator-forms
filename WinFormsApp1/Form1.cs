using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a, b;
			if (!int.TryParse(textBox1.Text, out a) ||
				!int.TryParse(textBox2.Text, out b))
			{
				MessageBox.Show("Wpisz dwie liczby całkowite");
				return;
			}
			int wynik = a + b;
			label4.Text = wynik.ToString();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			int a, b;
			if (!int.TryParse(textBox1.Text, out a) ||
				!int.TryParse(textBox2.Text, out b))
			{
				MessageBox.Show("Wpisz dwie liczby całkowite");
				return;
			}
			int wynik = a * b;
			label4.Text = wynik.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int a, b;
			if (!int.TryParse(textBox1.Text, out a) ||
				!int.TryParse(textBox2.Text, out b))
			{
				MessageBox.Show("Wpisz dwie liczby całkowite");
				return;
			}
			int wynik = a - b;
			label4.Text = wynik.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			double a, b;
			if (!double.TryParse(textBox1.Text, out a) ||
				!double.TryParse(textBox2.Text, out b))
			{
				MessageBox.Show("Wpisz dwie liczby całkowite");
				return;
			}
			if (b == 0)
			{
				MessageBox.Show("Nie można dzielić przez zero");
				return;
			}
			double wynik = a / b;
			label4.Text = wynik.ToString();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
