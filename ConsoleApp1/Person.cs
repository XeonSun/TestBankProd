using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person : IClient
    {
        public string Name { get; }
        public string Family { get; }
        private double _money;
        public double Money {get{return _money;} }
        public event MoneyTransferHandler Added;
        public event MoneyTransferHandler Removed;
        public event MoneyTransferHandler Error;
        public Person(string name, string family, double money = 0.0)
        {
            this.Name = name;
            this.Family = family;
            _money = money;
            Added = delegate { };
            Removed = delegate { };
            Error = delegate { };
        }

        public void AddMoney(double value)
        {
            _money += value;
            Added(this, value);
        }

        public bool SpendMoney(double value)
        {
            if (value <= _money)
            {
                _money -= value;
                Removed(this, value);
                return true;
            }
            else
            {
                Error(this, value);
                return false;
            }
        }

        public string GetInfo()
        {
            return $"{Name} {Family}";
        }
    }
}
