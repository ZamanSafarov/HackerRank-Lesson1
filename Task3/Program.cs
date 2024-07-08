namespace Task3
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			//Task 3:Fibbonoci tapilmasi
			int n = 10;

			for (int i = 0; i < n; i++)
			{
				Console.Write(Fibonacci(i) + " ");
			}
			Console.WriteLine();
		}

		static int Fibonacci(int n)
		{
			if (n <= 1)
				return n;
			else
				return Fibonacci(n - 1) + Fibonacci(n - 2);
		}
	}
}
