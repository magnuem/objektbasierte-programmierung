using System;

/* # Übungsauftrag: Die Klasse 'RaceCar'
 ## Ausgangslage
 Ein Rennstall möchte ein kleines Programm, mit dem verschiedene Rennautos erstellt und auf einfache Weise
 getestet werden können. Jedes Rennauto wird durch ein Objekt der Klasse 'RaceCar' dargestellt. */

namespace AuftragRaceCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ## Aufgabe 9: Objekte erzeugen

            // Standardkonstruktor
            RaceCar car1 = new RaceCar();

            // Konstruktor mit Marke und Modell
            RaceCar car2 = new RaceCar("Ferrari", "F40");

            // Ausführlichster Konstruktor mit positionalen Argumenten
            RaceCar car3 = new RaceCar("Porsche", "911 GT3", 318, 27);

            // Konstruktor und Objektinitialisierer
            RaceCar car4 = new RaceCar("McLaren", "720S")
            {
                Color = "Orange",
                Name = "Lena",
                Number = 12
            };

            // Benannte Konstruktorargumente
            RaceCar car5 = new RaceCar(
                number: 44,
                maxSpeed: 330,
                model: "AMG GT",
                make: "Mercedes"
            );


            // ## Aufgabe 5: Optionalen Parameter testen

            Console.WriteLine("Short information:");
            car1.InfoCar();

            Console.WriteLine();

            Console.WriteLine("Long information:");
            car1.InfoCar(true);

            Console.WriteLine();


            // ## Aufgabe 6: Positionale und benannte Argumente

            // Positionale Argumente
            car1.Round("Circuit de Monaco", 85);

            Console.WriteLine();

            // Benannte Argumente, Reihenfolge vertauscht
            car1.Round(
                secondsPerRound: 82,
                nameOfTrack: "Circuit de Monaco"
            );

            Console.WriteLine();


            // ## Aufgabe 7: Methodenüberladung

            /*
             Die Methoden IncreaseSpeed sind überladen.
             Die Signaturen unterscheiden sich durch die Anzahl der Parameter:
             IncreaseSpeed() hat keinen Parameter.
             IncreaseSpeed(int) hat einen Parameter vom Typ int.
            */

            // Aufruf mit int-Parameter
            car1.IncreaseSpeed(50);

            Console.WriteLine();

            // Aufruf ohne Parameter
            car1.IncreaseSpeed();

            Console.WriteLine();
        }
    }
}