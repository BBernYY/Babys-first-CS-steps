using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            var leeftijden = new Dictionary<string, int>(){
                {"John smith", 11}, {"Johnny smithy", 7}
            };
            string[] mensen = new string[]{"John smith", "Johnny smithy"};
            while (true) {
                Random random = new Random();
                var mens = mensen[random.Next(2)];
                Console.WriteLine(mens);
                var ans = Console.ReadLine();
                Console.WriteLine(leeftijden[mens] == Int32.Parse(ans));
                };
        }
    }
}
