using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IClient
    {
        event MoneyTransferHandler Added;
        event MoneyTransferHandler Removed;
        event MoneyTransferHandler Error;
        double Money { get; }
        void AddMoney(double value);
        bool SpendMoney(double value);

        string GetInfo();
    }
}
