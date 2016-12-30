using System;

class Program
{

	public void reverseTheString()
	{
		//reverse the string
		char[] originalStringArray = originalString.ToCharArray();
		Array.Reverse(originalStringArray);
		string reversedString = new string(originalStringArray);
		Console.WriteLine($"The string reversed is: {reversedString}");
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
			char[] originalStringArray = originalString.ToCharArray();
			Array.Reverse(originalStringArray);
			string reversedString = new string(originalStringArray);
			Console.WriteLine($"The string reversed is: {reversedString}");

			Console.ReadLine();
		}
		else
		{
			//reverse the string
			char[] originalStringArray = originalString.ToCharArray();
			Array.Reverse(originalStringArray);
			string reversedString = new string(originalStringArray);
			Console.WriteLine($"The string reversed is: {reversedString}");

			Console.ReadLine();
		}

	}

}
