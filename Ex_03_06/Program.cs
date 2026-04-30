using System.Net.ServerSentEvents;
using System.Security.Cryptography;

namespace Ex_03_06;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();
        Console.Write("商品番号を入力してください->");
        item.itemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください->");
        item.itemName = int.Parse(Console.ReadLine());
        Console.Write("単価を入力してください");
        item.price = 123;
        Console.Write("新しい単価を入力してください");

        item.ChangePrice(int.Parse(Console.ReadLine()));
        Console.WriteLine("結果");
        item.Print();

        Console.WriteLine("更に新しい単価を入力してください");
        item.ChangePrice(Console.ReadLine());
        Console.WriteLine("結果");
        item.Print();
    }
}
