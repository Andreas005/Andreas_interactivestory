Console.WriteLine("Vill du ha instruktioner");

string instruktioner = Console.ReadLine().ToLower();

// Console.WriteLine($"{name}");

if (instruktioner == "ja")
{
    Console.WriteLine("Du befinner dig i en grotta som finns väldigt många hinder, för att försöka komma ut så måste du välja dörrarna som är rätt. om du väljer att inte spela så förlorar du men om du väljer att spela så har du en chans att överleva");
    Console.WriteLine("Väljer du att spela eller att inte överleva?");
    string val = Console.ReadLine().ToLower();

    if (val == "spela")
    {


        Console.WriteLine("Okej du har valt för att spela och försöka överleva BRA VAL!");
        Console.WriteLine("Ifall du kollar bakom dig så kommer du att se två dörrar en Röd och Gul");
        Console.WriteLine("Vilken dörr tänker du att gå igenom!");

        string door = Console.ReadLine().ToLower();

        if (door == "röd")
        {
            Console.WriteLine("Bra jobbat du har valt rätt dörr, det finns en person som är framför dig, vill du prata med honom eller ignorera honom?");

            string randomman = Console.ReadLine().ToLower();

            if (randomman == "ignorera")

                Console.WriteLine("Du har valt rätt dörr Bra jobbat du har klarat av spelet och nu har du överlevt!");

        }

        else if (door == "gul")
        {

            Console.WriteLine("Du har valt fel dörr du kommer nu att dö");

        }


    }
    else if (val == "inte överleva")
    {

        Console.WriteLine("Du har valt att inte överleva! DÅLIGT VAL! Nu kommer du dö!");


    }

}
else if (instruktioner == "nej")
{
    Console.WriteLine("Du kommer att dör nu dåligt val");
}





// else if ( name == "Thomas")

// { 

//     Console.WriteLine("euwwwwwwww");
// }
// else
// { 
//     Console.WriteLine("cokk ful du e walla");
// }

Console.ReadLine();