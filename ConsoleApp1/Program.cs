using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Bank bankA = new Bank();
            bankA.Consumers = new List<IClient>();
            Person p = new Person("Джон", "Смитт");
            bankA.Consumers.Add(p);
            Company OOO = new Company("ООО ВЗЛОМ ЖОПЫ");
            bankA.Consumers.Add(OOO);
            bankA.PrintConsumersList();
        }
    }
}
