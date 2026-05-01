namespace Ex_03_11.Modules;

public class Display : IUSB
{
    public void SendData()    // 繋がっている装置にデータを送る機能の抽象メソッド
    {
        Console.WriteLine("NotImplementedExceptionをスローする");
    }

    public void ReciveData()	// 繋がっている装置からデータを受け取る機能の抽象メソッド
    {
        Console.WriteLine("ディスプレイに表示する情報を受信しました");
    }
}