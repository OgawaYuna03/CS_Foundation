namespace Ex_03_11.Modules;

public class FlashMemory : IUSB
{
    public void SendData()    // 繋がっている装置にデータを送る機能の抽象メソッド
    {
        Console.WriteLine("フラッシュメモリに記録してあるデータをPCに送りました");
    }

    public void ReciveData()	// 繋がっている装置からデータを受け取る機能の抽象メソッド
    {
        Console.WriteLine("PCのデータをフラッシュメモリに記録しました");
    }
}