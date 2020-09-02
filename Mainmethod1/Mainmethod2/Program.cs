using System; 

public class Mainmethod2
{

	// Overloaded main method 1 
	public static void Main(Boolean args)
	{
		if (args)
		{
			Console.WriteLine("main() overloaded"
							+ " method 1 Executing");

			Console.WriteLine(args);
		

		}
	}

	// Overloaded main method 2 
	public static void Main(String a, String b)
	{
		Console.WriteLine("main() overloaded"
						+ " method 2 Executing");
		Console.WriteLine(a + " " + b);
	}

	// Overloaded main method 3 
	public static void Main(int args)
	{
		Console.WriteLine("main() overloaded"
						+ " method 3 Executing");
		Console.WriteLine(args);
	}

	// Original main() 
	public static void Main(String[] args)
	{
		Console.WriteLine("Original main()"
						+ " Executing");
		Console.WriteLine("Hello");



		// Calling overloaded methods
		Mainmethod2.Main(true);
		Mainmethod2.Main("Geeks", "For Geeks");

		Mainmethod2.Main(987654);
	}
}
