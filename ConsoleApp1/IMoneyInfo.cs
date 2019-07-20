using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IMoneyInfo
    {
        event MoneyTransferHandler Added;
        event MoneyTransferHandler Removed;
    }
}
