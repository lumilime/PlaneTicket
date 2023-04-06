using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket satu = new PlaneTicket();
            PlaneTicket dua = new PlaneTicket();

            satu.origin = "JOGJA";
            satu.destination = "PKU";
            satu.cost = 100;
            satu.currency = "USD";
            satu.PrintSummary();

            Console.WriteLine();

            dua.origin = "JKT";
            dua.destination = "PKU";
            dua.cost = 750000;
            dua.currency = "IDR";
            dua.PrintSummary();

            Console.ReadKey();



        }
    }
}
