using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr9
{

    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(10);
            Fraction b = new Fraction(2);
            Fraction d = a-b;
            Console.WriteLine($"a = {a.get_digit()}");
            Console.WriteLine($"b = {b.get_digit()}");
            Console.WriteLine($"d = a -b = {d.get_digit()}");




            Console.ReadLine();
        }
    }
}