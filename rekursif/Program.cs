using System;

namespace rekursif
{
    class Program
    {
        static void Main(string[] args)
        {
        metotlar volki=new();


            Console.WriteLine("**** Rekursif Metot Ornegi Us Aldırma");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(volki.usalma(3,i));
        }


        string v="resistance is futile, you will be assimilated";
        Console.WriteLine("resistance is futile, you will be assimilated");
        if(v.boslukkont())
        Console.WriteLine("evt cumlede de bosluk var");
        
        Console.WriteLine("bosluklari birlestirelim");
        Console.WriteLine(v.boslukbirles());

        Console.WriteLine("tüm harfler büyük olsun");
        Console.WriteLine(v.buyukyap());
        Console.WriteLine(v);

        Console.WriteLine("tüm harfler kücük olsun");
        Console.WriteLine(v.kucukyap());
        Console.WriteLine(v);

        Console.WriteLine("ref ile kullanmayi hatırlayalım");
        int c=3,d=4;  // ref elemanların orjinal değerlerini degistiriyor
        Console.WriteLine(volki.topla(ref c,ref d));
        Console.WriteLine(c);
        Console.WriteLine(d);

        Console.WriteLine("**** int array sıralama ****");
        int[] sayilar={90,50,40,30,21,34};
        Console.WriteLine("sayi dizisinin orjinal hali");
        foreach (var x in sayilar)
        {
            Console.WriteLine(x);
            
        }
        sayilar.dizisirala();
        Console.WriteLine("sayi dizisinin extension ile sirali hali");
        foreach (var x in sayilar)
        {
            Console.WriteLine(x);
            
        }
        Console.WriteLine("sayimiz tek mi cift mi");
        int z=9,u=6;
        Console.WriteLine(z.ciftmi());
        Console.WriteLine(u.ciftmi());

        Console.WriteLine("stringin ilk karakterinin bulma");
        Console.WriteLine(v.ilkk());

        }
        

        
    }
    class metotlar
    {
        public int usalma (int sayi,int us)
        {
        if(us<2)
        return sayi;
            
        return usalma(sayi,us-1)*sayi;
        }

        public int topla(ref int a,ref int b)
        {
            a++;
            b++;
            return a+b;
        }
        

    }
    public static class  Extension
    {
        public static bool boslukkont(this string a)
        {
            return a.Contains(" ");
        }

        public static string boslukbirles (this string a)
        {
            string[] b=a.Split(" ");

            return string.Join("",b);
        }

        public static string buyukyap(this string a)
        {
            return a.ToUpper();
        }
        public static string kucukyap(this string a)
        {
            return a.ToLower();
        }

        public static int[] dizisirala(this int[] a)
        {
            Array.Sort(a);
            return a;
        }

        public static bool ciftmi(this int a)
        {
            
          return a%2==0;
        }

        public static string ilkk(this string a)
        {
            return a.Substring(0,1);
        }
    }
}
