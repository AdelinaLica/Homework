using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    class Animal
    {
        public String name;
        public String sound;

        public void getSounds()
        {
            String[] Sounds = { "ham-ham", "miau-miau", "oac-oac", "vrum-vrum" };
            for (int i = 0; i < Sounds.Length; i++)
            {
                if (Sounds[i].Equals(sound))
                    Console.WriteLine(name + " makes " + Sounds[i]);
            }
        }
    }

    class Dog : Animal
    {

        public Dog()
        {
            name = "Dog";
            sound = "ham-ham";
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            name = "Cat";
            sound = "miau-miau";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
          
            cat.getSounds();    
            dog.getSounds();     
        }
    }
}
