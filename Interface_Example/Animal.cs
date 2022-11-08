using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    interface IFirstInterface
    {
        void MyMthod();
    }
    interface IsecondInterface
    {
        void MyOtherMethod();
    }
    public  class Animal
    {
        public void MyMethod()
        {
            Console.WriteLine("some text");
        }
        public void MyOtherMethod()
        {
            Console.WriteLine("Some other text");
        }
    }
}
