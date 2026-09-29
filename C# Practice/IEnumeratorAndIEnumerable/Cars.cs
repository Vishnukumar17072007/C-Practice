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

    public class CarEnumerator : IEnumerator<string>
    {
        private string[] _cars;
        private int _position = -1;

        public CarEnumerator(string[] cars)
        {
            _cars = cars;
        }
        public string Current => _cars[_position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _cars.Length;
        }

        public void Reset() => _position = -1;

        public void Dispose() { }
    }
}
