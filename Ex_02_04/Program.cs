namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
      int[] number = new int[3];
      Console.Write("数値1を入力してください->");
      number[0] = int.Parse(Console.ReadLine());
     
      Console.WriteLine("入力結果");
      Console.WriteLine($"数値1:{number[0]});

    }
}
