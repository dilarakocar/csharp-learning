using System;
using static System.Collections.Specialized.BitVector32;
class Program
{
    static void Main(string[] args)
    {
        Random yer = new Random();
        Console.SetWindowSize(50, 20);
        for (int i = 0; i < 100; i++)
        {
            int satir = yer.Next(1, 19);
            int sutun = yer.Next(1, 29);
            Console.SetCursorPosition(sutun,satir);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("+");
            System.Threading.Thread.Sleep(150);
        }
    }
}