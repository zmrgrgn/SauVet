using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            HayvanKayitTest();
        }

        private static void HayvanKayitTest()
        {
            HayvanKayitManager hayvanKayitManager = new HayvanKayitManager(new EfHayvanKayitDal(),new HayvanTedaviManager(new EfHayvanTedaviDal()));
            var result = hayvanKayitManager.GetAll();
            if (result.Success==true)
            {
                foreach (var hayvanKayit in result.Data)
                {
                    Console.WriteLine(hayvanKayit.Ad);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
