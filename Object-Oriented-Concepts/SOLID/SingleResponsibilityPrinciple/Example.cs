//THE GIST

//A class should never have more than one reason to change - Uncle Bob


//PROS of SRP
//https://app.pluralsight.com/player?name=pood-single-responsibility-principle&clip=0&course=principles-oo-design&author=steve-smith
//     -SRP enables higher cohesion and lower coupling.
//     -SPR allows for more flexible design



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