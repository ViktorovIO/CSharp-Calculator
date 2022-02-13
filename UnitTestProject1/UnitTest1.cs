using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		// Модульный тест сложения
		[TestMethod]
		public void TestAdd()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			double x = form.add(1, 2);
			Assert.AreEqual(x, 3);
		}

		// Модульный тест вычитания
		[TestMethod]
		public void TestSub()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			double x = form.sub(3, 1);
			Assert.AreEqual(x, 2);
		}

		// Модульный тест умножения
		[TestMethod]
		public void TestMul()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			double x = form.mul(3, 2);
			Assert.AreEqual(x, 6);
		}

		// Модульный тест деления
		[TestMethod]
		public void TestDiv()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			double x = form.div(6, 2);
			Assert.AreEqual(x, 3);
		}

		// Модульный тест возведения в степень
		[TestMethod]
		public void TestPow()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			double x = form.pow(2, 3);
			Assert.AreEqual(x, 8);
		}

		// Модульный тест квадратного корня
		[TestMethod]
		public void TestSqrt()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			double x = form.sqrt(4);
			Assert.AreEqual(x, 2);
		}

		// Модульный тест факториала
		[TestMethod]
		public void TestFac()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			double x = form.fac(4);
			Assert.AreEqual(x, 24);
		}

		// Модульный тест операций с памятью
		[TestMethod]
		public void TestMem()
		{
			Calculator1.Form1 form = new Calculator1.Form1();
			form.saveToMem(1);
			double x = form.readMem();
			Assert.AreEqual(x, 1);
			form.addToMem(2);
			x = form.readMem();
			Assert.AreEqual(x, 3);
		}
	}
}
