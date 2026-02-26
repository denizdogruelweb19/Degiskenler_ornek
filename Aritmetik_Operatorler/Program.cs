namespace Aritmetik_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 3 + 5;
            Console.WriteLine($"Toplam: {sum}");
            int a = 30;
            int b = 10;
            //fark
            int c = a - b;
            Console.WriteLine($"{a} - {b}={c}");
            //çarpım
            int d = a * b;
            Console.WriteLine($"{a} * {b}={d}");
            //bölüm
            int e = a / b;
            Console.WriteLine($"{a} / {b}={e}");
            //mod
            int f = a % b;
            Console.WriteLine($"{a} % {b}={f}");
            Console.ReadKey();
        }
    }
}
