using System;
using System.Collections.Generic;
using System.Text;

namespace pr9
{
    class Fraction
    {
        private double digit;
        public Fraction()
        {
            digit = 0;
        }

        public Fraction(double d)
        {
            digit = d;
        }

        public void toString()
        {
            Console.WriteLine($"Digit in string - {digit}");
        }
        public double get_digit()
        {
            return digit;
        }

        public void set_digit(double d)
        {
            digit = d;
        }
        public static Fraction operator +(Fraction obj1, Fraction obj2)
        {
            Fraction frac = new Fraction();
            frac.set_digit(obj1.get_digit() + obj2.get_digit());
            return frac;
        }

        public static Fraction operator -(Fraction obj1, Fraction obj2)
        {
            Fraction frac = new Fraction();
            frac.set_digit(obj1.get_digit() - obj2.get_digit());
            return frac;
        }

        public static Fraction operator *(Fraction obj1, Fraction obj2)
        {
            Fraction frac = new Fraction();
            frac.set_digit(obj1.get_digit() * obj2.get_digit());
            return frac;
        }

        public static Fraction operator /(Fraction obj1, Fraction obj2)
        {
            Fraction frac = new Fraction();
            frac.set_digit(obj1.get_digit() / obj2.get_digit());
            return frac;
        }

    }

}
