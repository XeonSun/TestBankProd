using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IClient
    {

        void AddMoney(double value);
        bool SpendMoney(double value);

        string GetInfo();
    }
}
