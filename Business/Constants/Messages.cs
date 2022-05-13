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
        public static string HayvanSahiplendirmeAdded = "Hayvan Sahiplendirme Kayıt Edildi";
        public static string BelediyeBilgiAdded = "Belediye Bilgi Kayıt Edildi";
        public static string HayvanTedaviAdded = "Hayvan Tedavi Kayıt Edildi";
        public static string VatandasBilgiAdded = "Vatandaş Bilgileri Kayıt Edildi";
        public static string KafesNoAdded = "Kafes Bilgileri Kayıt Edildi";
        public static string HayvanTurAdded = "Hayvan Türü Bilgileri Kayıt Edildi";

        public static string HayvanKayitListed = "Hayvanlar listelendi";
        public static string BelediyeBilgiListed = "Belediyeler listelendi";
        public static string HayvanSahiplendirmeListed = "Hayvan sahiplendirme listelendi";
        public static string HayvanTedaviListed = "Hayvan tedavileri listelendi";
        public static string MamaListed = "Mamalar listelendi";
        public static string VatandasBilgiListed = "Vatandaşlar listelendi";
        public static string KafesNoListed = "Kafesler listelendi";
        public static string HayvanTurListed = "Hayvan türleri listelendi";

        public static string HayvanKayiUpdated = "Hayvan kayıt güncellendi";
        public static string BelediyeBilgiUpdated = "Belediye güncellendi";
        public static string HayvanSahiplendirmeUpdated = "Hayvan sahiplendirme güncellendi";
        public static string HayvanTedaviUpdated = "Hayvan tedavisi güncellendi";
        public static string MamaUpdated = "Mama güncellendi";
        public static string VatandasBilgiUpdated = "Vatandaş güncellendi";
        public static string KafesNoUpdated = "Kafes Bilgisi güncellendi";
        public static string HayvanTurUpdated = "Hayvan Türü güncellendi";

        public static string HayvanKayitDeleted = "Hayvan kayıt silindi";
        public static string BelediyeBilgiDeleted = "Belediye silindi";
        public static string HayvanSahiplendirmeDeleted = "Hayvan sahiplendirme silindi";
        public static string HayvanTedaviDeleted = "Hayvan tedavisi silindi";
        public static string MamaDeleted = "Mama silindi";
        public static string VatandasBilgiDeleted = "Vatandaş silindi";
        public static string KafesNoDeleted = "Kafes Numarası silindi";
        public static string HayvanTurDeleted = "Hayvan Türü silindi";

        public static string HayvanNameInvalid = "Hayvan Adı Geçersiz";
        public static string MaintenanceTime = "Bakım saati";
        public static string OfKafesError = "En fazla 10 hayvan eklenebilir";
        public static string IdAlreadyExists = "Id numaraları aynı olamaz";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string PasswordError = "Parola hatası.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string PasswordChanged = "PasswordChanged";
        public static string UserUpdated = "UserUpdated";
        public static string UserNotExist = "UserNotExist";
        public static string UserEmailNotAvailable = "UserEmailNotAvailable";
    }
}
