//ftastemur c_sharp proje-1 2011

using System;
using System.IO;
namespace Uzay1
{
    class Stack
    {
        public string[] yigitdizisi;
        public int indeks;
        public int uzunluk;

        public Stack(int boyut)
        {
            uzunluk = boyut;
            yigitdizisi = new string[uzunluk];
            indeks = 0;
        }
        public void Push(string ekle)
        {
            if (indeks == uzunluk )
                Console.WriteLine("Yigit dolu");
                
            yigitdizisi[indeks++] = ekle;
            
        }

        public string Pop()
        {
            if (indeks == 0)           
                Console.WriteLine("Yigit bos");
            
            return yigitdizisi[--indeks];
        }

        public bool isEmpty()
        {
            return indeks == 0;
        }

        public string Peek()
        {
            return yigitdizisi[indeks-1];
        }
       
    }
    class YiginSinifi1
    {
        public static void Main(string[] args)
        {

            dosyaOkuma("C:\\kaynak.txt");
            Console.ReadLine();
        }
        
        public static void dosyaOkuma(string yeri)
        {
            Stack yigin1 = new Stack(10);
            Stack yigin2 = new Stack(10);
            FileStream fs = new FileStream(yeri, FileMode.Open);
            int OkunanByte;
            string a = "";
            string metin = "";
            bool c = false;
            bool t = false;
            bool b_cift = false;
            bool u_buyut = false;
            bool h_yazma = false;
            bool hata = false;
            int j = 0;//parantezler arası karakter sayısı
            while ((OkunanByte = fs.ReadByte()) != -1)
            {
                if ((char)OkunanByte == '>')
                {
                    t = false;
                    if (j == 2)
                    {
                                              
                        if (yigin1.isEmpty())
                        {
                            hata = true;
                            break;
                        }
                        string x = yigin1.Pop();                      
                       
                        if (x != a[1].ToString())
                        {
                            hata = true;
                            break;
                        }
                        if (a[1] == 'b')
                            b_cift = false;
                        if (a[1] == 'u')
                            u_buyut = false;
                        if (a[1] == 'h')
                            h_yazma = false;
                        if (a[1] == 'p' & !u_buyut)
                        {
                            metin += "]";
                            if (b_cift)
                                metin += "]";
                        }  
                    }
                    else//j==2 durumunun else'i
                    {

                        if (a[0] == 'b')
                            b_cift = true;
                        if (a[0] == 'u')
                            u_buyut = true;
                        if (a[0] == 'h')
                            h_yazma = true;
                        if (a[0] == 'p' & !u_buyut)
                        { 
                                metin += "[";
                                if (b_cift)
                                    metin += "[";
                            
                        }
                        yigin1.Push(a[0].ToString());
                    }
                    a = "";
                    j = 0;
                }

                if (t)
                {
                    j += 1;
                    a += (char)OkunanByte;
                }
                if ((char)OkunanByte == '<')
                {
                    c = true;
                    t = true;
                }
                if (c | h_yazma) 
                { }
                else if (u_buyut)
                {

                    char l = (char)OkunanByte;
                    string x = l.ToString();
                    metin += x.ToUpper();
                    if (b_cift)
                        metin +=x.ToUpper();

                }
                else if (b_cift)
                {
                    metin = string.Concat(metin, (char)OkunanByte, (char)OkunanByte);
                }

                else
                    metin += (char)OkunanByte;
                if (!t)
                    c = false;
            }
            if (hata | !yigin1.isEmpty())
                Console.WriteLine("Kaynak dosyanin bicimleme etiketleri hatalidir,kontrol ediniz.");
            else 
            {
                while (true)
                {
                    int sonuc = metin.IndexOf("[]");
                    if (sonuc == -1)
                        break;
                    metin = metin.Remove(sonuc, 2);
                }
                Console.Write(metin);
            }
            Console.ReadLine();
        }
    }
}
