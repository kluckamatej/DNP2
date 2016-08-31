using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kim", "Jesper", "Mads", "Morten", "Rasmus" };

            //   PREDICATE   
            //   string[] namesWithMoreThanThreeLetters = Array.FindAll(names, moreThanThreeLetters);



            //   ANONYMOUS method
            //string[] namesWithMoreThanThreeLetters = Array.FindAll(names, delegate (string s)
            //{
            //    if (s.Length > 3)
            //    {
            //        return true;
            //    }
            //    else return false;
            //}
            //    );



            //    LAMBDA Expression
            string[] namesWithMoreThanThreeLetters = Array.FindAll(names, s => moreThanThreeLetters(s));

            for (int i = 0; i < namesWithMoreThanThreeLetters.Length; i++)
            {
                Console.WriteLine(namesWithMoreThanThreeLetters[i]);
            }
            Console.ReadLine();

        }

        static bool moreThanThreeLetters(String s)
        {
            //used only with PREDICATE and LAMBDA
            if (s.Length > 3)
            {
                return true;
            }
            else return false;

        }


    }
}

