namespace Ex_03_08.Modules;

public class Account
{
    public string? AccountNo { get; set; }
    public string? AccountName { get; set; }
    public int Balance { get; set; }
    public void Print()
    {
        Console.WriteLine("口座番号:" + AccountNo);
        Console.WriteLine("口座名義:" + AccountName);
        Console.WriteLine("残高:" + Balance);
    }
}