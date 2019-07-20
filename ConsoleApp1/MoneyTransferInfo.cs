using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    delegate void MoneyTransferHandler(IClient sender,double value);
    static class MoneyTransferInfo
    {
        private static int _count = 0;
        public static void AddedMes(IClient sender,double value)
        {
            Console.WriteLine($"{_count++}:{sender.GetInfo()} положил на счёт {value}");
        }
        public static void RemovedMes(IClient sender, double value)
        {
            Console.WriteLine($"{_count++}:{sender.GetInfo()} снял со счёта {value}");
        }
        public static void ErrorMes(IClient sender, double value)
        {
            Console.WriteLine($"{_count++}:{sender.GetInfo()} пытался снять со счёта {value}. Недостаточно денег");
        }

        public static void SetOutput(IClient client)
        {
            client.Added += AddedMes;
            client.Removed += RemovedMes;
            client.Error += ErrorMes;
        }
    }
}
