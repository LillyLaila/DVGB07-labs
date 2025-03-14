class Program
{

    //Skriva ut jämna tal från 0-30 
    static void Uppgift1()
    {
        for (int i = 0; i < 30; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    //Läser in ett tal från användare och skriver ut om talet är posititvt eller negativt. 
    static void Uppgift2()
    {
        Console.WriteLine("Write a number: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0)
            {
                Console.WriteLine("Talet är positivt");
            }
            else if (number < 0)
            {
                Console.WriteLine("Talet är negativt");
            }
            else if (number == 0)
            {
                Console.WriteLine("Talet är 0");
            }
        }
        else
        {
            Console.WriteLine("Felaktig inmatning");
        }
    }

    //Läser in olika tal från användaren, programmet ska hitta det minsta och stösta värdet. 
    static void Uppgift3()
    {
        Console.Write("Ange antal tal: "); //Ange antal tal . 
        if (int.TryParse(Console.ReadLine(), out int antal) && (antal > 0))
        {
            int[] n = new int[antal]; //ange storleken för arrayen där man ska lagra tal.
            for (int i = 0; i < antal; i++)
            {
                Console.Write($"Ange tal {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out n[i]))
                {
                    Console.WriteLine("Felaktig inmatning, försök igen"); //kollar om det är ett tal
                }
            }
            Console.WriteLine($"Minsta talet: {n.Min()}");
            Console.WriteLine($"Största talet: {n.Max()}");
        }
        else
        {
            Console.WriteLine("Felaktig inmatning");
        }
    }

    //Läser in ett text och skriver hur många ordföljanden AB finns i texten
    static void Uppgift4()
    {
        Console.WriteLine("Skriv en liten text: ");
        //?=nulloperator, om readline returnerar null, undviker vi en exception
        string text = Console.ReadLine()?.ToUpper() ?? "";  //ToUpper() = omvandlar hela texten till stora bokstäver, "abcABAb" -> "ABCABAB"
        int count = text.Contains("AB") ? text.Split("AB").Length - 1 : 0; //Split delar upp strängen vid varje "AB". Length -1 = antalet AB i texten är en mindre än antalet delar.
        Console.WriteLine($" 'AB' förkommer {count} gånger. ");
    }

    //Använd en vektor array för att ta emot 10 decimaltal, o sen skriva ut median och medelvärdet på talen. 
    static void Uppgift5()
    {
        double[] decimalTal = new double[10]; //ange storleken för arrayen där man ska lagra alla decimaltal.
        Console.WriteLine("Ange 10 decimaltal: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ange tal {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out decimalTal[i]))
            {
                Console.WriteLine("Felaktig inmatning, försök igen"); //kollar om det är ett tal
            }
        }
        Array.Sort(decimalTal); //sortera arrayen först
        double median = decimalTal.Length % 2 == 0 ?
         (decimalTal[4] + decimalTal[5]) / 2.0 : decimalTal[5];
        double medelvalue = decimalTal.Average();
        Console.WriteLine($"Medianvärdet: {median}, Medelvärdet: {medelvalue}");
    }

    //En funktion som tar emot två heltal och beräknar summan av dem.
    static void Uppgift6()
    {
        Console.WriteLine("Ange 2 tal för att beräkna summan: ");
        int[] n = new int[2];
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Ange tal {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out n[i]))
            {
                Console.WriteLine("Felaktig inmatning, försök igen"); //kollar om det är ett tal
            }
        }
        int summan = n[0] + n[1];
        Console.WriteLine($"Summan är: {summan}");
    }

    //isAlpha som tar emot en bokstav (char) och skriver ut om bokstaven är med i alfabetet elr inte.
    static void Uppgift7()
    {
        Console.WriteLine("Ange endast en bokstav: ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input) && input.Length == 1)
        { //kollar så att det är endast en bokstav och inte null
            char bokstav = input[0];
            if (char.IsLetter(bokstav))
            {
                Console.WriteLine($"'{bokstav}' är en bokstav i alfabetet.");
            }
            else
            {
                Console.WriteLine($"'{bokstav}' är **inte** en bokstav i alfabetet.");
            }
        }
        else {
                Console.WriteLine("Felaktig inmatning. Ange **endast en bokstav**.");
        }
    }

//Slumpa en lottorad varje gång användaren trycker på Enter. En lottorad innehåller sju unika tal från 1-36.
    static void Uppgift9(){
        Random rand = new Random();
        int[] lottoRow = Enumerable.Range(1, 36).OrderBy(x => rand.Next()).Take(7).ToArray();
        Console.WriteLine("Lottorad: " + string.Join(", ", lottoRow));
    }


    static void Main(string[] args)
    {
        //Uppgift1();
        //Uppgift2();
        //Uppgift3();
        //Uppgift4();
        //Uppgift5();
        //Uppgift6();
        //Uppgift7();
        Uppgift9();




    }
}
