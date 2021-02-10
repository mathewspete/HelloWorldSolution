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

            var fullName = $"Firstname is {firstname} and lastname is {lastname}.";

            Console.WriteLine(fullName);


            var biggerScopeVar = 77;
            Console.WriteLine(biggerScopeVar);
            {
                var scopeVarible = 1;
                Console.WriteLine(scopeVarible);
                biggerScopeVar += 1;
                Console.WriteLine(biggerScopeVar);
            } // Scope 

            Console.WriteLine(biggerScopeVar);

            int? nullableInt = null;

            bool thisIsTrue = true;
            bool thisIsFalse = !thisIsTrue;

            int[] assessmentScores = new int[2];
            assessmentScores[0] = 110;
            assessmentScores[1] = 90;

            Console.WriteLine($"Score1 is {assessmentScores[0]} and Score2 is {assessmentScores[1]}.");

            string[] lang = { "Git/Github", "SQL", "C#", "Javascript", "Angular" };
            Console.WriteLine(lang[0]);
            Console.WriteLine(lang[1]);
            Console.WriteLine(lang[2]);
            Console.WriteLine(lang[3]);
            Console.WriteLine(lang[4]);
        }
    }
}