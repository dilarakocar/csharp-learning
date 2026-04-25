using System;
class Program
{
static void Main(string[] args)
{
ConsoleKeyInfo tus;
Console.Write("Klavyeden bir tusa basiniz :");
tus = Console.ReadKey(true);
Console.WriteLine();
Console.WriteLine(tus.Key.ToString() + " tusuna bastiniz");
}
}