using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
   static class Cl
    {
       public static string name;

       static Cl()
        {
            name = "rand";

            Console.WriteLine(name);
        }





    }
    class c2
    {
        const int id=44;

        readonly string name;

        public c2(string Name)
        {
            name = Name;
            
        }

        public void print()
        {
            Console.WriteLine(name+"   "+id);
        }
    }

}
