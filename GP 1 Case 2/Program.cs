using GP_1_Case_2.Enum;
using GP_1_Case_2.Array;
using System.Runtime.ExceptionServices;


while (true)
{
    try
    {
        Console.WriteLine("Vælg en af de følgende valgmuligheder: \n0: Lærer \n1: Elev \n2. Fag");

        DataArray dataArray = new DataArray();
        string[,] SubAndStudent = dataArray.SubAndStudent;
        Search search = (Search)int.Parse(Console.ReadLine());

        bool foundMatch = false;

        switch (search)
        {
            case Search.Lærer:
                Console.WriteLine("Indtast lærerens fuldenavn her:");
                string? lærerNavn = Console.ReadLine();

                for (int i = 0; i < SubAndStudent.GetLength(0); i++)
                {

                    if (SubAndStudent[i, 1] == lærerNavn)
                    {
                        foundMatch = true;
                        Console.WriteLine($"Fag: {SubAndStudent[i, 0]}\n");
                        Console.WriteLine("Elever: \n");
                        for (int j = 2; j < SubAndStudent.GetLength(1); j++)
                        {
                            Console.WriteLine(SubAndStudent[i, j]);
                        }

                    }
                }

                if (!foundMatch)
                {
                    Console.WriteLine("Der blev ikke fundet nogen lærer med det navn");
                    Console.WriteLine("Sørg for navnet er stavet med stort, og ikke der ikke gøres brug af speciel tegn");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;

            case Search.Elev:
                Console.WriteLine("Indtast elevens fulde navn her:");
                string? elevNavn = Console.ReadLine();
                for (int i = 0; i < SubAndStudent.GetLength(0); i++)
                {
                    for (int j = 2; j < SubAndStudent.GetLength(1); j++)
                    {
                        if ((SubAndStudent[i, j] == elevNavn))
                        {
                            foundMatch = true;
                            Console.WriteLine($"Fag: {SubAndStudent[i, 0]}");
                            Console.WriteLine($"Lærer: {SubAndStudent[i, 1]}\n");
                        }

                    }
                }
                if (!foundMatch)
                {
                    Console.WriteLine("Der blev ikke fundet nogen elever med det navn");
                    Console.WriteLine("Sørg for navnet er stavet med stort, og ikke der ikke gøres brug af speciel tegn");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;

            case Search.Fag:
                Console.WriteLine("Indtast fagets navn: ");
                string? fagNavn = Console.ReadLine();
                for (int i = 0; i < SubAndStudent.GetLength(0); i++)
                {
                    if (SubAndStudent[i, 0] == fagNavn)
                    {
                        foundMatch = true;
                        Console.WriteLine($"Lærer:  {SubAndStudent[i, 1]} \n");
                        Console.WriteLine("Elever: \n");
                        for (int j = 2; j < SubAndStudent.GetLength(1); j++)
                        {
                            Console.WriteLine(SubAndStudent[i, j]);
                        }
                    }
                }
                if (!foundMatch)
                {
                    Console.WriteLine("Der blev ikke fundet noget fag med det navn");
                    Console.WriteLine("Sørg for navnet er stavet med stort, og ikke der ikke gøres brug af speciel tegn");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;

            default:
                Console.WriteLine("Ugyldigt input");
                break;

        }
        Console.WriteLine("\n Tryk på en knap for at starte programmet om");
        Console.ReadKey();
        Console.Clear();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Der opstod en fejl: {ex.Message}");
        Console.WriteLine("Tryk på en vilkårlig knap");
    }
}