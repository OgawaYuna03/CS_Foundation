namespace Ex_03_04.Modules;

static public class Employee()
{
    public int Id { get; set; } //社員番号を表すプロパティ
    public string? Name { get; set; }   //名前を表すプロパティ
    public string? Address { get; set; }    //住所を表すプロパティ
    public Employee(int id, string name, string address)	//引数の値をプロパティに設定
    {
        this.id = id;
        this.name = name;
        this.address = address;

    }
    public override string ToString();
    {

    }
}