internal class Program
{
    private static void Main(string[] args)
    {
        //string str = "123";//gia tri dau vao de chuyen doi
        //int ketQua; //bien luu ket qua sau chuyen doi
        //bien kiem tra chuyen doi co thanh cong hay khong
        //bool kiemTra = false;
        //chuyen doi kieu du lieu
        //kiemTra = int.TryParse(str,out(ketQua));
        //System.Console.WriteLine("ket qua = " + ketQua);
      string str = "123";//gia tri dau vao de chuyen doi
      //chuyen doi kieu du lieu string (gia tri ="123")
      //sang kieu du lieu int(gia tri sau khi chuyen di = 123)
      int a = Convert.ToInt32(str);
      System.Console.WriteLine("a = " + a);
    }
}
