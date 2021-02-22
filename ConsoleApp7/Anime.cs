using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp7
{
    abstract class Anime
    {

       public double rating;
        public abstract string PremiereDate { get; set; }

        /* public Anime(int rat)
         {
             rating = rat;
         }*/
        public abstract void print();

    }

    class conan:Anime

    {

        private string PD;



        public conan(string PD, double reut)//:base (reuting)
        {
            PremiereDate=PD;
            rating = reut;
        }
        


        public override string PremiereDate
        {
            get { return PD; }
            set { PD = value; }
        }


    
        public override void print()
        {
            Console.WriteLine("conan PremiereDate is :  " + PD + " reuting : " + rating + " ");

        }

        

    }

    class onepice:Anime
    {
        private string PD= "October 20, 1999";

        public onepice(double R)
        {
            rating = R;

        }
        public override string PremiereDate
        {
            get { return PD; }
            set { PD = value; }
        }



        public override void print()
        {
            Console.WriteLine("ONE Piece PremiereDate is :  " + PD + " reuting : " + rating + " ");

        }

        
    }
}
