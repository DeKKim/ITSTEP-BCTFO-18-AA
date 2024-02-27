using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomnumber = random.Next(1, 10);
        int randomnumber1 = random.Next(1, 101);
        int Cda = 0;
        Console.WriteLine("Airchie Tamashis Versiis Nomeri");
        Console.WriteLine("1.Short Version(1 dan 10 mde 3 cda)");
        Console.WriteLine("2.Long Version(1 dan 100 mde Ulimito cda)");
        int cda1 = 3;
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            if (x == 1)
            {
                Console.WriteLine("Random Ricxvi Archeulia");
                Console.WriteLine("Darchenili Cda: "+cda1);
                for (int i = 0; i < 3; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int a))
                    {
                        if (a == randomnumber)
                        {
                            Console.WriteLine("Gilocavt Tqven Sworad Gamoicanit Ricxvi");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Pasuxi Arasworia Kidev Scadet");
                            cda1--;
                            Console.WriteLine("Darchenili Cda: " + cda1);
                            if (randomnumber > a)
                            {
                                Console.WriteLine("Chafiqrebuli Ricxvi Magalia Tqvens Ricxvze");
                            }
                            else
                            {
                                Console.WriteLine("Chafiqrebuli Ricxvi Dabalia Tqvens Ricxvze");
                            }
                            if (cda1 == 0)
                                
                           
                            {
                                Console.WriteLine("Swori Pasuxi Iyo: "+randomnumber);
                                    }
                        }
                    }
                 
                }
            }
            else if (x == 2)
            {
                Console.WriteLine("Random Ricxvi Archeulia"+" "+randomnumber1);
               for(int i = 0;i<1;)
                {
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        if (b == randomnumber1)
                        {
                            
                            Cda++;
                            Console.WriteLine("Gilocavt Tqven Sworad Gamoicanit Ricxvi");
                            Console.WriteLine("Swori Pasuxi Gamoicanit: "+Cda+" Cdashi");
                            break;
                        }
                        else
                        {
                            Cda++;
                            Console.WriteLine("Pasuxi Arasworia Kidev Scadet");
                        }
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
      
    }
}
