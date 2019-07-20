using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person : IClient,IMoneyInfo
    {
        public string Name { get; }
        public string Family { get; }
        private double _money;
        public event MoneyTransferHandler Added;
        public event MoneyTransferHandler Removed;
        public Person(string name, string family, double money = 0.0)
        {
            this.Name = name;
            this.Family = family;
            _money = money;
        }

        public void AddMoney(double value)
        {
            _money += value;
            Added(value);
        }

        public bool SpendMoney(double value)
        {
            if (value <= _money)
            {
                _money -= value;
                Removed(value);
                return true;
            }
            else
                return false;

        }

        public string GetInfo()
        {
            return $"{Name} {Family} {_money}";
        }
    }
}
