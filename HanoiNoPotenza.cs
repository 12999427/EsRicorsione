using System;
using static System.Console;
					
public class Program
{
	public static void Main()
	{
		for (int numDischi = 1; numDischi<12; numDischi++)
		{
			WriteLine($">> Con {numDischi} il num minimo è {Hanoi(numDischi, 'A', 'B', 'C')}");
		}
	}
	
	public static int Hanoi(int numDischi, char DA, char A, char ALTRO)
	{
		if (numDischi < 1)
			throw new Exception();
		
		if (numDischi == 1)
		{
			WriteLine($"Spostato disco da {DA} a {A}");
			return 1;
		}
		else
		{
			int numMinimoMosse = 0;
			numMinimoMosse += Hanoi(numDischi-1, DA, ALTRO, A);
			numMinimoMosse += Hanoi(1, DA, A, ALTRO);
			numMinimoMosse += Hanoi(numDischi-1, ALTRO, A, DA);
			return numMinimoMosse;
		}
	}
}
