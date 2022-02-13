using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double M = 0;
		double N = 0;
		double T = 0;
		String op = "";
		bool clear = false;

		private void button1_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "7"; else textBox1.Text += "7";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "8"; else textBox1.Text += "8";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "9"; else textBox1.Text += "9";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "4"; else textBox1.Text += "4";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "5"; else textBox1.Text += "5";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "6"; else textBox1.Text += "6";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "1"; else textBox1.Text += "1";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "2"; else textBox1.Text += "2";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "3"; else textBox1.Text += "3";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (clear) textBox1.Text = "0"; else textBox1.Text += "0";
			clear = false;
			N = Double.Parse(textBox1.Text);
			textBox1.Text = N.ToString();
		}

		private void button22_Click(object sender, EventArgs e)
		{
			textBox1.Text = "0";
			N = 0;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			calc();
			T = Double.Parse(textBox1.Text);
			op = "+";
			clear = true;
		}

		private void calc()
		{
			switch (op) {
				case "+": N = add(T, N); break;
				case "-": N = sub(T, N); break;
				case "*": N = mul(T, N); break;
				case "/": N = div(T, N); break;
				case "^": N = pow(T, N); break;
				case "2": N = sqrt(T); break;
				case "!": N = fac(T); break;
				default: break;
			}
			textBox1.Text = N.ToString();
		}

		// Сложение
		public double add(double x, double y)
		{
			return x + y;
		}

		// Вычитание
		public double sub(double x, double y)
		{
			return x - y;
		}

		// Умножение
		public double mul(double x, double y)
		{
			return x * y;
		}

		// Деление
		public double div(double x, double y)
		{
			return x / y;
		}

		// Возведение в степень
		public double pow(double x, double y)
		{
			return Math.Pow(x, y);
		}

		// Извлечение квадратного корня
		public double sqrt(double x)
		{
			return Math.Sqrt(x);
		}

		// Факториал
		public double fac(double x)
		{
			double res = 1;
			for (int i = (int) x; i > 1; i--)
				res *= i;
			return res;
		}

		private void button23_Click(object sender, EventArgs e)
		{
			calc();
			op = "";
			clear = true;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			calc();
			T = Double.Parse(textBox1.Text);
			op = "-";
			clear = true;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			calc();
			T = Double.Parse(textBox1.Text);
			op = "*";
			clear = true;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			calc();
			T = Double.Parse(textBox1.Text);
			op = "/";
			clear = true;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			calc();
			T = Double.Parse(textBox1.Text);
			op = "^";
			clear = true;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			calc();
			T = Double.Parse(textBox1.Text);
			op = "2";
			calc();
			op = "";
			clear = true;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			calc();
			T = Double.Parse(textBox1.Text);
			op = "!";
			calc();
			op = "";
			clear = true;
		}

		// Добавление к числу в памяти
		public void addToMem(double x)
		{
			M += x;
		}

		// Чтение из памяти
		public double readMem()
		{
			return M;
		}

		// Сохранение числа в память
		public void saveToMem(double x)
		{
			M = x;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			addToMem(N);
		}

		private void button19_Click(object sender, EventArgs e)
		{
			addToMem(-N);
		}

		private void button20_Click(object sender, EventArgs e)
		{
			clear = false;
			N = readMem();
			textBox1.Text = M.ToString();
			clear = true;
		}

		private void button21_Click(object sender, EventArgs e)
		{
			saveToMem(0);
		}

		private void button24_Click(object sender, EventArgs e)
		{
			saveToMem(N);
		}
	}
}
