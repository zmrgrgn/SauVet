using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HayvanKayit: IEntity
    {
        public string Id { get; set; }
        public int? VatandasId { get; set; }
        public int? BelediyeId { get; set; }
        public int KafesNo { get; set; }
        public string CipNo { get; set; }
        public string KulakNo { get; set; }
        public string Ad { get; set; }
        public int HayvanTur { get; set; }
        public string Irk { get; set; }
        public string Yas { get; set; }
        public string Cinsiyet { get; set; }
        public string Esgal { get; set; }
        public string GebeMi { get; set; }
        public string GeldigiTarih { get; set; }
        public string GeldigiAdres { get; set; }
        public string Anamnez { get; set; }


    }
}
