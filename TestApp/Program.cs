using TestApp.Models
public class program
{
     private static void Main(string[] args)
     {
        Students Demo = new Students();
        //Khoi tao 2 doi tuong tu class students
        Person ps1 = new Person();
        person ps2 = new Person();
        //gan gia tri thuoc tinh doi tuong ps
        ps1.FullName = "Vo Hong Quan";
        ps2.FullName = "Vo Quyet";
        ps1.Address = "Ha Noi";
        ps2.Address = " Ha Tinh";
        ps1.Age = "22";
        ps2.Age = "25";
        //goi phuong thuc hien thong tin
        ps1.Display();
        ps1.Display();


     }
}