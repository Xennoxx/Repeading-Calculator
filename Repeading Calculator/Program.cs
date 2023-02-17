class Program
{
    static void Main(string[] args)
    {
        //[A1] Objekt Aufgabe erstellt
        wert Aufgabe1 = new wert();

        //[A1] Eingabe von Wert1
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Wert1: ");
        Aufgabe1.wert1 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        //[A1] Eingabe von Wert2
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Wert2: ");
        Aufgabe1.wert2 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        //[A1] Eingabe von "Zeicheneingabe"
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Zeicheneingabe: ");
        Aufgabe1.zeicheneingabe = Convert.ToChar(Console.ReadLine());
        Console.Clear();

        //[A1] Ausgabe von, Wert1,Wert2,"Zeicheneingabe"
        Console.WriteLine("Werte:" + Aufgabe1.wert1 + Aufgabe1.wert2 + Aufgabe1.zeicheneingabe);
        Console.ReadKey();
    }
}

class wert
{
    public int wert1 { get; set; }
    public int wert2 { get; set; }
    public char zeicheneingabe { get; set; }
}