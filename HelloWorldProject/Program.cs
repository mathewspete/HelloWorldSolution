//Notes
using System;

namespace HelloWorldProject {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello World in C#!");
            Console.WriteLine("C# Written by Pete Mathews");

            var counter = 0;
            Console.WriteLine(counter);
            counter += 13;
            Console.WriteLine(counter);
            counter -= 3;
            Console.WriteLine(counter);
            counter = counter * 5;
            Console.WriteLine(counter);
            var counterx = counter;
            Console.WriteLine("counterx = " + counterx);
            Console.WriteLine(counter);
            counter = counter / 7 * 7;
            Console.WriteLine(counter);
            counter = counter / 7;
            Console.WriteLine(counter);
            counterx = counterx % 7;
            Console.WriteLine(counterx);


            var firstname = "Pete";
            var lastname = "Mathews";
            var fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);

            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

        }
    }
}