namespace pz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число для возведения в квадраты и куби: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(b);
                i++;
                b *= 2;
            }
            i = 0;
            b = a;
            Console.WriteLine("");
            while (i < 10)
            {
                Console.WriteLine(b);
                i++;
                b = b * a * a;
            }
        }
    }
}