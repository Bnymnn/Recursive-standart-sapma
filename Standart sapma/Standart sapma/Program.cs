using System;

namespace Standart_sapma
{
    class Program
    {
        public static int i,j,k,toplam,ortalama,çıkarma ;
        public static float toplamkare, karesi,varyans;
        public static int indisSayi;
        public static int[] sayılar;
       
        public static void indisGir()
        {
            Console.WriteLine("Kaç adet İndis olacağını belirleyiniz");
             indisSayi = Convert.ToInt32(Console.ReadLine());
            sayılar = new int[indisSayi];
        }
        public static void sayilarıAL()
        {
            if (i < indisSayi)
            {
                Console.WriteLine("\n"+(i + 1) + ". Değeri Giriniz");
                string x = Console.ReadLine();
                sayılar[i] = Convert.ToInt32(x);
                i = i + 1;
                sayilarıAL();
            }
            else if (i<indisSayi*2)
            {
                Console.Write("  Sayılar[" + (i-indisSayi) + "] = " + sayılar[i-indisSayi]);
                i++;
                sayilarıAL();

            }     
            else
                return;
           
        }
        public static void sayılarıToplaOrtala()
        {
            if (j < indisSayi)
            {
                int deger1 = sayılar[j];
                toplam = toplam + deger1;
                j++;
                sayılarıToplaOrtala();
            }
            else if (j==indisSayi)
            {
                ortalama = toplam / indisSayi;
                j++;
                sayılarıToplaOrtala();
            }
            else { 
                Console.WriteLine("\n================");           
                Console.WriteLine("Toplam değerler= " + toplam);
                Console.WriteLine("================");
                Console.WriteLine(" Ortalama = " + ortalama);
                Console.WriteLine("================");
                return;}
        }
        public static void ortalamaFarkKare()
        {
            if (k<indisSayi)
            {
                çıkarma = sayılar[k] - ortalama;
            Console.WriteLine("  " + k + ". İndisin ortalamadan farkı = " + çıkarma);
             karesi = çıkarma * çıkarma;
                toplamkare = toplamkare + karesi;
                k++;
                ortalamaFarkKare();
            }
            else
            {
                Console.WriteLine("================");
                Console.WriteLine("İndislerin karelerinin toplamı = " + toplamkare);
                Console.WriteLine("================");
                varyans = toplamkare / (indisSayi - 1);
                Console.WriteLine("Varyans değeri = "+varyans);
                Console.WriteLine("================");
                Console.WriteLine("Standart sapma = " +Math.Sqrt(varyans));
                return;
            }
                
            
        }
        static void Main(string[] args)
        {
            indisGir();
            sayilarıAL();
            sayılarıToplaOrtala();
            ortalamaFarkKare();

            
            
            
        }
    }
}
