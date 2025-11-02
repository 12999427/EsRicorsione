using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Inserisci il numero di dischi: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSoluzione per {0} dischi:\n", n);

        //Hanoi è 2^(n) -1
        
        Console.WriteLine($"\nNumero minimo di mosse: {Hanoi1(n)} o {Hanoi2(n)}");
    }

    static int Hanoi1(int n)
    {
        if (n == 1)
            return 1;
        else
            return ((Hanoi1(n-1) +1) * 2) -1;
    }
    
    static int Hanoi2(int n)
    {
        return (Pow2(n) -1);
    }
    
    static int Pow2(int n)
    {
        if (n == 0)
            return 1;
            
        return 2*Pow2(n-1);
    }
}
