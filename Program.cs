namespace CastTheDice;


class Program
{

    static void Main()
    {
        System.Console.WriteLine("==================================================================");

        System.Console.WriteLine("Hej och välkommen till Cast-The-Dice");
        System.Console.WriteLine("Ditt mål är att med två sexsidiga tärningar få 12");
        System.Console.WriteLine("Tryck 's' för att starta spelet");
        System.Console.WriteLine("Tryck 'x'för att avluta ");

        System.Console.WriteLine("==================================================================");
        DiceCast();
    }

    static void DiceCast()
    {


        Random diceNr1 = new Random();
        int throwNr1 = diceNr1.Next(1, 7);

        Random diceNr2 = new Random();
        int throwNr2 = diceNr1.Next(1, 7);



        while (true)
        {
            var choise = Console.ReadLine();


            switch (choise)
            {
                case "x":
                    Environment.Exit(0);
                    break;
                case "p":
                    System.Console.WriteLine("Tryck 's' För att starta spelet igen!");
                    DiceCast();
                    break;
                case "s":
                    int sum = throwNr1 + throwNr2;

                    if (throwNr1 + throwNr2 == 12)
                    {
                        System.Console.WriteLine("Grattis! Du har vunnit");
                        System.Console.WriteLine($"Tärning ett fick: {throwNr1} och tärning två fick {throwNr2} Totatl blir de: {sum}");

                        System.Console.WriteLine("Vill du spela igen? Tryck 'p'");
                    }
                    if (throwNr1 + throwNr2 != 12)
                    {
                        System.Console.WriteLine("Tyvärr du vann inte!");
                        System.Console.WriteLine($"Tärning ett fick: {throwNr1} och tärning två fick {throwNr2} Totatl blir de: {sum}");
                        System.Console.WriteLine("Vill du spela igen? Tryck 'p'");

                    }
                    break;



            }

        }



    }

}
