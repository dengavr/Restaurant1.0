using Restaurant.DAL;
using Restaurant.Entities;
using System;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantDataStore str = new RestaurantDataStore("Conn");
            Product p = str.Products.FindById(1);
            p.Name = "skldjslkdjkldslkdjskldjslkdjslkdjlskdjskld";
            str.Products.Update(p);
            Console.ReadLine();
        }
    }
}
