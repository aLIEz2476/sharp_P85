using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_P85
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100;//Boxing : 옵젝에 박음

            int b = (int)a;//Unboxing : 옵젝에다 박은 걸 형태에 맞게끔 꺼냄
            Console.WriteLine("Test\n{0}", b);
        }
    }
}
