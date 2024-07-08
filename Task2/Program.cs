namespace Task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task 2: Kart nömrəsinin etibarlılığının yoxlanılması.
			//Yeni 16 reqemli Card nomresi olur onu yoxlamaq lazimdirki bu heqiqeten Kart nömresi ola bilermi ola bilmezmi (LUHN alqoritmi)
		
			long cardNums;

			if (long.TryParse(Console.ReadLine(), out cardNums))
			{
				bool isValid = IsValidCard(cardNums);
				Console.WriteLine($"Card number is valid: {isValid}");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Invalid input. Please enter a valid card number.");
				Console.ResetColor();
				
			}
			
	
		}
		public static bool IsValidCard(long cardNums)
		{
			char[] card = cardNums.ToString().ToArray();
			int digitsSum = 0;
			if (card.Length != 16)
				return false;
			for (int i = card.Length - 2; i >= 0; --i)
			{
				int currentDigit = card[i] - '0';
				if (i % 2 == 0)// cüt
				{
					if (currentDigit > 4)
					{
						digitsSum += currentDigit * 2 - 9;
					}
					else
					{
						digitsSum += currentDigit * 2;
					}
				}
				else//tek
				{
					digitsSum += currentDigit;
				}
			}
			digitsSum = digitsSum + card.Last() - '0';
			return digitsSum % 10 == 0;
		}
	}
}
