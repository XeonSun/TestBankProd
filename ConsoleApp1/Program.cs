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
            bankA.PrintConsumersList();
            p.AddMoney(1000);
            bankA.PrintConsumersList();
            MoneyTransferInfo.SetOutput(p);
            p.AddMoney(100);
            p.SpendMoney(1000);
            p.SpendMoney(1000);
            //while (true)
            //{
            //    Console.WriteLine("Меню:");
            //    Console.WriteLine("1. Создать клиента");
            //    Console.WriteLine("2. Работа с клиентом");
            //    Console.WriteLine("3. Удалить клиента");
            //}



        }
    }
}
