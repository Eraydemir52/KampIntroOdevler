using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHomeWork
{
    public class GameClassManager :IManager
    {
        public void delete()
        {
            Console.WriteLine("Record deleted.");
        }

        public void edogrulama()
        {
            Console.WriteLine("Verification successful.");
        }

        public void save()
        {
            Console.WriteLine("Gamer saved.");

        }

        public void update()
        {
            Console.WriteLine("Data updated.");
        }
    }
}
