using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet6._5
{
    class OptionalParamenterExample
    {
        void printMessage(String message ="Hello user")
        {
            Console.WriteLine("{0}", message);
        }
        static void Main(string[] args)
        {
            OptionalParamenterExample opExemple = new OptionalParamenterExample();
            opExemple.printMessage("Welcome User! ");
            opExemple.printMessage();
            Console.ReadKey();
        }
    }
}
