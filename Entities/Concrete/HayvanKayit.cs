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
        public string KafesNo { get; set; }
        public string CipNo { get; set; }
        public string KulakNo { get; set; }
        public string Fotograf { get; set; }
        public string Ad { get; set; }
        public string HayvanTur { get; set; }
        public string Irk { get; set; }
        public string Yas { get; set; }
        public bool? Cinsiyet { get; set; }
        public string Esgal { get; set; }
        public bool? GebeMi { get; set; }
        public DateTime? GeldigiTarih { get; set; }
        public string GeldigiAdres { get; set; }
        public string Anamnez { get; set; }
        public int? VatandasId { get; set; }
        public int? BelediyeId { get; set; }

    }
}
