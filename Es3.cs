using System;
					
public class Program
{
	public static int PossibilitaLunghezza (int l)
	{
		if (l <= 1)
			return 1;
		else
		{
			return (PossibilitaLunghezza (l-1) + PossibilitaLunghezza (l-2));
		}
	}
	public static void Main()
	{
		Console.WriteLine(PossibilitaLunghezza(10));
	}
}
