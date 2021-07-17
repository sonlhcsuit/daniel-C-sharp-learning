using System;

namespace C_sharp_learning

{
    abstract public class Animal
    {
        protected string name;
        protected int age;
        protected float mass;
        protected float width;
        protected float height;
        protected string species;

        public Animal(string name, int age, float mass, float width, float height)
        {
            this.name = name;
            this.age = age;
            this.mass = mass;
            this.width = width;
            this.height = height;
        }

        public Animal()
        {

        }

        public abstract void run();
        

        public void introduce()
        {
            Console.WriteLine(String.Format(
                "I am a {0}, my name is {1}, I am {2} year old"
                , this.species, this.name, this.age));
        }

    }
}
