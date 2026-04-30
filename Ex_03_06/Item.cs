using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Ex_03_06;

/// <summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{
    public int itemNo;      // 商品番号
    public string itemName; // 商品名
    public int price;       // 単価
    public double salesTaxRate = 0.10; //消費税率

    public Item()
    {
    }

    public Item(int pitemNo, string pitemName, int pprice)
    {
        itemNo = pitemNo;
        itemName = pitemName;
        price = pprice;
    }

    public void Print()
    {
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"単価={price}");
    }
    public void ChangePrice(int pprice)
    {
        price = pprice;
    }

    public int CalculateTaxAmount()
    {
        double result = price + (price * salesTaxRate);
        return (int)result;
    }

}
