using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._04._2022
{
    enum Wallet
    {
        Dollar,
        Euro
    }
    internal class Profile
    {
        public string Name { get; private set; }
        public Money Money { get; private set; }
        public Profile(string Name)
        {
            this.Name = Name;
            Money = new Money();
            Money.Doolar = 0;
            Money.Euro = 0;
        }
        public void AddMoney(Wallet wallet, double money)
        {
            switch (wallet)
            {
                case Wallet.Dollar:
                    Money.Doolar = money;
                    break;
                case Wallet.Euro:
                    Money.Euro = money;
                    break;
                default:
                    break;
            }
        }
        public void Balance()
        {
            Console.WriteLine($"Doolar: {Money.Doolar}");
            Console.WriteLine($"Euro: {Money.Euro}");
        }
    }
}
