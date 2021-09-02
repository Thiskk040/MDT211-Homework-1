using System;
using System.Collections.Generic;
namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            long startwait = DateTimeOffset.Now.ToUnixTimeSeconds();
            bool stop = false;
            Console.Write("Program will run in...");
            while(true)
            {
                long endWait = DateTimeOffset.Now.ToUnixTimeSeconds();
                long wait = endWait - startwait;
                if (wait == 1 && stop == false) { Console.Write(" 3 ");stop = true; }
                if (wait == 2 && stop == true) { Console.Write(" 2 "); stop = false; }
                if (wait == 3 && stop == false) { Console.Write(" 1 "); stop = true; }
                if (wait == 4 && stop == true) { Console.Write(" 0 "); stop = false;break; ; }
            }
            Console.WriteLine();
            User user1 = new User("Jame Watson", "Jame@gmail.com");
            Clothes clothes1 = new Clothes("L","Red","Dangguitar", 500);
            Clothes clothes2 = new Clothes("M", "Black", "Thansadsada", 750);
            Clothes clothes3 = new Clothes("S", "Green", "Tonynahhee", 625);

            Adress Jameadress = new Adress("131/75", "Putthamonthon", "Nakhonphathom", "10180");


            user1.customer();
            user1.cart(Jameadress);
            user1.list(clothes1);
            user1.list(clothes2);
            user1.list(clothes3);
            Console.WriteLine("* Order *");
            Console.WriteLine("  ***** ");
            Jameadress.Write();
            clothes1.Combine();
            clothes2.Combine();
            clothes3.Combine();
            user1.calculator();




            
           
        }
    }
     
}
