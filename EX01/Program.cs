using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Assingment 1.1
            //Create a for loop that print every second number in the range from 100 to 202(both inclusive)

            //for (int i = 100; i <= 202; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");
            //}
            //Console.ReadLine();


            //Assingment 1.2
            //Create a for loop that print every second number in the range from 100 to 202 in reverse order

            //for (int i = 202; i >= 100; i--)
            //{
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");
            //}
            //Console.ReadLine();


            //Assingment 1.3
            //a)Create a while loop that print every second number in the range from 100 to 202
            //b)Implement a switch-case structure. The switch shall handle the numbers 
            //-(110,130 and 140)print “This is a funny number”
            //-122 shall print “this is my lucky number”
            //-198 should not be printed
            //-The rest of the number shall be printed as in a)

            //a)

            //int i = 100;
            //while(i <= 202){
            //    if (i % 2 == 0)
            //    Console.Write(i + " ");
            //        i++;
            //}
            //Console.ReadLine();

            //b)

            //int caseSwitch = 100;
            //while (caseSwitch <= 202)
            //{
            //    if (caseSwitch % 2 == 0)
            //    {


            //        switch (caseSwitch)
            //        {
            //            case 110:
            //            case 130:
            //            case 140:
            //                Console.WriteLine(caseSwitch + " This is a funny number");
            //                break;
            //            case 122:
            //                Console.WriteLine(caseSwitch + " this is my lucky number");
            //                break;
            //            case 198:
            //                Console.WriteLine(" ");
            //                break;
            //            default:
            //                Console.WriteLine(caseSwitch);
            //                break;
            //        }
            //    }
            //    caseSwitch++;
            //}
            //Console.ReadLine();



            //Assignemnt 1.4
            //Create a for loop that print every number in the range from 1 to 255(both inclusive) in hexadecimal.The
            //output should look something like:
            //01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10
            //11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F 20
            //21 22...........


            //    int i;
            //    int caseSwitch = 0;
            //    for (i = 0; i <= 255; i++, caseSwitch++)
            //    {
            //        if(i==0)
            //        {
            //            Console.Write("");
            //        }
            //        else
            //        {
            //            switch(caseSwitch){
            //                case 17:
            //                case 33:
            //                case 49:
            //                case 65:
            //                case 81:
            //                case 97:
            //                case 113:
            //                case 129:
            //                case 145:
            //                case 161:
            //                case 177:
            //                case 193:
            //                case 209:
            //                case 225:
            //                case 241:
            //                    Console.WriteLine();
            //                    break;
            //            }

            //            Console.Write(i.ToString("X2"));
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.ReadLine();



            //Assignment 1.5

            CLBirdie clbirdie = new CLBirdie();
            Console.WriteLine(clbirdie.MakeSomeNoise());
            Console.ReadLine();
        }

        class CLBirdie
        {
            public String MakeSomeNoise()
            {
                return "peep";
            }
        }
    }


}

