using System;

class Program
{
    static void Main()
    {
        
        int oreLucrate;
        double tarifPeOra;
        double salariu;

        
        Console.Write("Introduceti numarul de ore lucrate: ");
        oreLucrate = Convert.ToInt32(Console.ReadLine());

        
        Console.Write("Introduceti tariful pe ora: ");
        tarifPeOra = Convert.ToDouble(Console.ReadLine());

        
        salariu = oreLucrate * tarifPeOra;

       
        Console.WriteLine("Salariul este: " + salariu + " lei");

        
        if (salariu > 3000)
        {
            Console.WriteLine("Salariu mare");
        }
        else
        {
            Console.WriteLine("Ati lucrat prea putine ore pentru a avea un salariu mare!");
        }

        Console.ReadLine();
    }
}
