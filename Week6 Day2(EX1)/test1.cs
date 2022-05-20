using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Day2_EX1_
{
    class test1
    {
      
            public void method1()
            {
                Console.WriteLine("i am method1");
            }
       
    
        static void Main(string[] args)
        {
            test1 t1 = new test1();
            t1.method1();
            t1.method2();
        }
    }
}
