using System;

class Program
{
    static void Main(string[] args)
    {
        // Huvudmeny for programmet
        bool runProgram = true;

        while (runProgram)
        {
            Console.WriteLine("Valkommen till huvudmenyn! Vanligen valj ett alternativ:");
            Console.WriteLine("1: Ungdom eller pensionar");
            Console.WriteLine("2: Rakna ut pris for sallskap");
            Console.WriteLine("3: Upprepa text tio gånger");
            Console.WriteLine("4: Det tredje ordet i en mening");
            Console.WriteLine("0: Avsluta programmet");
            Console.Write("Ange ditt val: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    runProgram = false; // Avsluta programmet
                    Console.WriteLine("Programmet avslutas.");
                    break;

                case "1":
                    CheckAge();
                    break;

                case "2":
                    CalculateGroupPrice();
                    break;

                case "3":
                    RepeatText();
                    break;

                case "4":
                    GetThirdWord();
                    break;

                default:
                    Console.WriteLine("Felaktig input. Vanligen forsok igen.");
                    break;
            }
        }
    }

    static void CheckAge()
    {
        Console.Write("Ange din alder: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age < 5 || age > 100)
            {
                Console.WriteLine("Entre gratis.");
            }
            else if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80 kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionarspris: 90 kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120 kr");
            }
        }
        else
        {
            Console.WriteLine("Ogiltig alder. Var god ange ett nummer.");
        }
    }

    static void CalculateGroupPrice()
    {
        Console.Write("Hur manga personer ska ga pa bio? ");
        if (int.TryParse(Console.ReadLine(), out int numberOfPeople) && numberOfPeople > 0)
        {
            int totalCost = 0;

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.Write($"Ange alder för person {i}: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    if (age < 5 || age > 100)
                    {
                        // Gratis inträde
                        Console.WriteLine("Entre gratis.");
                    }
                    else if (age < 20)
                    {
                        totalCost += 80;
                    }
                    else if (age > 64)
                    {
                        totalCost += 90;
                    }
                    else
                    {
                        totalCost += 120;
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig alder. Ange ett nummer.");
                    i--; // Justera for att fa korrekt antal personer.
                }
            }

            Console.WriteLine($"Antal personer: {numberOfPeople}");
            Console.WriteLine($"Totalkostnad for hela sallskapet: {totalCost} kr");
        }
        else
        {
            Console.WriteLine("Ogiltigt antal personer. Var god ange ett positivt nummer.");
        }
    }

    static void RepeatText()
    {
        Console.Write("Ange en godtycklig text: ");
        string inputText = Console.ReadLine();

        // Upprepa texten 10 ganger
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{inputText}, ");
        }
        Console.WriteLine(); // Ny rad efter all text
    }

    static void GetThirdWord()
    {
        Console.Write("Ange en mening med minst tre ord: ");
        string sentence = Console.ReadLine();
        // Dela upp meningen i ord
        string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 3)
        {
            Console.WriteLine($"Det tredje ordet ar: {words[2]}");
        }
        else
        {
            Console.WriteLine("Meningen maste innehalla minst tre ord.");
        }
    }
}

