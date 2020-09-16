using System;
using System.Collections.Generic;
using System.Text;

namespace DVDKlasse
{
    class DVD
    {
        private string filmTitel;
        private int laufzeit;
        private DateTime erscheinungsjahr;
        private DateTime letzteAusleihe;
        private int kundenNummer;
        private int regalReihe;
        private int regalNummer;
        private int schubladenNummer;
        private int fachNummer;
        private double ausleihGebuehr;
        private bool istAusgeliehen;

        public DVD() { }

        public DVD(string filmTitel)
        {
            setFilmTitel(filmTitel);
        }

        public DVD(string filmTitel, int laufzeit) : this(filmTitel)
        {
            setLaufzeit(laufzeit);
        }

        public void ausleihen()
        {
            this.istAusgeliehen = true;
        }

        public void rueckgabe()
        {
            this.istAusgeliehen = false;
            setLetzteAusleihe(new DateTime());
        }

        public string getFilmTitel()
        {
            return this.filmTitel;
        }

        public int getLaufzeit()
        {
            return this.laufzeit;
        }

        public DateTime getErscheinungsjahr()
        {
            return this.erscheinungsjahr;
        }

        public void setErscheinungsjahr(DateTime newErscheinungsjahr)
        {
            this.erscheinungsjahr = newErscheinungsjahr;
        }

        public DateTime getLetzteAusleihe()
        {
            return this.letzteAusleihe;
        }

        public void setLetzteAusleihe(DateTime newLetzteAusleihe)
        {
            this.letzteAusleihe = newLetzteAusleihe;
        }

        public int getKundenNummer()
        {
            return this.kundenNummer;
        }

        public void setKundenNummer(int newKundenNummer)
        {
            this.kundenNummer = newKundenNummer;
        }

        public int getRegalReihe()
        {
            return this.regalReihe;
        }

        public void setRegalReihe(int newRegalReihe)
        {
            this.regalReihe = newRegalReihe;
        }

        public void setFilmTitel(string newTitel)
        {
            this.filmTitel = newTitel;
        }

        public void setLaufzeit(int newLaufzeit)
        {
            this.laufzeit = newLaufzeit;
        }

        public int getRegalNummer()
        {
            return this.regalNummer;
        }

        public void setRegalNummer(int newRegalNummer)
        {
            this.regalNummer = newRegalNummer;
        }

        public int getSchubladenNummer()
        {
            return this.schubladenNummer;
        }

        public void setSchubladenNummer(int newSchubladenNummer)
        {
            this.schubladenNummer = newSchubladenNummer;
        }

        public int getFachNummer()
        {
            return this.fachNummer;
        }

        public void setFachNummer(int newFachNummer)
        {
            this.fachNummer = newFachNummer;
        }

        public double getAusleihGebuehr()
        {
            return this.ausleihGebuehr;
        }

        public void setAusleihGebuehr(double newAusleihGebuehr)
        {
            this.ausleihGebuehr = newAusleihGebuehr;
        }

        public bool verfuegbar()
        {
            return !this.istAusgeliehen;
        }
    }
}
