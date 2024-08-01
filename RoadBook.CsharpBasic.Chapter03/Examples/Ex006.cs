using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex006
    {
        public void Run()
        {
            Console.Write("숫자를 입력하세요 : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number}는 양수입니다.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number}는 음수입니다.");
            }
            else
            {
                Console.WriteLine($"{number}은 zero입니다.");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number}는 짝수입니다.");
            }
            else
            {
                Console.WriteLine($"{number}는 홀수입니다.");
            }
        }
    }
}
