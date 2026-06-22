using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Person
    {
        public Guid _Id { get; set; }
        public string _Name { get; set; }
        public string _Surname { get; set; }
        public int _Age { get; set; }

        public Person(Guid ıd, string name, string surname, int age)
        {
            _Id = ıd;
            _Name = name;
            _Surname = surname;
            _Age = age; 
        }

    }
}
