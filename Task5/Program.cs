namespace Task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task 5: Array-dəki min və max ədədlərin cəmini tapan funksiya yaz

			int[] array = [2,4,5,6,8,90,31,6,547,337,2];
			
			int sum = 0;

			sum += array.Max() + array.Min();
            Console.WriteLine(sum);

        }
	}
}
