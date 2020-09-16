using System;

namespace DVDKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD myDVD = new DVD();

            DVD myDVD2 = new DVD("Inception");

            DVD myDVD3 = new DVD("Shrek", 120);

            myDVD.setFilmTitel("Star Wars: Die letzten Jedi - (DVD)");

            myDVD.setLetzteAusleihe(new DateTime(2018, 09, 13));

            myDVD.setErscheinungsjahr(new DateTime(2017, 01, 01));

            myDVD.setRegalReihe(1);

            myDVD.setLaufzeit(146);

            myDVD.setRegalNummer(3);

            myDVD.setSchubladenNummer(6);

            myDVD.setFachNummer(1);

            myDVD.setAusleihGebuehr(3.00);

            myDVD.ausleihen();

            myDVD.setKundenNummer(987654321);

            Console.WriteLine(myDVD.getFilmTitel());

            Console.WriteLine(myDVD.getLetzteAusleihe());

            Console.WriteLine(myDVD.getErscheinungsjahr());

            Console.WriteLine(myDVD.getRegalReihe());

            Console.WriteLine(myDVD.getLaufzeit());

            Console.WriteLine(myDVD.getRegalNummer());

            Console.WriteLine(myDVD.getSchubladenNummer());

            Console.WriteLine(myDVD.getFachNummer());

            Console.WriteLine(myDVD.getAusleihGebuehr());

            Console.WriteLine(myDVD.verfuegbar());

            myDVD.rueckgabe();

            myDVD.setKundenNummer(0);

            Console.ReadLine();
        }
    }
}
