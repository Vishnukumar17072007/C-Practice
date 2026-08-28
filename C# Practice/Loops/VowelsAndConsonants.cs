using System;

namespace C__Practice.Loops
{
	public class VowelsAndConsonants
	{
		public AssignVowelsAndConsonants count(string str)
		{
			int vowels = 0;
			int consonants = 0;
			foreach (char c in str)
			{
				if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' )
				{
					vowels++;
				}
				else
				{
					consonants++;
				}
			}
			return new AssignVowelsAndConsonants { Vowels = vowels, Consonants = consonants};

        }
	}

	public class AssignVowelsAndConsonants
	{
		public int Vowels { get; set; }
		public int Consonants { get; set; }
	}
}
