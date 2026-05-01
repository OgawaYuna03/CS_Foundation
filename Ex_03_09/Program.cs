using Ex_03_09.Modules;
namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("口座番号を入力してください->");
        account.AccountNo = Console.ReadLine();
        Console.WriteLine("口座名義を入力してください->");
        account.AccountName = Console.ReadLine();
        Console.WriteLine("残高を入力してください");
        account.Balance = int.Parse(Console.ReadLine);
        Console.WriteLine("ポイントを入力してください->");
        account.Point = int.Parse(Console.ReadLine());

        NetAccount netAccount = new NetAccount(no!,name!,balance,point);

    }
}
