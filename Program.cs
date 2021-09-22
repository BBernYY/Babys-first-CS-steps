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
                {"sytze", 11}, {"louise", 7}
            };
            string[] mensen = new string[]{"louise", "sytze"};
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