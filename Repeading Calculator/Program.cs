using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Wilkommen zu Nikki's Calclator");
            Console.Write("Hf! :D");
            Console.ReadLine();
            bool check = true;
                while (check)
                {
                        //CALCULATOR
                        //[A1] Objekt Aufgabe erstellt
                        wert Aufgabe1 = new wert();

                        //[A1] Eingabe von Wert1
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("_________");
                        Console.Write("Wert1: ");
                        Aufgabe1.wert1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        //[A1] Eingabe von Wert2
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("_________");
                        Console.Write("Wert2: ");
                        Aufgabe1.wert2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        //[A1] Eingabe von "Zeicheneingabe"
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("__________________");
                        Console.WriteLine("Zeicheneingabe: ");
                        Aufgabe1.zeicheneingabe = Convert.ToChar(Console.ReadLine());
                        Console.Clear();

                        //[A1] Berechnung
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("____________");
                        Console.WriteLine("Berechnet...");
                        Aufgabe1.berechnung();
                        Console.Clear();

                        //[A1] Ergebnis
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("_______________");
                        Console.WriteLine("Ergebnis = " + Aufgabe1.ergebnis);
                        Console.ReadKey();
                        Console.Clear();
                    //Beenden der schleife
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Möchtest du aufhören? So schreibe: ja;");
                    string yes = Convert.ToString(Console.ReadLine());
                    if (yes == "ja") 
                    { 
                    check = false; 
                    }
                } 
        }
    }
}

class wert
{
    //Eigenschaften
    public int wert1 { get; set; }
    public int wert2 { get; set; }
    public char zeicheneingabe { get; set; }
    public int ergebnis { get; set; }
    //Methoden
    public void berechnung()
    {
        if (zeicheneingabe == '+') { ergebnis = wert1 + wert2; }
        else if (zeicheneingabe == '-') { ergebnis = wert1 - wert2; }
        else if (wert1 == 0) { ergebnis = 0; }
        else if (zeicheneingabe == '*') { ergebnis = wert1 * wert2; }
        else { ergebnis = wert1 / wert2; }
    }
}