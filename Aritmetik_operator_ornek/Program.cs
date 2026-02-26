namespace Aritmetik_operator_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sinav1 = 50;
            //int sinav2 = 60;
            //int ort = (sinav1 + sinav2) / 2;
            //Console.WriteLine($"Ortalamaniz: {ort}");
            int faturatutari,komisyon;
            double kdvoran, odenecektutar, toplamtutar;
            faturatutari = 500;
            komisyon =25;
            kdvoran = 0.15;
            odenecektutar = (faturatutari * (1+kdvoran));
            toplamtutar = odenecektutar + komisyon;
            Console.WriteLine($"Ödenecek Tutar:{toplamtutar}");
            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
