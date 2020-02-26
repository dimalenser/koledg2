using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimapr3clasu
{
    

    class Program
    {
        public class Currency
        {
            private string Name; // назва валюти;
            private double ExRate; // курс(дробове число - кількість гривень та копійок, що дають за одну
            public Currency()
            {
                Name = "Unknown";
                ExRate = 0;
            }

            public Currency(string _Name, double _ExRate)
            {
                Name = _Name;
                ExRate = _ExRate;
            }

            public Currency(string _Name)
            {
                Name = _Name;
                ExRate = 0;
            }
            public void setName(string newName)
            {
                Name = newName;
            }

            public void setExRate(double newExRate)
            {
                ExRate = newExRate;
            }

            public string getName() { return Name; }
            public double getExRate() { return ExRate; }

            public Currency(Currency obj)
            {
                Name = obj.getName();
                ExRate = obj.getExRate();
            }

        }

        public class Product
        {
            private string Name;    // назва товару;
            private double Price;   // вартість одиниці товару;
            private Currency Cost;  // грошова одиниця, у якій вимірюється вартість(об’єкт типу Currency);
            private int Quantity;   // кількість наявних товарів на складі;
            private string Producer;// назва компанії-виробника;
            private double Weight;  // вага одиниці товару.

            public Product()
            {
                Name = "Unknown";
                Price = 0;
                Quantity = 0;
                Producer = "Unknown";
                Weight = 0;
            }

            public Product(string _Name, double _Price, string CostName, double CostExrate, int _Quantity, string _Producer, double _Weight)
            {
                Name = _Name;
                Price = _Price;
                Cost = new Currency(CostName, CostExrate);
                Quantity = _Quantity;
                Producer = _Producer;
                Weight = _Weight;
            }

            public Product(string _Name)
            {
                Name = _Name;
                Price = 0;
                Quantity = 0;
                Producer = "UnKnown";
                Weight = 0;
            }

            
            public void setName(string newName)
            {
                Name = newName;
            }

            public void setPrice(double newPrice)
            {
                Price = newPrice;
            }
            public void setQuantity(int newQuantity)
            {
                Quantity = newQuantity;
            }
            public void setProducer(string newProducer)
            {
                Producer = newProducer;
            }

            public void setWeight(double newWeight)
            {
                Weight = newWeight;
            }

            public string getName() { return Name; }
            public double getPrice() { return Price; }
            public int getQuantity() { return Quantity; }
            public string getProducer() { return Producer; }
            public double getWeight() { return Weight; }

            public void GetInfo()
            {
                Console.WriteLine($"name =  {getName()} price = {getPrice()}");
            }
            
            public void GetPriceInUAH()
            {
                Console.WriteLine($"name =  {getName()} price = {getPrice()}");
            }
            
            public void GetTotalPriceInUAH()
            {
                Console.WriteLine($"name =  {getName()} count = {getQuantity()} totalprice = {getPrice()* getQuantity()}");
            }
            
            public void GetTotalWeight()
            {
                Console.WriteLine($"name =  {getName()} count = {getQuantity()} Total Weight = {getWeight() * getQuantity()}");
            }

            public Product(Product obj)
            {
                Name = obj.getName();
                Price = obj.getPrice();
                Cost = new Currency(obj);
                Quantity = obj.getQuantity();
                Producer = obj.getProducer();
                Weight = obj.getWeight();
        }

        }
        static void Main(string[] args)
        {
            Product dima = new Product("PUBG", 600, "dollars", 25, 2, "Ukraine", 20);

            dima.GetInfo();
            dima.GetTotalPriceInUAH();
            Console.ReadKey();

        }
    }
}
