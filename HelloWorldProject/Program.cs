//Notes
using System;

namespace HelloWorldProject {

    class Program {

        static void Main(string[] args) {
            var firstname = "Pete";
            var lastname = "Mathews";
            var fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);

            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

            var biggerScopeVar = 77;
            Console.WriteLine(biggerScopeVar);
            {
                var scopeVarible = 1;
                Console.WriteLine(scopeVarible);
                biggerScopeVar += 1;
                Console.WriteLine(biggerScopeVar);
            } // Scope 

            Console.WriteLine(biggerScopeVar);

        }
    }
}