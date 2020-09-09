using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;
        private string _location;
        private int _speed;

        public CeilingFan(string location)
        {
            _location = location;
            _speed = OFF;
        }

        public void high()
        {
            _speed = HIGH;
            Console.WriteLine("speed switch to high");
        }

        public void medium()
        {
            _speed = MEDIUM;
            Console.WriteLine("speed switch to medium");
        }

        public void low()
        {
            _speed = LOW;
            Console.WriteLine("speed switch to low");
        }

        public void off()
        {
            _speed = OFF;
            Console.WriteLine("speed switch to off");
        }

        public int getSpeed()
        {
            return _speed;
        }
    }
}
