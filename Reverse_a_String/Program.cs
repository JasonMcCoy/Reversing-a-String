using System;

class Program
{
	public static string reverseTheString(string myString)
	{
		//reverse the string
		char[] originalStringArray = myString.ToCharArray();
		Array.Reverse(originalStringArray);
		string reversedString = new string(originalStringArray);
		Console.WriteLine($"The string reversed is: {reversedString}");

		return reversedString;
	}

	static void Main(string[] args)
	{
		Console.Write("Please enter a string to reverse: ");
		var originalString = Console.ReadLine();

		if (String.IsNullOrEmpty(originalString))
		{
			Console.WriteLine("You did not enter a string.");

			Console.Write("Please enter a string to reverse again: ");
			originalString = Console.ReadLine();


			//reverse the string
	        reverseTheString(originalString);

			Console.ReadLine();
		}
		else
		{
			//reverse the string
			reverseTheString(originalString);

			Console.ReadLine();
		}

	}

}
