using System;

    class Program
    {
    static void Main()
    {
        int i = 0;
        do
        {
            int j = 0;

            while (j < 3) 
            {
                Console.WriteLine("Value of j: {0}", j);

                j++;

            } 
            i++;
            Console.WriteLine("Value of i: {0}", i);

        } while (i < 3) ;
        Console.ReadLine();

    }
}

