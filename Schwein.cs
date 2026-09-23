using System;

class Program
{
    class schwein
    {
        private int groesse;
        private int gewicht;
        private int saettigung;

        public void wachsen()
        {
            groesse++;
            gewicht++;
            saettigung--;
        }

        public void ausgabe()
        {
            Console.WriteLine("Groeße: {0}", groesse);
            Console.WriteLine("Gewicht: {0}", gewicht);
            Console.WriteLine("Sättigung: {0}\n", saettigung);
        }

        public void init(int x, int y, int z)
        {
            groesse = x;
            gewicht = y;
            saettigung = z;
        }

        public void fressen(Kartoffel a)
        {
            a.gefressenwerden();
            a.ausgabe();
        }
    }

    class Kartoffel
    {
        private int knollenzahl;

        public void gefressenwerden()
        {
            knollenzahl--;
        }

        public void ausgabe()
        {
            Console.WriteLine("Knollenzahl: {0}", knollenzahl);
        }
    }
    public static void Main()
    {
        schwein Hugo = new schwein();
        Hugo.init(10, 20, 30);
        Hugo.ausgabe();
        Hugo.wachsen();
        Hugo.ausgabe();
    }
}
