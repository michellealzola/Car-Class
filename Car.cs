using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    internal class Car
    {
        private int _year;
        private string _make;
        private double _speed;

        public Car(int year, string make)
        {
            _year = year;
            _make = make;
            _speed = 0;
        }

        public int Year { get { return _year; } }

        public string Make { get { return _make; } }

        public double Speed { get { return _speed; } }

        public void Accelerate()
        {
            _speed += 5;

           
        }

        public void Brake()
        {
            _speed -= 5;
        }

    }
}
