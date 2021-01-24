using System;
using System.Collections.Generic;

namespace OOPHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerSave gamerSave = new GamerSave {FirstName="Eray",LastName="Demir",dateTime=new DateTime(2002,12,09),Id=1 };
            GamerSave gamerSave1 = new GamerSave { FirstName = "Emrehan", LastName = "Demir", dateTime = new DateTime(2012, 09, 23), Id = 2 };

            GamerSave[] gamerSaves = new GamerSave[] { gamerSave, gamerSave1 };

            foreach (var gamers in gamerSaves)
            {
                Console.WriteLine(gamers.Id);
            }



            Console.WriteLine("******************************");





            GameClassManager gameClassManager1 = new GameClassManager();
            gameClassManager1.save();


            GameClassManager gameClassManager2 = new GameClassManager();
            gameClassManager2.update();


            GameClassManager gameClassManager3 = new GameClassManager();
            gameClassManager3.edogrulama();


            GameClassManager gameClassManager4 = new GameClassManager();
            gameClassManager4.delete();

            Console.WriteLine("*****************************");

            Campaign1 campaign1 = new Campaign1();
            campaign1.join();

            Campaign2 campaign2 = new Campaign2();
            campaign2.join();

            Campaign3 campaign3 = new Campaign3();
            campaign3.join();








        }
    }
}
