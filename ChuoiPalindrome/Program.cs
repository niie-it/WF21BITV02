using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuoiPalindrome
{
	internal class Program
	{
		/// <summary>
		/// Check input string is Palindrome or not.
		/// </summary>
		/// <param name="input">string need to check</param>
		/// <returns>true: if input is Palindrome, otherwise false</returns>
		static bool IsPalindrome(string input)
		{
			var length = input.Length;
			for (int i = 0; i < length / 2; i++)
			{
				if (input[i] != input[length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}

		static bool CheckPalindrome(string input) => input == input.Reverse().ToString();

		static void Main(string[] args)
		{
			Console.WriteLine(IsPalindrome("101"));
		}
	}
}
