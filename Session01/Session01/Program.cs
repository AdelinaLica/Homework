using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    public struct Animal
    {
        public String nume;
        public String sunet;


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
            Animal animal = new Animal();
            String[] a = { "dog", " cat", " frog" };
            String[] b = { "ham-ham", "miau-miau", "oac-oac" };

            for (int i = 0; i < a.Length; i++)
            {
                animal.getValues(a[i], b[i]);
                Console.WriteLine("The " + animal.nume + " makes " + animal.sunet);
            }
        }
    }
}
