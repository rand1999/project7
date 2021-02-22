using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            conan conan = new conan("1989 joun", 4.7);
            
            conan.print();
            

            onepice op = new onepice(4.8);
            op.print();

            Console.WriteLine("///////////////////////////////////////"); 

            Cl.name = "reem";
            Console.WriteLine(Cl.name);


            c2 C2 = new c2("amal");
            C2.print();





        }
    }
}
