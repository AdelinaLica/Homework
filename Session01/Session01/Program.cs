using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    // Why struct and not class?
    public struct Animal
    {
        public String nume;
        public String sunet;

// TODO: 
// 1. the method name does not reflect what it realy does(set is more appropiate)
// 2. the name of varibles should not be abreviated
// 3. Why do you need a getter/setter if the "nume", "sunet" are public
// 4. Be consitent using the english or romanian (english recommended)
// 5. For method naming conventions please check the following articles:
        // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions#naming-conventions
        public void getValues(string n, string s)
        {
            nume = n;
            sunet = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Even though the result is as expected, OOP is not used (inheritance is not used, encapsulation)
            Animal animal = new Animal();
            
            // break the encapsulation of the Dog or Cat objects; hint: try to create a class for each animal.
            String[] a = { "dog", " cat", " frog" };
            String[] b = { "ham-ham", "miau-miau", "oac-oac" };

            // what happens if the a has more items then b
            // please never ever use just letters for variable names (only in loops, e.g. "i" in for)
            for (int i = 0; i < a.Length; i++)
            {
                animal.getValues(a[i], b[i]);
                Console.WriteLine(animal.nume + " makes " + animal.sunet);
            }
        }
    }
}
