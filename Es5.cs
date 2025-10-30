using System;
					
public class Program
{
	public static int Namicizie (int n)
	{
		if (n == 2)
			return 1;
		else if (n < 2)
			return 0;
		else
		{
			return (n-1) + Namicizie(n-1);
		}
	}
	public static void Main()
	{
		Console.WriteLine(Namicizie(3));
	}
}
