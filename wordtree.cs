//ftastemur c_sharp proje-2 2011


using System;

namespace uzay
{
    public class Node
    {
        public string val = null;
        public Node[] list;
    }
    public class KelimeAgaci
    {
        public Node root;
        public string[] dizi;
        public KelimeAgaci()
        {
            root = new Node();
            root.val = "kök";
            root.list = new Node[26];
        }

        public int find(char x)
        {
            return Convert.ToInt16(x) - 97;
        }

        public void KelimeEkle(string key, string val)
        {
            Node[] takas = root.list;
            int i = 0;
            foreach (char x in key)
            {
                i = find(x);
                if (takas[i] == null)
                {
                    takas[i] = new Node();
                    takas[i].list = new Node[26];
                    takas = takas[i].list;
                }
                else
                    takas = takas[i].list;
            }
            // döngü ile düğümlerin en sonuna yani anahtar kelimenin
            // en son harfine geldik şimdi düğüm oluşturup kelime ekleyelim
            try
            {
                takas[i].val = takas[i].val + ";" + val;
            }
            catch
            {
                takas[i] = new Node();
                takas[i].list = new Node[26];
                takas[i].val = val;
            }
        }
        public string AnlamBul(string key)
        {
            Node[] takas = root.list;
            int i = 0;
            foreach (char x in key)
            {
                i = find(x);
                if ((takas[i] != null))
                    takas = takas[i].list;
                else
                    return "[kelime bulunamadi]";
            }
            return takas[i].val;
        }
        public void KelimeSil(string key)
        {
            Node[] takas = root.list;
            int i = 0;
            foreach (char x in key)
            {
                i = find(x);
                if ((takas[i] != null))
                    takas = takas[i].list;
            }
            // burada bir eksiğimiz var daha önceden silindi
            // mesajını nasıl verebiliriz ?
            takas[i].val = null;
        }
    }

    class Program
    {
        static void Main()
        {
            KelimeAgaci sozluk = new KelimeAgaci();
            sozluk.KelimeEkle("legal", "yasal");
            sozluk.KelimeEkle("leg", "bacak");
            sozluk.KelimeEkle("a", "bir");
            sozluk.KelimeEkle("legend", "efsane");
            sozluk.KelimeEkle("leg", "dik kenar");
            Console.WriteLine("leg : {0}", sozluk.AnlamBul("leg"));
            Console.WriteLine("bell : {0}", sozluk.AnlamBul("bell"));
            Console.WriteLine("a : {0}", sozluk.AnlamBul("a"));
            Console.WriteLine("legend : {0}", sozluk.AnlamBul("legend"));
            Console.WriteLine("legal : {0}", sozluk.AnlamBul("legal"));
            sozluk.KelimeSil("legal");
            Console.WriteLine("legal : {0}", sozluk.AnlamBul("legal"));
            //Console.ReadLine();
        }
    }
}

