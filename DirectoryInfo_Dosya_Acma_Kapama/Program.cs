using System;
using System.IO;

namespace DirectoryInfo_Dosya_Acma_Kapama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanılacak dizini tanımla.
            DirectoryInfo NewDir = new DirectoryInfo(@"C:\Test\TestDizini");
            try
            {
                //Dizinin var olup olmadığının kontrolü
                if (NewDir.Exists)
                {
                    Console.WriteLine("Dizin Mevcut.");
                    //Dizin silme işlemi
                    NewDir.Delete(true);
                    Console.WriteLine("Dizin Silindi.");
                }
                //Yeni dizin oluşturma
                NewDir.Create();
                //Klasör oluşturulduğunda sistem tarihi dönüyor.refresh yaptığımızda tarih güncelleniyor.
                NewDir.Refresh();
                Console.WriteLine("Klasör oluşturuldu.");
                Console.WriteLine("Oluşturma tarihi:" + NewDir.CreationTime);
                Console.WriteLine("Bulunduğu dizin adı:" + NewDir.Parent);
                Console.WriteLine("Dizinin adı:" + NewDir.Name);
                Console.WriteLine("Dizinin tam adı:" + NewDir.FullName);
                Console.WriteLine("Son erişim tarihi" + NewDir.LastAccessTime);
                Console.WriteLine("Son değiştirme tarihi:" + NewDir.LastWriteTime);
                Console.ReadLine();

                //Dizin içerisinde alt dizin oluşturma.
                DirectoryInfo SubDir = NewDir.CreateSubdirectory("AltDizin");
                //Alt dizin içerisinde alt dizin oluşturma 
                SubDir.CreateSubdirectory("AltDizin2");
                //GetFiles ile dizindeki dosyaların seçimi.
                Console.WriteLine("{0} dizinindeki dosya sayısı:{1}", NewDir.FullName, NewDir.GetFiles().Length);
                //GetDirectories ile dizindeki klasörlerin seçimi
                Console.WriteLine("{0} klasör dosya sayısı:{1}", NewDir.FullName, NewDir.GetFiles().Length);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("İşlem başarısız:{0}", e.ToString());
            }
            finally
            {

            }
        }
    }
}

