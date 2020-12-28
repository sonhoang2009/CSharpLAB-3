using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet6._2
{
    class Book
    {
        string _bookName;
        //public string Print();
        //{
        ////return _bookName;
        //}
        public void Input(string bkName)
            {
                _bookName = bkName;
            }
        static void Main(string[] args)
        {
        Book objBook = new Book();
        objBook.Input("C# - The Complete Refence");
        Console.WriteLine(objBook.Print());
        }
    }
}
