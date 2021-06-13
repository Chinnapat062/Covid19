using System;

namespace Covid19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numofcity = int.Parse(Console.ReadLine());
            Console.WriteLine("Go to detail");

            citydetail();
        }


        static int prnter = 0;
        static int Geffaen = 1;
        static int Morroc = 2;
        static int Payon = 3;
        static int Albearta = 4;
        static int Aldebaran = 5;
        static int Yuno = 6;
        static int Izude = 7;


        static int cityId;
        static void citydetail()
        {
            Console.Write("City name :");
            string namecity = Console.ReadLine();

            if (namecity == "prnter")
            {
                cityId = 0;
            }

            else if (namecity == "Geffen")
            {
                cityId = 1;
            }
            else if (namecity == "Morroc")
            {
                cityId = 2;
            }
            else if (namecity == "Payon")
            {
                cityId = 3;
            }
            else if (namecity == "Alberta")
            {
                cityId = 4;
            }
            else if (namecity == "Al de baran")
            {
                cityId = 5;
            }

            else if (namecity == "Yuno")
            {
                cityId = 6;
            }
            else if (namecity == "Izude")
            {
                cityId = 7;
            }
            Console.WriteLine("your choosen city is {0}", namecity);


            int covidlevel = 0;
            int closecity = int.Parse(Console.ReadLine());
            int[] cityid = new int[closecity];

            for (int i = 0; i < cityid.Length; i++)
                cityid[i] = int.Parse(Console.ReadLine());
            foreach (int x in cityid)
            {
                while (x < 0 && x > 7)
                {
                    Console.WriteLine("invalid ID ");
                }
                even(ref namecity, ref cityId, ref covidlevel);
            }


        }


        static string city;
        static void even(ref string namecity, ref int ID, ref int covidlevel)
        {

            string even = Console.ReadLine();

            if (even == "Outbreak")
            {

                Console.WriteLine("CityID : {0}  Cityname : {1}  covidlevel : 2", ID, namecity);

            }
            else if (even == "Spread")
            {

                Console.WriteLine("CityID : {0}  Cityname : {1}  covidlevel : 1", ID, namecity);
            }
            else if (even == "Vaccinate")
            {
                Console.WriteLine("CityID : {0}  Cityname : {1}  covidlevel : {3}", ID, namecity, covidlevel);
            }
            else if (even == "Exit")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
            return;


        }




    

        

       


    }
    

   
}
