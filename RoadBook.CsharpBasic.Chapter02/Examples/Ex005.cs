using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex005
    {
        public void Run()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";

            bool isContainsword01 = objHello.ToString().Contains("Hello");
            bool isContainsword02 = vHello.ToString().Contains("Hello");
            bool isContainsword03 = dHello.ToString().Contains("Hello");

            Console.WriteLine("isContainsword01 : {0}", isContainsword01);
            Console.WriteLine("isContainsword02 : {0}", isContainsword02);
            Console.WriteLine("isContainsword03 : {0}", isContainsword03);
        }
    }
}
