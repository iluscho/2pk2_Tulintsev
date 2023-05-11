

using System.Net.Sockets;

namespace _22pz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime otprav = new DateTime(2023, 2, 20, 12, 30, 00);
            Ticket sasha = new Ticket(2654, 564905, "льгот", 7, 11, otprav);
            sasha.PrintInfo();
            sasha.PrintInfo();


        }
    }
}