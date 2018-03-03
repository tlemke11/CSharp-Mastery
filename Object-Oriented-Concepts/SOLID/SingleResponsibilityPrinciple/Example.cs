//A class should never have more than one reason to change - Uncle Bob


//Don't Do THIS!
using System;
namespace Utils
{
    class Utils
    {
        private string hello = 'Hello Yall';

        public int add(int a, int b)
        {
            return a + b;
        }

        public string sayHi()
        {
            return this.hello;
        }
    }
}

//Do this