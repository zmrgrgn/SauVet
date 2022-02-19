using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HayvanTedavi: IEntity
    {
        public int Id { get; set; }
        public string HayvanId { get; set; }
        public int HekimId { get; set; }
        public string TedaviBaslik { get; set; }
        public string TedaviDetay { get; set; }
        public string TedaviTarih { get; set; }
        public string Bulgular { get; set; }
        public string Notlar { get; set; }
        public string OlduMu { get; set; }
        public string OlumNedeni { get; set; }
    }
}
