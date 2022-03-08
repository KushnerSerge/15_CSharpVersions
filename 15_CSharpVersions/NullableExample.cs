using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CSharpVersions
{
    public  class NullableExample
    {
        // precondition with nameof
        private string name;
        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Name)} cannot be null");
        }

        public void exp()
        {
            int? a = 42;
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }
            // Output:
            // a is 42
            int? a1 = 28;
            int b = a1 ?? -1;
            Console.WriteLine($"b is {b}");  // output: b is 28
        }
    }
}
