namespace NewApp.Models
{
    public class Fruit
    {
        public string FruitID { get; set; }
       public string FruitName { get; set; } 
       public int HSD { get; set; }
       public void EnterData()
       {
        System.Console.Write("Ma = ");
        FruitID = Console.ReadLine();
        System.Console.Write("Ten  = ");
        FruitName = Console.ReadLine();
        System.Console.Write("HSD = ");
        HSD = Convert.ToInt16(Console.ReadLine());
       }
        public void Display()
       {
        System.Console.WriteLine("Ma: {0} - Ten: {1} - HSD: {2} ngay",FruitID,FruitName,HSD);
       }
    }
}