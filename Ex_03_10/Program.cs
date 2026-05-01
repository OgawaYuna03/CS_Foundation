using System.Net.Http.Headers;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Ex_03_10.Modules;

interface IProgram
{
    void Play();
    void Stop();
}

static class Program : IProgram
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("DVDのタイトルを入力してください->");
        string name = Console.ReadLine();
        Player player1 = new DVDPlayer(name);

    }
}
