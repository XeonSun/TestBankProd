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

        void AddMoney(double value);
        bool SpendMoney(double value);

        string GetInfo();
    }
}
