namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//n ədəd var m dəfə bu ədədlərdən random seçirsən (n > 0 m >=0) bütün possible stateləri sadala

			int n;
			do
			{
				Console.Write("Numbers count: ");
			} while (!(int.TryParse(Console.ReadLine(), out n) && (n > 0)));

			int m;

			do
			{
				Console.Write("Numbers Lenght: ");
			} while (!(int.TryParse(Console.ReadLine(), out m) && (m >= 0)));

			var combinations = GetCombinations(Enumerable.Range(1, n), m);

			foreach (var combination in combinations)
			{
				Console.WriteLine(string.Join(",", combination));
			}
			

		}
		static IEnumerable<IEnumerable<int>> GetCombinations(IEnumerable<int> elements, int length)
		{
			if (length == 0)
				return new List<List<int>> { new List<int>() };

			return elements.SelectMany(e => GetCombinations(elements, length - 1).Select(c => (new List<int> { e }).Concat(c)));
		}
	}
}
