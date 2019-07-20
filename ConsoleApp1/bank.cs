using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bank
    {
        public List<IClient> Consumers;
        public Bank()
        {
            Consumers = new List<IClient>();
        }

        public void PrintConsumersList()
        {
            foreach(var c in Consumers)
            {
                Console.WriteLine($"{c.GetInfo() } имееет на счету {c.Money}");
            }
        }
    }
}
