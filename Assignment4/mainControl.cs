using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class mainControl
    {

        int smallNum = 0;

        int bigNum = 0;

       int devNum = 0;

        public void control()
        {
            Console.WriteLine("Press ENTER to start");
            Console.ReadLine();
            Console.WriteLine("Enter small range number");
            smallNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter big range number");
            bigNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter devisible number");
            devNum = Convert.ToInt32(Console.ReadLine());


            foreach (int n in EvenSequence(smallNum, bigNum,devNum))
            {
                Console.Write(n.ToString() + " ");
            }
            Console.WriteLine("\n Press ENTER to Exit");
            Console.ReadLine();
        }
        public static IEnumerable<int>
             EvenSequence(int fNumber, int lNumber,int devNum)
        {

            for (int num = fNumber; num <= lNumber; num++)
            {
                  
                if (num % devNum == 0)
                {
                    yield return num;
                }
            }
        }
    }
}
