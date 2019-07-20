using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bank
    {
        public List<IClient> Consumers;

        public void PrintConsumersList()
        {
            foreach(var c in Consumers)
            {
                Console.WriteLine($"{c.GetInfo()}");
            }
        }
    }
}
