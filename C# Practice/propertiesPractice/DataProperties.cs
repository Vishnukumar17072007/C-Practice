using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.propertiesPractice
{
    class DataProperties
    {
        private string name;
        private int age;
        private long phone;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.GetType() == typeof(string))
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if(value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age connot be zero or negative.");
                }
            }
        }
        public long Phone
        {
            get { return phone; }
            set
            {
                int count = 0;
                phone = value;
                while (phone > 0)
                {
                    count++;
                    phone = phone / 10;
                }
                if (count != 10)
                {
                    Console.WriteLine("Phone number must be 10 digit.");
                }
                else
                {
                    phone = value;
                }
            }
        }
        public string Email { get; set; }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Age: " + Age);
        }
    }
}
