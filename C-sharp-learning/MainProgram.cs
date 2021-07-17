using System;

namespace C_sharp_learning
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            Animal bucky = new Cat("Bucky",4,5,30,7);

            Animal tom = new Cat("Thomas",2,8,20,6);

            Animal buck = new Dog("Buck", 4, 5, 30, 7);

            Animal jerry = new Dog("Jerome", 2, 8, 20, 6);

//Đây không phải đa hình !NOT Polymerization
//Khi nói về đa hình thì phải đi kèm với kế thừa và override
            bucky.run();
            tom.run();

            buck.run();
            jerry.run();

            bucky.introduce();
            tom.introduce();
            buck.introduce();
            jerry.introduce();
        }
    }
}
