using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dersnotu
{
    class Program
    {
        class Ozellik
        {
           public static void Kisi()
           {
             Console.Write("Adınızı giriniz: ");
             string ad=Console.ReadLine();
             Console.Write("Soyadınızı giriniz: ");
             string soyad=Console.ReadLine();
             Console.Write("Üniversitenizi giriniz: ");
             string uni=Console.ReadLine();

           }
              enum Puan {İyi,Kötü};
             struct Yazar
             {
                 public string ad;
                 public string soyad;
                 public char numara;
             }
        
        public class Filmler
        {
                   public string Yerli;
                   public string Yabancı;
        }
         
         class Turler:Filmler
         {

                   public void Anlat()
                   {
                       Console.WriteLine("{0} 6 Tane Yerli Film ve {1} 6 Tane Yabancı Filmim Vardır. ",Yerli,Yabancı);
                       Console.ReadLine();
                   }
         }

         class Uye
         {
         public string Ad{ get;set;}
         public virtual void CikisYap()
         {

             Console.WriteLine(this.Ad+ "Çıkış Yaptım");
         }
         }

         class Admin:Uye
         {
             public override void CikisYap()
             {
                  base.CikisYap();
                  Console.WriteLine(this.Ad+ "Çerezleri Temizledim.");
             }
         }
   
         int girilenyas;
         public  int Yasgir
         {
          get{return girilenyas;}
           set
           {
            if (girilenyas>18)
            {
                Console.WriteLine("İyi Seyirler");
            }
            else
            {
                Console.WriteLine("Üzgünüm Size Uygun Değil");
            }
           }
          }
          public const int yenikayit=20;
         
        static void Main(string[] args)
        {
           Console.WriteLine("**********************");
            Console.WriteLine();
            Console.WriteLine(" Yerli Filmler Kategorisi         Yabancı Filmler Kategorisi          ");
            Console.WriteLine();
            Console.WriteLine(" 1-Dağ: Alper Çağlar              7-Avatar: James Cameron             ");
            Console.WriteLine();
            Console.WriteLine(" 2-Recep İvedik: Şahan Gökbakar   8-Hızlı ve Öfkeli: Ken Li           ");
            Console.WriteLine();
            Console.WriteLine(" 3-Annem: Ayşe Balıbey            9-Alacakaranlık: Melissa Rosenberg  ");
            Console.WriteLine();
            Console.WriteLine(" 4-Hababam Sınıfı: Rufat Ilgaz    10-Anakonda: Onika Maraj            ");
            Console.WriteLine();
            Console.WriteLine(" 5-Zengo: Yasemin Sakallıoğlu     11-Minyonlar: Brian Lynch           ");
            Console.WriteLine();
            Console.WriteLine(" 6-Eltilerin Savaşı: Gupse Ozay   12-Şirinler: Peyo                   ");
            Console.WriteLine();
            Console.WriteLine("İşlemler Menüsü: ");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama\n2-Yeni İzleyici Kaydı\n3-Mevcut Mu?\n4-Film Sitesine Uygun Musunuz?\n5-Yazarlarla İlgili İzleme Deneyimi\n6-Fimlerin Değerlendirilmesi\n7-Film IMDB Verme\n8-Film Türü Bilgisi\n9-Çıkış");
            Console.WriteLine();
            Console.WriteLine("İşlemini Yapmak İstediğiniz Menü: ");
            char islem=Convert.ToChar(Console.ReadLine());
            if (islem=='1')
            {
                Console.WriteLine();
                Console.WriteLine("Fiyatını öğrenmek istediğiniz filmin numarasını giriniz: ");
                string numara=Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.Write(" Dağ: 8 TL"); break;

                    case "2": Console.Write(" Recep İvedik: 10 TL"); break;

                    case "3": Console.Write(" Annem: 6 TL "); break;

                    case "4": Console.Write(" Hababam Sınıfı: 13 TL"); break;

                    case "5": Console.Write(" Zengo: 7 TL "); break;

                    case "6": Console.Write(" Eltilerin Savaşı: 15 TL "); break;


                    case "7": Console.Write(" Avatar 13 TL"); break;

                    case "8": Console.Write(" Hızlı ve Öfkeli: 16 TL"); break;

                    case "9": Console.Write(" Alacakaranlık: 9 TL "); break;

                    case "10": Console.Write(" Anakonda: 12 TL"); break;

                    case "11": Console.Write(" Minyonlar: 7 TL "); break;

                    case "12": Console.Write(" Şirinler: 10 TL "); break;
                    default: Console.WriteLine("Böyle film mevcut değildir!"); break;
                }
            
                
            }
            else if (islem=='2')
            {
                Console.WriteLine();
                Ozellik.Kisi();
                Console.WriteLine("Kaç Kişi Kayıt Yapabilir: "+yenikayit);
                
            }
            else if (islem=='3')
            {
               Console.WriteLine();
               ArrayList Film=new ArrayList();
               for (int i = 1; i <=12; i++)
               {
                  if (Film.Contains(i))
                  {
                      Console.Write("Mevcut");
                  }
                  else Console.Write("Mevcut değil");
               }
            }
           else  if (islem=='4')
            {
                Console.WriteLine();
               Ozellik ys=new Ozellik();
               Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
               ys.Yasgir=int.Parse(Console.ReadLine());
               Console.WriteLine(ys.Yasgir);
                            
            }
           else if (islem=='5')
            {
                Console.WriteLine();
                 Yazar[] yazarlar = new Yazar[12];
                for (int i = 1; i <=12; i++)
                {
                    yazarlar[i].ad=Console.ReadLine();
                    yazarlar[i].soyad=Console.ReadLine();
                    yazarlar[i].numara=Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Yazar hakkında beğeni yazısı yazınız: ",i);
                    string dusunce=Console.ReadLine();
                }          
            }
           else if (islem=='6')
            {
                Console.WriteLine();
                byte i;
                i=Convert.ToByte(Console.ReadLine());
               
               Puan deger;
               deger=(Puan)i;
               Console.WriteLine("Puan:  "+deger);

            }
            else if (islem=='7')
            {
                Console.WriteLine();
                
                double [] sayi={9.9,8.8,6.6,7.7,5.5,4.4,9,8,8.6,9.2,8.3,6.9,7.3};
                foreach (int eleman in sayi)
                {
                     Console.WriteLine("Hangi Filmi İzledidiniz: ");
                    string sonuc=Console.ReadLine();
                    Console.WriteLine( " Filme IMDB Veriniz: ");
                    int imbd=Convert.ToInt32(Console.ReadLine());
                    if (eleman>5.5)
                    {
                        Console.WriteLine("Film Kalitesi Güzel"+eleman);
                    }
                    else
                    {
                        Console.WriteLine("Sanırım Beğenmediniz: "+eleman);
                    }
                    Console.WriteLine(eleman);
                   
                }
                
            }
            else if (islem=='8')
            {
                Console.WriteLine();
                Turler film =new Turler();
                film.Anlat();
                
            }
            else if (islem=='9')
            {
                Console.WriteLine();
                Uye uye =new Uye{ Ad= "Sinem "};
                Admin admin=new Admin {Ad = "Alperen "};
                uye.CikisYap();
                admin.CikisYap();
            }
            else
            {
                Console.WriteLine("Yanlış menü değeri girdiniz!");
                
            }

            Console.ReadKey();
         
        }

        }
    
    }
  
}
