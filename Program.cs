namespace Schaltjahr_WS2324_T11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe
            //Erstellen Sie ein Programm mit Menü, das nach Eingabe
            //einer Jahreszahl, ausgibt ob es sich um ein
            //Schaltjahr handelt.

            string wiederholung = "";
            do
            {
                Console.WriteLine("Es soll auf Schaltjahr überprüft werden:");
                int jahr = 0;
                Console.Write("Jahreszahl eingeben:");
                jahr = Convert.ToInt32(Console.ReadLine());
                if (jahr % 4 == 0 && (jahr % 100 != 0 || jahr % 400 == 0))
                {
                    Console.WriteLine(jahr + " ist ein Schaltjahr.");
                   // Console.WriteLine($" {jahr} ist ein Schaltjahr.");
                   // Console.WriteLine("{0} ist ein Schaltjahr.", jahr);
                }
                else
                {
                    Console.WriteLine("{0} ist kein Schaltjahr.", jahr);
                }

                Console.WriteLine("Nochmal? (j/n)");
                wiederholung = Console.ReadLine();
            }while (wiederholung=="j");


        }
    }
}