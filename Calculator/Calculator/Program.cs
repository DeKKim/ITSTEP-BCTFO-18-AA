using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Airchiet Sasurveli Moqmedeba:");
        Console.WriteLine(" ");
        Console.WriteLine("1.Mimateba");
        Console.WriteLine("2.Gamokleba");
        Console.WriteLine("3.Gayofa");
        Console.WriteLine("4.Gamravleba");
        Console.WriteLine("5.Procentis Gageba");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine("Airchiet Shesakrebi Ricxvebi");
                    double result = 0;
                    while (true)
                    {
                        double number;
                        if (!double.TryParse(Console.ReadLine(), out number))
                        {
                            break;
                        }

                        result += number;
                    }

                    Console.WriteLine("Archeuli Ricxvebis Jamia:" + result);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Airchiet Shaklebi");
                    double result;
                    if (!double.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    while (true)
                    {
                        double number;
                        if (!double.TryParse(Console.ReadLine(), out number))
                        {
                            break;
                        }

                        result -= number;
                    }

                    Console.WriteLine("Archeuli Ricxvebis Sxvaobaa:" + result);
                    break;
                }

            case 3:
                {
                    Console.WriteLine("Airchiet Gasayofi");
                    double result;
                    if (!double.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    while (true)
                    {
                        double number;
                        if (!double.TryParse(Console.ReadLine(), out number))
                        {
                            break;
                        }

                        result /= number;
                    }

                    Console.WriteLine("Archeuli Ricxvebis Shefardebaa:" + result);
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Airchiet Samravli");
                    double result = 1;
                    while (true)
                    {
                        double number;
                        if (!double.TryParse(Console.ReadLine(), out number))
                        {
                            break;
                        }

                        result *= number;
                    }

                    Console.WriteLine("Archeuli Ricxvebis Namravlia:" + result);
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Airchiet Ricxvi");
                    double number;
                    if (!double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    Console.WriteLine("Am Ricxvis Ramdeni Procenti Gsurt Gaigot");
                    double percentage;
                    if (!double.TryParse(Console.ReadLine(), out percentage))
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    double result = number * (percentage / 100);

                    Console.WriteLine($"Archeuli Ricxvis {percentage}% Aris: {result}");
                    break;
                }

            default:
                Console.WriteLine("ERROR");
                break;

        }
    }
}