

namespace Ex_03_07.Modules;

/// <summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{
    public int ItemNo { get; set; }      // 商品番号
    public string ItemName { get; set; } = ""; // 商品名
    public int Price { get; set; }       // 単価 

    public void Print()
    {
        Console.WriteLine("商品番号 = " + ItemNo);
        Console.WriteLine("商品名 = " + ItemName);
        Console.WriteLine("単価 = " + Price);
    }


}
