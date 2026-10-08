

while (true)
{
    Console.WriteLine("vem är det som går??");
    Console.WriteLine("1. Jacob");
    Console.WriteLine("2. Daniel");
    Console.WriteLine("3. Adam");
    Console.WriteLine("4. Andreas");

    int svar = int.Parse(Console.ReadLine());

    if (svar == 1)
    {
        Console.WriteLine("Nej jacob kan inte gå och han stavar med K");
        Console.WriteLine("försök igen");
        
        Console.WriteLine("1. Daniel");
        Console.WriteLine("2. Adam");
        Console.WriteLine("3. Andreas");
        
        int svar2 = int.Parse(Console.ReadLine());
        
        if  (svar2 == 1)
        {
            Console.WriteLine("Ja det är Danne som går");
            break;
        }

        else if (svar2 == 2 && svar2 == 99)
        {
            Console.WriteLine("Na Adam går i Falun");
            Console.WriteLine("Larper");
            break;
        }

        else if (svar2 == 3)
        {
            Console.WriteLine("Nej Andreas går normalt");
            Console.WriteLine("Larper");
            break;
        }

        else if (svar2 > 3 )
        {
            Console.WriteLine("ogiltigt svar");
            Console.WriteLine("Larper");
            break;
        }

    }

    else if (svar == 2)
    {
        Console.WriteLine("Ja det är Danne som går");
        break;
    }

    else if (svar == 3)
    {
        Console.WriteLine("Na Adam går i Falun");
        Console.WriteLine("försök igen");
        Console.WriteLine("1. Daniel");
        Console.WriteLine("2. Jacob");
        Console.WriteLine("3. Andreas");
        
        int svar3 = int.Parse(Console.ReadLine());
        
        if (svar3 == 1)
        {
            Console.WriteLine("Ja det är Danne som går");
            break;
        }

        else if (svar3 == 2)
        {
            Console.WriteLine("Nej jacob kan inte gå och han stavar med K");
            Console.WriteLine("Larper");
            break;
        }

        else if (svar3 == 3)
        {
            Console.WriteLine("Nej Andreas går normalt");
            Console.WriteLine("Larper");
            break;
        }

        else if (svar3 > 3 )
        {
            Console.WriteLine("ogiltigt svar");
            Console.WriteLine("Larper");
            break;
        }
        }

    else if (svar == 4)
    {
        Console.WriteLine("Nej Andreas går normalt");
        Console.WriteLine("försök igen");

        Console.WriteLine("1. Daniel");
        Console.WriteLine("2. Jacob");
        Console.WriteLine("3. Adam");
        
        int svar4 = int.Parse(Console.ReadLine());
        
        if (svar4 == 1)
        {
            Console.WriteLine("Ja det är Danne som går");
            break;
        }

        else if (svar4 == 2)
        {
            Console.WriteLine("Nej jacob kan inte gå och han stavar med K");
            Console.WriteLine("Larper");
            break;
        }

        else if (svar4 == 3)
        {
            Console.WriteLine("Na Adam går i Falun");
            Console.WriteLine("Larper");
            break;
        }

        else if (svar4 > 3 )
        {
            Console.WriteLine("ogiltigt svar");
            Console.WriteLine("Larper");
            break;
        }
        }

    else 
    {
        Console.WriteLine("ogiltigt svar");
        Console.WriteLine("använd 1 till 4");

    }   
}

