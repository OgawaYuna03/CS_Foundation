namespace Ex_03_11.Modules;

public class Mouse : IUSB
{
    public void SendData()    // 繋がっている装置にデータを送る機能の抽象メソッド
    {
        Console.WriteLine("PCにマウスの移動情報を送信しました");
    }

    public void ReciveData()	// 繋がっている装置からデータを受け取る機能の抽象メソッド
    {
        Console.WriteLine("NotImplementedExceptionをスローする");
    }
}