namespace Ex_02_07;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("数値を入力してください");
        int num;
        num = int.Parse(System.Console.ReadLine());

        if(num > 0)
        {
            System.Console.WriteLine("正の値です。");
        }
        else if(num < 0)
        {
            System.Console.WriteLine("負の値です。");
        }
        else
        {
            System.Console.WriteLine("0です。");
        }
    }
}
