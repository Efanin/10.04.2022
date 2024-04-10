using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._04._2022
{
    static class Bank
    {

        public static double Dollar {  get; private set; }
        public static double Euro { get; private set; }

        public async static void changedMoney()
        {
            await Task.Run(() =>    
            {
                while (true)
                {
                    Dollar = new Random().NextDouble() * 20 + 90;
                    Euro = new Random().NextDouble() * 20 + 110;
                    Thread.Sleep(new Random().Next(10000));
                    Console.WriteLine("_____________________");
                }
            });
        }
        

    }
}
