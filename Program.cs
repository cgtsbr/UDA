using System;
class Program
{
    static void Main(string[] args)
    {
        int seg, h, m, s;  //intentação
        Console.WriteLine("Duração em segundos:");
        seg = int.Parse(Console.ReadLine());    //3666
        h = seg / 3600;                         //3666/3600 = 1
        m = (seg % 3600) / 60;                  //(66)/60 = 1
        s = (seg % 3600) % 60;                  //(66)%60 = 6
        Console.WriteLine("{0}h:{1}m:{2}s",h, m, s);
        Console.ReadKey();
    }
}
