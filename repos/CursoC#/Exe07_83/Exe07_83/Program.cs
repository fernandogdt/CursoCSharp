using System;

namespace Exe07_83
{
    class Program
    {
        static void Main(string[] args)
        {

       //     DateTime d = new DateTime (1983, 06, 12, 11 , 0, 0);
            DateTime x = DateTime.Now;
     //       DateTime y = DateTime.Today;
            DateTime h = DateTime.Parse("12/06/1983");
         //   DateTime h1 = DateTime.Parse(Console.ReadLine());

            TimeSpan res = new TimeSpan();

            /*
            Console.WriteLine(d.Year);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(h);
            */
         //   Console.WriteLine(h1);
            res = x - h;
            Console.WriteLine("Dias: " + res.Days);
            Console.WriteLine("Horas: " + res.TotalHours.ToString("F2"));
            Console.WriteLine("Minutos: " + res.TotalMinutes);
            Console.WriteLine(res.TotalDays);

            Console.WriteLine("--------------");

            TimeSpan t1 = new TimeSpan(1, 30, 0);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = TimeSpan.FromHours(3.5F);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);


        
        
        
        }
    }
}
