namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("値を入力して下さい->");
        int inputNum = int.Parse(System.Console.ReadLine());
        Console.WriteLine(Mul3(inputNum));


        int Mul3(int num)
        {
            return num * 3;
        }


    }
}
