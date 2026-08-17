using System;

class MyMath
{
    public static int Calc_ggT(int a, int b)
    {
        while (b != 0) // b ist der Rest, nur so lange durchführen, bis es keinen Rest mehr gibt
        {
            int rest = a % b; // Liefert Rest einer Division
            a = b; // alte Zahl b wird zu a
            b = rest; // Der Rest wird zum neuen b
        }
        return a; // Sobald b == 0 steht ggT in a
    }

    public static int Calc_kgV(int a, int b)
    {
        int ggT = Calc_ggT(a, b);
        return (a * b) / ggT; // kgV(a,b) = (a*b)/(ggT(a,b))
    }
}

class Program
{
    static void Main(String[] args)
    {
       // Benutzer nach erster Zahl fragen
        Console.WriteLine("Bitte die erste Zahl eingeben:");
        string eingabe1 = Console.ReadLine();
        
        // Benutzer nach zweiter Zahl fragen
        Console.WriteLine("Bitte die zweite Zahl eingeben:");
        string eingabe2 = Console.ReadLine();
        
        // Text in Zahlen umwandeln
        int a = Convert.ToInt32(eingabe1);
        int b = Convert.ToInt32(eingabe2);
        
        // Methoden aufrufen
        int ggtErgebnis = MyMath.Calc_ggT(a, b);
        int kgvErgebnis = MyMath.Calc_kgV(a, b);
        
        // Ausgeben
        Console.WriteLine("Der grösste gemeinsame Teiler von " + eingabe1 + " und " + eingabe2 + " ist: " + ggtErgebnis);
        Console.WriteLine("Das kleinste gemeinsame Vielfache von " + eingabe1 + " und " + eingabe2 + " ist: " + kgvErgebnis);
    }
}