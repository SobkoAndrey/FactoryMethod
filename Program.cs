using System;

namespace FactoryMethod
{
	class TestClass
	{
		int a, b;

		static public TestClass Factory(int a, int b)
		{
			TestClass instance = new TestClass();

			instance.a = a;
			instance.b = b;

			return instance;
		}

		public void Show()
		{
			Console.WriteLine("Hi! I am new instance of TestClass. My values is: {0} and {1}", a, b);
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			int i, j;

			for (i = 0, j = 10; i < 10; i += 1, j -= 1)
			{
				TestClass instance = TestClass.Factory(b: j, a: i);

				instance.Show();
			}

			Console.ReadLine();
		}
	}
}
