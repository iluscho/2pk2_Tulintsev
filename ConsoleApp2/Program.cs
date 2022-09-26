namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = -100; i < 1; i += 2)
                Console.WriteLine(i);

            Console.WriteLine("------------------------");
            
            char a;
            for (a = 'к'; a != 'т'; a++)
                Console.Write("{0} ", a);

            Console.WriteLine("\n------------------------");
            
            int n;
            int m;
            for (n = 0; n < 4; n++)
            {
                for (m = 0; m < 8; m++)
                    Console.Write("# ");
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n------------------------");

            int kratnoe = 17;
            int c;
            for (c = 0; c != 100; c++)
                if (c % kratnoe == 0)
                    Console.WriteLine(c);

            Console.WriteLine("\n------------------------");

            int z;
            int v = 55;
            for (z = 0; v - z != 8; z++)
                Console.WriteLine(z);


        }
    }
}