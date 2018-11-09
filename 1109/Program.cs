using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1109
{
    class Program
    {
        //INTERFACE FOGALMA


        static void Main(string[] args)
        {

            


            Dvd d = new Dvd("Star Ward IV", 210);
            Dvd d2 = new Dvd("Star Ward V", 180);
            Dvd d3 = new Dvd("Star Ward VI", 200);
            //Kolcsonozheto d = new Dvd("Star Ward IV", 210);


            Kolcsonozheto k = new Konyv("Harry Potter", "J K Rowling", "sth");


            var katalogus = new List<Kolcsonozheto>();

            katalogus.Add(d);
            katalogus.Add(d2);
            katalogus.Add(d3);
            katalogus.Add(new Konyv("Harry Potter", "J K Rowling","125642"));
            katalogus.Add(new Ujsag("Kiskegyed", 2018, 11));


            var dvdk = new List<Dvd>();
            dvdk.Add(d);
            dvdk.Add(d2);
            dvdk.Add(d3);

            d3.Cim ="SWVI";


            foreach (var e in dvdk)
            {
                Console.WriteLine(e.MegjelenitendoNev() + " " + e.FutasIdoOra());
            }
            dvdk.Sort();
            foreach (var e in dvdk)
            {
                Console.WriteLine(e.MegjelenitendoNev() + " " + e.FutasIdoOra());
            }



            /* Console.WriteLine(dvdk[0].FutasIdoOra());

             Console.WriteLine(katalogus[0].MegjelenitendoNev());
             Console.WriteLine(katalogus[1].MegjelenitendoNev());
             Console.WriteLine(katalogus[2].MegjelenitendoNev());*/

            Console.ReadLine();

        }
    }
}
