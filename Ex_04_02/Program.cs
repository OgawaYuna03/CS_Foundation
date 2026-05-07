namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("年を入力してください->");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"{year}は閏年です。");
        }
        else
        {
            Console.WriteLine($"{year}は閏年ではありません。");
        }

    }
}
