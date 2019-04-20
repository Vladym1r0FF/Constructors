using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private List<BankAccount> accounts;
        public Person(string name, int age)
        {
            this.name = "No Name";
            this.age = age;
            this.accounts = new List<BankAccount>();
        }
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;    
            
        }
        public Person()
        {
            this.name = "Pesho";
            this.age = 21;

        }
        public Person(string name)
        {
            this.name = "No Name";
            this.age = 1;
        }
        public Person(int age)
        {
            name = "No Name";
            this.age = age;
        }
        public double GetBalance()
        {
            return this.accounts.Sum(x => x.Balance);
        }

    }
}
