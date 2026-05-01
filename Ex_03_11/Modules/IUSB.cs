namespace Ex_03_11.Modules;

public interface IUSB
{
    public void SendData();    // 繋がっている装置にデータを送る機能の抽象メソッド
    public void ReciveData();	// 繋がっている装置からデータを受け取る機能の抽象メソッド
}