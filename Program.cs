//Bok / Film info
//    Lag en applikasjon der man kan skrive inn forskjellige detaljer, og etter man har skrevet inn alt få printet tilbake det som ble skrevet inn som et “produkt”, enten en film eller en bok, dere velger.
//    Man skal bli spurt av konsollen om Tittel, så år det kom ut, litt beskrivelse av hva filmen eller boken handler om, forfatter/regissør, hvilke skuespillere som var med.
//    Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt, med alle egenskaper listet opp.
//    BONUS:
//          Legg til mulighet for å skrive inn flere bøker eller filmer, her trenger man å ta i bruk lister, neste ukes pensum

namespace BokFilm;

internal class Program
{
    static void Main(string[] args)
    {
        //var Bok = new Produkt(
        //    "Ave",
        //    "Test", 
        //    false, 
        //    "Blazej", 
        //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        //    );
        //var Film = new Produkt(
        //    "Ave2",
        //    "Test2", 
        //    true, 
        //    "Mats", 
        //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa2"
        //    );

        Console.WriteLine("Is it a film or a book");
        Console.WriteLine("1. Film    2. Book");
        var choice = Console.ReadLine();

        Console.WriteLine("Whats the title");
        var title = Console.ReadLine();

        Console.WriteLine("Who the author?");
        var author = Console.ReadLine();
        
        Console.WriteLine("Who the lead?");
        var lead = Console.ReadLine();

        Console.WriteLine("Can you give a quick despciption?");
        var desc = Console.ReadLine();
        Console.Clear();
        var realChoice = choice == "1" ? true: false;

        var film = new Produkt(title,author,realChoice, lead, desc);
        film.PrintInfo();
        Console.ReadKey();

    }
}