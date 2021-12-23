using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Mama: IEntity
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string Ad { get; set; }
        public string MalzemeTur { get; set; }
        public int Sayi { get; set; }
        public string Birim { get; set; }
    }
}
