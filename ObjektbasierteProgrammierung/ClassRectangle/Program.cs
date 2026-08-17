using System;
class Rectangle {
    
    // Private Attribute
    private int laenge;
    private int breite;
    private int positionX;
    private int positionY;
    private string farbe;
    private string rahmenfarbe;
    private int rahmenstaerke;

    // Konstruktor
    public Rectangle(int laenge, int breite, int positionX, int positionY, string farbe, string rahmenfarbe,
        int rahmenstaerke)
    {
        this.laenge = laenge;
        this.breite = breite;
        this.positionX = positionX;
        this.positionY = positionY;
        this.farbe = farbe;
        this.rahmenfarbe = rahmenfarbe;
        this.rahmenstaerke = rahmenstaerke;
    }
    
    // Öffentliche Methoden
    public bool IstQuadrat()
    {
        return laenge == breite; // Überprüft, ob Länge so lang ist wie Breite
    }
    
    public int Flaeche()
    {
        return laenge * breite;
    }
    
    public void SetPosX(int x) // Void gibt nichts zurück
    {
        positionX = x;
    }
    public void SetPosY(int y) // Void gibt nichts zurück
    {
        positionY = y;
    }
    
    public int GetPosX()
    {
        return positionX;
    }
    
    public int GetPosY()
    {
        return positionY;}
}

class Program // Hier beginnt Programm
{
    static void Main(string[] args)
    {
        // Konstruktor
        Rectangle r = new Rectangle(4, 4, 3, 2, "grün", "rot", 6);

        Console.WriteLine($"Ist Quadrat: {r.IstQuadrat()}");
        Console.WriteLine($"Fläche: {r.Flaeche()}");

    }
}