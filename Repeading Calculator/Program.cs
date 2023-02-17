class program
{
    public void main(string[] args)
    {
        wert Aufgabe1 = new wert();
        Aufgabe1.wert1 = Console.ReadLine();
        Aufgabe1.zeicheneingabe = Console.ReadLine();
    }
}

class wert
{
    public int wert1 { get; set; }
    public int wert2 { get; set; }
    public char zeicheneingabe { get; set; }
}