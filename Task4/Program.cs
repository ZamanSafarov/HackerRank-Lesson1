namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*"Bigger is Greater" bir setir melumat daxil edirsiz simvolları çeşidləməklə növbəti leksikoqrafik cəhətdən daha böyük permutasiyanın tapın.*/
			string input = "ba"; // nümunə girişi
			string result = BiggerIsGreater(input);
			Console.WriteLine(result);
		}

		static string BiggerIsGreater(string w)
		{
			var result ="";
			char[] chars = w.ToCharArray();
			int n = w.Length;

			var i = n - 2;
			while (i >= 0 && chars[i] >= chars[i+1]) 
			{
				i--;
			}
			if (i< 0)
			{
				result = "the input word is the Biggest and greatest";
			}
			else
			{
				var j = n-1;
				while (j>=i && chars[j] <= chars[i])
				{
					j--;
				}

				Swap(chars,i,j);
				result = new string(chars);

			}

			return result;
		}

		static void Swap(char[] chars, int i, int j)
		{
			char temp = chars[i];
			chars[i] = chars[j];
			chars[j] = temp;

		}
	}
}
