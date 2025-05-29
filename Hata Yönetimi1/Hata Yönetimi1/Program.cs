using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                {
                    throw new Exception("Negatif sayı giremezsiniz!");
                }

                Console.WriteLine($"Girdiğiniz sayı: {sayi}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
