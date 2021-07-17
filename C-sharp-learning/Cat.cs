using System;
namespace C_sharp_learning
{
    public class Cat:Animal
    {
        // Đây là những property của một con mèo cần có
        // tuỳ thuộc vào từng con mèo khác nhau mà giá trị sẽ khác nhau

        // tính chất encapsulation là gì?
        //những thứ liên quan tới 1 đối tượng nhất định sẽ được gom chung lại
        //với nhau (giống như là con mèo thì sẽ có những cái thuộc tính)
        //nhằm phân biệt 2 đối tượng khác nhau
        //dễ quản lý, dễ kiểm soát, không bị rò rỉ, che giấu thông tin 

        //khai báo class -> từ class tạo nên đối tượng
        //khai báo property, method, ...

        // phạm vi truy cập -> access modifier private, public, protected
        //public : ai cũng truy cập được, bất kỳ đâu cũng truy cập được
        //private : chỉ số ít liên quan mới truy cập được, cụ thể là chỉ
        //có những thứ thuộc về class đó mới có quyền truy cập
        //protected : giống private nhưng bao gồm cả lớp dẫn xuất (lớp kế thừa)

        //khi khai báo property / method phải đi kèm với access modifier

        // có khuôn mẫu -> có thực thể. đối với class => object
        // constructor chính là cách khởi tạo một đối tượng cụ thể từ một lớp 


        public Cat(string name,int age,float mass, float width, float height)
            : base(name,age,mass,width,height)
            //tận dụng constructor đã được tồn tại ở Animal
        {
            this.species = "cat";
        }

        public Cat():base()
        {

        }

        //method : phương thức / hành động của object
        // polymerization
        public override void run()
        {
            Console.WriteLine("Cate is running");
        }

    }
}
