namespace Ex_02_06;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("数値を入力してください->");
        int num;
        num = int.Parse(System.Console.ReadLine());

        if (num % 4 == 0)
        {
            System.Console.WriteLine("4の倍数です。");
        }
        else
        {
            System.Console.WriteLine("4の倍数ではありません。");

        }
    }
}
