using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Company : IClient
    {
        public string LegalName { get; }
        private double _money;
        public Company(string legalName, double money = 0.0)
        {
            this.LegalName = legalName;
            _money = money;
        }
        public void AddMoney(double value)
        {
            _money += value;
        }

        public bool SpendMoney(double value)
        {
            if (value <= _money)
            {
                _money -= value;
                return true;
            }
            else
                return false;

        }

        public string GetInfo()
        {
            return $"{LegalName} {_money}";
        }
    }
}
