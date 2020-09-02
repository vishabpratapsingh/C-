 
using System;

class GFG
{

	
	static void halfDiamondStar(int N)
	{
		int i, j;

		
		for (i = 0; i < N; i++)
		{
			for (j = 0; j < i + 1; j++)
				Console.Write("*");
			Console.Write("\n");
		}

		 
		for (i = 1; i < N; i++)
		{
			for (j = i; j < N; j++)
				Console.Write("*");
			Console.Write("\n");
		}
	}

	
	public static void Main(String[] args)
	{
		int N = 5;

	
		halfDiamondStar(N);
	}
}
 
