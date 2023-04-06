using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass2
{
    class PlaneTicket
    {
        public string origin { get; set; }
        public string destination { get; set; }
        public string currency { get; set; }
        public int cost { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine("oringin : {0}", origin);
            Console.WriteLine("destination :{0}", destination);
            Console.WriteLine("currency :{0}", currency);
            Console.WriteLine("cost :{0} ({1})", cost, currency);
            if (currency == "IDR")
            {
                cost = cost / 15000;
                Console.WriteLine("convert to Dollar: {0}", cost);

            }else if (currency == "USD")
            {
                cost = cost * 15000;
                Console.WriteLine("Convert to Rupiah: {0}", cost);

            }
        }

    }
}
