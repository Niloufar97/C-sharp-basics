using System;

namespace Inheritance
{
    public abstract class BaseCustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Cost { get; set; }

        // Abstract method must be overridden in derived classes
        public abstract void UpdateAddress(string address);

        // Virtual method can be overridden, but provides a default implementation
        public virtual double UpdateCredit(double cost)
        {
            this.Cost = cost;
            double result = cost + 10;
            return result;
        }
    }

    public class NormalCustomer : BaseCustomer
    {
        public override void UpdateAddress(string address)
        {
            this.Address = address;
            Console.WriteLine(address);
        }

        public override double UpdateCredit(double cost)
        {
            this.Cost = cost;
            double result = cost + 10;
            return result;
        }
    }

    public class SpecialCustomer : BaseCustomer
    {
        public override void UpdateAddress(string address)
        {
            this.Address = address;
            Console.WriteLine($"new address {address}");
        }

        public override double UpdateCredit(double cost)
        {
            this.Cost = cost;
            double result = cost + 50;
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            BaseCustomer normalCustomer = new NormalCustomer();
            normalCustomer.UpdateAddress("123 Main St");
            Console.WriteLine(normalCustomer.UpdateCredit(100));

            BaseCustomer specialCustomer = new SpecialCustomer();
            specialCustomer.UpdateAddress("456 Elm St");
            Console.WriteLine(specialCustomer.UpdateCredit(100));
        }
    }
}
