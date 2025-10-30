using System;
					
public class Program
{
	public static int PossibilitaLunghezzaMio (int l)
	{
		if (l <= 1)
			return 1;
		else
		{
			int sommaQuantePossibilita = 1;
			for (int i = 1; i<l; i++)
				sommaQuantePossibilita += PossibilitaLunghezzaMio (l-i);
			
			return sommaQuantePossibilita;
		}
	}
	
	public static int PossibilitaLunghezzaBalan (int l)
	{
		if (l == 1)
			return 1;
		else
		{
			return PossibilitaLunghezzaBalan(l-1) + l-1;
		}
	}
	
	public static int PossibilitaLunghezzaChat (int N)
	{
        if (N == 0)
            return 1; // caso base
        
        int totale = 0;
        for (int k = 1; k <= N; k++)
        {
            totale += PossibilitaLunghezzaChat(N - k);
        }
        return totale;
    }
	
	
	public static void Main()
	{
	    for (int i = 1; i<100; i++)
	    {
	        Console.WriteLine(i + " => " + PossibilitaLunghezzaMio(i) + " | " + PossibilitaLunghezzaChat(i) + " | " + PossibilitaLunghezzaBalan(i));    
	    }
		
	}
}
