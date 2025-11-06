using System;

class Program {
    static void Main() 
    {
        Console.WriteLine("=== Test Funzioni Ricorsive ===\n");
        
        // 1️⃣ Potenza
        Console.WriteLine("Potenza:");
        for (int i = 1; i <= 5; i++)
            Console.WriteLine($"2^{i} = {Potenza(2, i)}");
        Console.WriteLine();
        
        // 2️⃣ SommaCifre
        Console.WriteLine("SommaCifre:");
        int[] numeri = {5, 12, 543, 9999};
        foreach (int n in numeri)
            Console.WriteLine($"Somma cifre di {n} = {SommaCifre(n)}");
        Console.WriteLine();
        
        // 3️⃣ ContaVocali
        Console.WriteLine("ContaVocali:");
        string[] parole = {"ciao", "programma", "xyz", "AEIOU"};
        foreach (string s in parole)
            Console.WriteLine($"\"{s}\" -> {ContaVocali(s, 0, s.Length-1)} vocali");
        Console.WriteLine();
        
        // 4️⃣ ModiSalireScale12Passi
        Console.WriteLine("ModiSalireScale12Passi:");
        for (int n = 1; n <= 6; n++)
            Console.WriteLine($"{n} gradini -> {ModiSalireScale12Passi(n)} modi");
        Console.WriteLine();
        
        // 5️⃣ InvertiStringa
        Console.WriteLine("InvertiStringa:");
        string[] frasi = {"ciao", "treno", "abcd"};
        foreach (string s in frasi)
        {
            char[] arr = s.ToCharArray();
            InvertiStringa(arr, 0, arr.Length - 1);
            Console.WriteLine($"{s} -> {new string(arr)}");
        }
        Console.WriteLine();
        
        // 6️⃣ PercorsiGriglia
        Console.WriteLine("PercorsiGriglia:");
        for (int w = 1; w <= 4; w++)
        {
            for (int h = 1; h <= 4; h++)
                Console.Write($"{PercorsiGriglia(w, h)}\t");
            Console.WriteLine();
        }
        Console.WriteLine();
        
        // 7️⃣ HannoiMosse
        Console.WriteLine("HannoiMosse:");
        for (int n = 1; n <= 6; n++)
            Console.WriteLine($"{n} dischi -> {HannoiMosse(n)} mosse");
        
        Console.WriteLine("\n=== Fine Test ===");
    }
	
	static int Potenza (int Base, int Esponente)
	{
	    if (Esponente == 1)
	        return Base;
	    
	    return Base * Potenza(Base, Esponente - 1);
	}
	
	static int SommaCifre (int Numero)
	{
	    if (Numero < 10)
	        return Numero;
	        
	    return Numero % 10 + SommaCifre(Numero/10);
	}
	
	static int ContaVocali (string Stringa, int startIndex, int endIndex)
	{
	    if (startIndex > endIndex)
	        return 0;
	        
	    if (startIndex == endIndex)
        {
    	    char c = Stringa.ToLower()[startIndex];
    	    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    	        return 1;
    	    else
    	        return 0;
        }
        
        return ContaVocali(Stringa, startIndex, (startIndex+endIndex)/2) + ContaVocali(Stringa, (startIndex+endIndex)/2 +1, endIndex);
	}
	
	static int ModiSalireScale12Passi (int NGradini)
	{
	    if (NGradini <= 2)
	        return 1;
	    
	    return ModiSalireScale12Passi(NGradini -1) + ModiSalireScale12Passi(NGradini -2);
	}
	
	static void InvertiStringa (char[] array, int start, int end)
	{
	    if (start >= end)
	        return;
	      
        char t = array[start];
	    array[start] = array[end];
	    array[end] = t;
	    
	    InvertiStringa(array, start+1, end-1);
	}
	
	static int PercorsiGriglia (int width, int height)
	{
	    if (width == 1 && height == 1)
	        return 1;
	        
	    if (width == 0 || height == 0)
	        return 0;
	    
	    return PercorsiGriglia(width-1, height) + PercorsiGriglia(width, height-1);
	}
	
	static int HannoiMosse(int NDischi)
	{
	    if (NDischi == 1)
	        return 1;
	        
	    return ((HannoiMosse(NDischi-1) +1) * 2) -1;
	}
}
