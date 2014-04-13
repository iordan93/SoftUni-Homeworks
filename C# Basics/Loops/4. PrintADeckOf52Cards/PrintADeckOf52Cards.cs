using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 0; i < 13; i++)
        {
            string card = string.Empty;
            switch ((i % 13) + 2)
            {
                case 11:
                    card = "J";
                    break;
                case 12:
                    card = "Q";
                    break;
                case 13:
                    card = "K";
                    break;
                case 14:
                    card = "A";
                    break;
                default:
                    card = ((i % 13) + 2).ToString();
                    break;
            }

            Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
        }
    }
}