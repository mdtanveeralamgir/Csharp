using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    struct Customers
    {
        private string name;
        private double balance;
        private string id;

        public void createCustomer(string name, string id, double balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

        public void showCustomer()
        {
            Console.WriteLine("This is {0}, with id {1}. He has a balance of {2}", name, id, balance);
        }
    }
    
    class Program
    {
        

        static void Main(string[] arg)
        {
            Customers opel = new Customers();
            opel.createCustomer("Opel", "133", 4000);
            opel.showCustomer();
           
        }
    }
}
