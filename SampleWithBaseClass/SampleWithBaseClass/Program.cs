using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWithBaseClass
{
    class Net
    {
        public int _value = 6;
    }

    class Perl : Net
    {
        public new int _value = 7;
        public void write()
        {
            Console.WriteLine(base._value);
            Console.WriteLine(this._value);
        }
    }

    class Program
    {
        static void Main()
        {
            Perl perl = new Perl();
            perl.write();
            Console.ReadLine();

        }

    }
}
