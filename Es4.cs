using System;
					
public class Program
{
	public static int PossibilitaLunghezza (int l)
	{
		if (l <= 1)
			return 1;
		else
		{
			int sommaQuantePossibilita = 1;
			for (int i = 1; i<l; i++)
				sommaQuantePossibilita += PossibilitaLunghezza (l-i);
			
			return sommaQuantePossibilita;
		}
	}
	public static void Main()
	{
		Console.WriteLine(PossibilitaLunghezza(3));
	}
}
