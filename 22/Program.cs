// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ConsoleClear();
ConsoleWrite("Введите число N: ");
int N = int.Parse(ConsoleReadLine());

for (int i = 1; i <= N; i++)
{
    ConsoleWrite($"{i * i} ");
}