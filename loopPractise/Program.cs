using System;


namespace loopPractise
{
    class Program
    {
        static void Main()
        {
            //for (int i = 2; i < 20; i++)
            //{
            //    if (i == 10)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}

            //int i = 1;
            //while(i < 10)
            //{


            //    Console.WriteLine(i);
            //   i +=2;
            //}
            try
            {
                int tryInt = 888888888;
                
               
            }
            catch (OverflowException of)
            {

                Console.WriteLine(of.Message);
            }
        
        }
    }
}
