using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string HayvanKayitAdded = "Hayvan Kayıt Edildi";
        public static string MamaAdded = "Mama Kayıt Edildi";
        public static string HekimAdded = "Hekim Kayıt Edildi";
        public static string HayvanSahiplendirmeAdded = "Hayvan Sahiplendirme Kayıt Edildi";
        public static string BelediyeBilgiAdded = "Belediye Bilgi Kayıt Edildi";
        public static string HayvanTedaviAdded = "Hayvan Tedavi Kayıt Edildi";
        public static string VatandasBilgiAdded = "Vatandaş Bilgileri Kayıt Edildi";

        public static string HayvanKayitListed = "Hayvanlar listelendi";
        public static string BelediyeBilgiListed = "Belediyeler listelendi";
        public static string HayvanSahiplendirmeListed = "Hayvan sahiplendirme listelendi";
        public static string HayvanTedaviListed = "Hayvan tedavileri listelendi";
        public static string HekimListed = "Hekimler listelendi";
        public static string MamaListed = "Mamalar listelendi";
        public static string VatandasBilgiListed = "Vatandaşlar listelendi";

        public static string HayvanKayitDeleted = "Hayvan kayıt silindi";
        public static string BelediyeBilgiDeleted = "Belediye silindi";
        public static string HayvanSahiplendirmeDeleted = "Hayvan sahiplendirme silindi";
        public static string HayvanTedaviDeleted = "Hayvan tedavisi silindi";
        public static string HekimDeleted = "Hekim silindi";
        public static string MamaDeleted = "Mama silindi";
        public static string VatandasBilgiDeleted = "Vatandaş silindi";

        public static string HayvanNameInvalid = "Hayvan Adı Geçersiz";
        public static string MaintenanceTime = "Bakım saati";
        public static string OfKafesError = "En fazla 10 hayvan eklenebilir";
        public static string IdAlreadyExists = "Id numaraları aynı olamaz";
    }
}
