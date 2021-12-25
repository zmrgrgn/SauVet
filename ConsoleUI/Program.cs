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
            HayvanKayitManager hayvanKayitManager = new HayvanKayitManager(new EfHayvanKayitDal());
            foreach (var hayvanKayit in hayvanKayitManager.GetAll())
            {
                Console.WriteLine(hayvanKayit.Ad);
            }
        }
    }
}
