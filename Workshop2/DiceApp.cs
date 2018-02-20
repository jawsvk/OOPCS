using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class DiceApp
    {
        static void Main()
        {
            Dice A = new Dice();
            Dice B = new Dice();
            double count = 0;
            Console.Write("How many times to throw the dice? ");
            int j = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= j; i++)
            {
                
                if (A.strFaceUp == "8") count++;
            }

            Console.WriteLine("Probability of getting 8 is " + count/j);
           
        }
    }
}
