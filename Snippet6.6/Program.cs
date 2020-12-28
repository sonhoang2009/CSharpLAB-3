using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
static class Product
{
    static int _productID;
    static double _price;
    static Product()
    {
        _productID = 10;
        _price = 156.32;
    }

    public static void Display()
    {
        Console.WriteLine("Product ID: " + _productID);
        Console.WriteLine("Product Price:  " + _price);
    }
}
namespace Snippet6._6
{
    class Medicine
    {

        static void Main(string[] args)
        {
            Product.Display();
            Console.ReadKey();
        }
    }
}
