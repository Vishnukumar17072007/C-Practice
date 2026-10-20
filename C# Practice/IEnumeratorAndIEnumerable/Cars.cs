using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace C__Practice.IEnumeratorAndIEnumerable
{
    public class Cars : IEnumerable<string>
    {
        string[] cars = { "Toyota", "Nissan", "Hummer" };
        public IEnumerator<string> GetEnumerator()
        {
            return new CarEnumerator(cars);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
