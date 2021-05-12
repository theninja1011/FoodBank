using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBank
{
    public class Person
    {

        public DateTime Date { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int NumOfFam { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Income { get; set; }

        public Person() { }
        public Person(DateTime date, string name, DateTime birthday, int numOfFam, string county, string address, string phone, int income)
        {
            Date = date;
            Name = name;
            Birthday = birthday;
            NumOfFam = numOfFam;
            County = county;
            Address = address;
            Phone = phone;
            Income = income;
        }
    }
}
