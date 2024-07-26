using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void Run()
        {
            int korean = 100;
            int english = 100;
            int math = 98;
            int sport = 97;

            int total = korean + english + math + sport;

            Console.WriteLine($"총점은 {total}입니다.");
            Console.WriteLine("평균 {0}", total / 4);
        }
    }
}
