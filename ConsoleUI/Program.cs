using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            HayvanKayitManager hayvanKayitManager = new HayvanKayitManager(new EfHayvanKayitDal());
            foreach (var hayvanKayit in hayvanKayitManager.GetAll())
            {
                Console.WriteLine(hayvanKayit.Ad);
            }
        }
    }
}
