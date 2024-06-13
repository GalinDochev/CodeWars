using System;

public class DnaStrand
{
    // Method to make a complement of a DNA sequence
    public static string MakeComplement(string dna)
    {
        // Replace 'A' with '#' and 'T' with 'A', then replace '#' with 'T'
        string output = dna.Replace('A', '#').Replace('T', 'A').Replace('#', 'T');

        // Replace 'G' with '#' and 'C' with 'G', then replace '#' with 'C'
        output = output.Replace('G', '#').Replace('C', 'G').Replace('#', 'C');

        // Return the final complemented DNA sequence
        return output;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(DnaStrand.MakeComplement("GTAT"));
    }
}