using System;
namespace C_sharp_learning
{
    public class Dog:Animal
    {

        //copy sẽ làm code trở nên dài và khó sửa
        //kế thừa -> khai báo 1 class cha, và mình có có nhiều class con
        //thuộc class cha đó thì những thuộc tính, những phương thức, sẽ được
        //tự động tồn mà không cần phải khai báo lại

        //private string name;
        //private int age;
        //private float mass;
        //private float width;
        //private float height;

        public Dog(string name, int age, float mass, float width, float height)
            :base(name, age, mass, width, height)
            //tận dụng constructor đã được tồn tại ở Animal
        {
         this.species = "dog";
        }

        // polymerization
        public override void run()
        {
            Console.WriteLine("Doge is running");
        }
    }

}
