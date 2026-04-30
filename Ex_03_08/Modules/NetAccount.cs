using Ex_03_08.Modules;

namespace Ex_03_08.Modules;

public class NetAccount : Account
{
    public int Point { get; set; }
    public void Printt()
    {
        Console.WriteLine("ポイント:" + Point);
    }
}