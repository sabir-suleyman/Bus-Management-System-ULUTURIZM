## Bu Dosyayı başka dillerde oku:
<a href="README.md"><img src="https://img.shields.io/badge/-ENGLISH-red?style=for-the-badge"></a>
<a href="README.tr.md"><img src="https://img.shields.io/badge/-T%C3%9CRK%C3%87E-red?style=for-the-badge"></a>

# Takım Üyeleri

| İsim                  | GitHub Kullanıcı Adı                                |
|-----------------------|-----------------------------------------------------|
| Sabir Süleymanlı      | [sabir-suleyman](https://github.com/sabir-suleyman) |
| Zeynep Uysal          | [zeynep-u](https://github.com/zeynep-u)             |
| Zeynep Kılınçer       | [zkilincer](https://github.com/zkilincer)           |
| İrem İÇÖZ             | [irem0](https://github.com/irem0)                   |
| Ferit Yiğit BALABAN   | [fybx](https://github.com/fybx)                     |
| Mine KORKMAZ          | [minekorkmazz](https://github.com/minekorkmazz)     |
| Helin GÜL             | [ihelingul](https://github.com/ihelingul)           |
| Damla SOYDAN          | [damlas21](https://github.com/damlas21)             |
| Fatma Büşra TİLKİ     | [fatmabusratilki](https://github.com/fatmabusratilki)|
| Fatma Nur AYYILDIZ    | [fatmanur01](https://github.com/fatmanur01)         |

# Projenin Başlığı: ULU TURİZM (Bir Otobüs Firmasından Daha Fazlası)
Bir otobüs firmasının rezervasyon ve bilet kayıtlarını tutmak için kullanılacak olan bir yazılım projesidir.

# 1. GİRİŞ
## 1.1 Amaç
**Kolay Bilet Satın Alma**: Kullanıcılara otobüs biletlerini kolaylıkla satın alma imkânı sağlamak. Bilet Satış Platformu: Otobüs firmasına bilet satışı için bir platform sağlamak. 
**Kullanıcı Deneyimini İyileştirme**: Kullanıcıların seyahat planlarını kolaylaştırmak ve deneyimlerini geliştirmek. 
**Bilet Arama ve Rezervasyon**: Kullanıcıların seyahat tarihleri,  kalkış ve varış noktaları, otobüs sınıfları gibi tercihlerine göre bilet arama ve rezervasyon yapma özelliği.
**Koltuk Seçimi**: Kullanıcıların seyahat edecekleri otobüste tercih ettikleri koltuğu seçebilme özelliği.
**Bildirimler ve İletişim**: Kullanıcılara rezervasyon onayları, bilet hatırlatmaları, sefer iptalleri gibi önemli bildirimlerin sağlanması için anlık bildirimler ve iletişim kanalları.

## 1.2. İş-Zaman Çizelgesi

[image]

## 1.3 Proje Gereksinimleri: 

1- *Otobüs Seferleri Yönetimi*:
Otobüs seferlerinin eklenmesi, düzenlenmesi ve silinmesi.
Seferlerin tarih, saat, güzergah, kalkış ve varış noktaları gibi bilgilerinin kaydedilmesi.

2- *Yolcu Bilgileri Yönetimi*:
Yolcuların ad, soyad, cinsiyet, yaş gibi kişisel bilgilerinin kaydedilmesi.
Yolcuların bilet bilgilerinin tutulması.
Yolcuların bilet iptal işlemlerinin yapılması.

3- *Otobüs ve Koltuk Yönetimi*:
Otobüslerin ve koltukların bilgilerinin kaydedilmesi.
Boş ve dolu koltukların takibi ve gösterimi.
Rezervasyon yapıldığında dolu koltukların işaretlenmesi.

[image]

# 2. YÖNTEM

## 2.1. Uygulama Aşaması 
- Projenin gerçekleştirilmesi için gerekli kaynaklar temin edildi
- Proje için gerekli planlamalar yapıldı
- Proje plana uygun şekilde ilerletildi
- Proje süreci düzenli olarak takip edildi ve ilerleme raporlandı
- Sorunlar tespit edildi ve çözüm süreçleri yönetildi

## 2.2. Tasarım

Arayüz Tasarımı:

Uygulamanın arayüzü WinForms (Windows Forms), Microsoft'un .NET Framework platformu için geliştirdiği bir GUI teknolojisi kullanarak oluşturulmuştur ve geliştirilmesinde .NET 6.0 sürümü kullanılmıştır. Toplamda 2 pencereden oluşan arayüz, kullanıcının giriş yaparken gerekli olan kişisel bilgilerini girebilmesi, istediği yere istediği zamanda bilet oluşturabilmesi ve oluşturduğu biletleri silebilmesi gibi önemli işlemleri gerçekleştirebilmesine olanak sağlamaktadır. 

[photo]

Bilet oluşturma sırasında açılan bir diğer pencerede yolculuk sırasında kullanıcının oturacağı koltuğu seçebilmesi ve koltuk durum bilgisine(boş koltuklar - yeşil, dolu koltuklar - kırmızı) erişebilmesi için tasarlanan butonlar yer almaktadır, bu butonlar sayesinde kullanıcı oturmak istediği koltuğu hızlı bir şekilde tek tıkla seçebilmektedir. 

[image]

# 3. UYGULAMA
**Otobüs Sınıfı**:
Bir otobüs sınıfı yazıldı. Bu sınıf, otobüsün özelliklerini ve davranışlarını içerir ve bilet işlemlerini yönetmek amacıyla kullanılacak.

Sefer: Otobüsün Sefer nesnesiyle ilişkilendirildiği bir özellik. Sefer nesnesi, otobüsün güzergahını ve diğer sefer bilgilerini içerir.

bos_koltuklar ve dolu_koltuklar: Boş koltukları ve dolu koltukları temsil eden ağaç yapıları. Bu
ağaçlar, otobüsteki koltukların durumunu izlemek için kullanılır.

BiletAl(int koltukNo): Belirtilen koltuk numarasına sahip koltuğun rezerve edilmesini sağlayan bir fonksiyon. İlgili koltuğun bos_koltuklar ağacından çıkarılıp dolu_koltuklar ağacına eklenir.

BiletSil(int koltukNo): Belirtilen koltuk numarasına sahip koltuğun rezervasyonunun iptal edilmesini sağlayan bir fonksiyon. İlgili koltuğun dolu_koltuklar ağacından çıkarılıp bos_koltuklar ağacına eklenir.

Otobüs nesneleri oluşturularak koltuk durumları takip edilebildi ve bilet alımı veya iptali gibi işlemler gerçekleştirildi.

**Bilet Sınıfı**:
Bir bilet sınıfı yazıldı. Bu sınıf, bir biletin özelliklerini ve bilgilerini içerir.
Biletin sahibinin ad soyad, kimlik numarası, cinsiyeti, yaşı gibi özellikleri temsil eder.
Bilet(string kisiAdSoyadi, string kimlikNo, int biletID, bool cinsiyet, string epostaAdresi, Otobus otobus, Sefer sefer): Bu metot, biletin özelliklerini parametre olarak alır ve ilgili özelliklere değer ataması yapar.

**Sefer Sınıfı**:
Bir sefer sınıfı yazıldı.  Bu sınıf, bir seferin başlangıç ve varış noktalarını temsil eder. 
Seferin başlangıç ve varış noktasını temsil eden bir sınıftır. 
Sefer(AnVeMekan kalkis, AnVeMekan varis): Bu metot, seferin başlangıç noktası ve varış noktası bilgilerini parametre olarak alır ve ilgili özelliklere değer ataması yapar.

**An ve Mekan Sınıfı**:
Bir an ve mekan sınıfı yazıldı. Bu sınıf, bir mekanı ve bir zamanı temsil etmek için kullanılır.
AnVeMekan(Mekan mekan, DateTime an): Bu metot, bir Mekan nesnesi ve bir DateTime değeri alır ve ilgili özelliklere değer ataması yapar.

**HashMap Sınıfı**:
Bir HashMap sınıfı yazıldı. Bu sınıf, bir hash table veri yapısını temsil eder.
HashMap(int bucketCount = 16): Bu metot, bir parametre olarak koltuk sayısını alır ve bucketCount alanına atanır. Varsayılan olarak koltuk sayısı 16 olarak belirlenmiştir. Ayrıca, buckets alanı için bir liste dizisi oluşturulur ve her bir liste örneği ile doldurulur.
HashFunction adında bir özel metod tanımlanır.
BiletSil adında bir genel metot tanımlanır. Bu metot, belirli bir anahtarı kullanarak bir elemanı tablodan siler.


**Bilet oluşturma**:
counter adında bir global değişken tanımlandı ve başlangıç değeri olarak 0 atandı. Bu değişken, her bilet oluşturulduğunda birer birer artırılacak bir sayaç görevi görür.
OlusturBilet adında fonksiyon tanımlandı. Bu fonksiyon, bilet oluşturma işlemlerini içerir ve herhangi bir geri dönüş değeri yoktur.
Üç ayrı ComboBox bileşeninden seçilen metinleri ilgili değişkenlere atar. Bu değişkenler, biletin nereden, nereye ve sefer bilgilerini tutar.
counter değeri, Id adlı bir değişkene atandı ve ardından counter bir bir artırıldı. Böylece her yeni bilet oluşturulduğunda Id değişkeni bir öncekinden farklı bir değer alır.


**Otobüs Konteyner Sınıfı**: 
VeriYapilari isim alanı içinde OtobusKonteyner adında bir sınıf yazıldı. 
OtobusKonteyner adında genel erişime açık bir sınıf tanımlar. Bu sınıf TekYonluDugum<Otobus> sınıfından türetilmiştir.
OtobusKonteyner(Otobus otobus) : base(otobus): Bu metot, bir Otobus nesnesi alır ve temel sınıfın yapıcı metoduna bu nesneyi ileterek çalışır. Ayrıca, Otobus özelliğine de bu nesneyi atar


**İller/Terminaller Listesi**: 
Burada bağlı liste kullanılarak şehirler ve bu şehirlere ait terminalleri depolama işlemini gerçekleştirildi.Bağlı liste , verilerin düzenli bir şekilde depolanmasını ve erişilmesini sağlayan veri yapısıdır. Otobüs firmasının iller ve terminalleri için bağlı liste kullanılması, verilerin hiyerarşik bir yapıda depolanmasını ve hızlı bir şekilde erişilmesini sağlar. 
Terminal sınıfı, bir terminale ait isim ve sonraki terminale işaret eden bir referans içerir. Bu sayede bir şehre ait birden fazla terminal olabileceği gibi, her terminalin bir sonraki terminali göstermesi de sağlanmış olur.
City sınıfı, bir şehrin adı, bu şehrin terminallerini depolamak için bir Terminal nesnesi ve bir sonraki şehre işaret eden bir referans içerir. AddTerminal metodu, bir şehre yeni bir terminal eklemek için kullanılır. Eğer terminaller listesi boş ise, yeni bir terminal oluşturulur ve listenin başlangıcı olarak atanır. Aksi takdirde, son terminale ulaşıncaya kadar terminaller listesi taranır ve son terminalin sonraki referansı yeni terminal olarak atanır.
BusCompany sınıfı, tüm şehirleri depolamak için bir City nesnesi ve bu şehirleri eklemek, bulmak gibi işlemler yapmak için gerekli metotları içerir. AddCity metodu, yeni bir şehir eklemek için kullanılır. Eğer şehirler listesi boş ise, yeni bir şehir oluşturulur ve listenin başlangıcı olarak atanır. Aksi takdirde, son şehre ulaşıncaya kadar şehirler listesi taranır ve son şehrin sonraki referansı yeni şehir olarak atanır.
FindCity metodu, bir şehrin adını belirtilen ve o şehri bulmak için kullanılır. Eğer belirtilen şehir adına sahip bir şehir mevcutsa, bu şehir döndürülür. Aksi takdirde, null değeri döndürülür.


**Otobüs Listesi Sınıfı**:
VeriYapilari isim alanında OtobusListesi adında bir sınıf yazıldı. 
OtobusListesi adında bir sınıf tanımlar. Bu sınıf, TekYonluBagliListe<OtobusKonteyner> sınıfından türetilmiştir.
Bas özelliği, listenin başını temsil eder ve OtobusKonteyner türünden bir nesneyi veya null değerini alabilir. 
Bu sınıf, otobüs konteynerlerini bir bağlı liste yapısında tutmak için kullanılır.


**Bilet Listesi Sınıfı**:
VeriYapilari isim alanında BiletListesi adında bir sınıf yazıldı.
BiletListesi adında bir sınıf tanımlar. Bu sınıf, TekYonluBagliListe<BiletKonteyner> sınıfından türetilmiştir.
Bas özelliği, listenin başını temsil eder ve BiletKonteyner türünden bir nesneyi veya null değerini alabilir. Bu sınıf, bilet konteynerlerini bir bağlı liste yapısında tutmak için kullanılır.


# 4. TEST VE DEĞERLENDİRME
Proje gereksinimlerinin bir kısmı başarıyla yerine getirildi ve test edildi. Kodun okunaklı ve anlaşılır olduğu değerlendirildi. Veri yapıları ve algoritmalar doğru seçildi ve uygulandı. İşlevlerin hatalı veya beklenmedik sonuçlar döndürmediği de test edildi. Uygulamanın performansı ölçüldü ve değerlendirildi. Kullanıcının uygulamayı kolayca kullanabildiği test edildi. Kodun güncelleştirilmesi ve bakımı için uygun bir yapıya sahip olduğu da değerlendirildi.


# 5. SONUÇ (TARTIŞMA VE SONUÇ)
Geliştirme süreci boyunca proje gereksinimleri ve müşteri beklentileri doğrultusunda çalışıldı. Kodun okunaklı ve anlaşılır olması, veri yapılarının doğru seçimi ve algoritmaların etkin kullanımı gibi teknik detaylar, proje değerlendirmesinde dikkate alındı.
Kullanıcı dostu bir arayüz tasarımı ile kullanıcının uygulamayı kolayca kullanabilmesi sağlandı. Uygulamanın bakımı ve güncelleştirilmesi için uygun bir yapıda olduğu da değerlendirildi.
Proje aşamasında, sınıfların birbirleriyle uyumlu şekilde bağlanması ve arayüzle entegre edilmesi konusunda zorluklar yaşandı. Özellikle, veri yapıları ve algoritmaların doğru seçilmesi, verilerin uygun şekilde yönetilmesi ve işlenmesi için çok sayıda farklı sınıf oluşturuldu. 
Ancak, bu sınıfların birbirleriyle uyumlu hale getirilmesi ve arayüzle entegre edilmesi zaman alıcı ve zorlu bir süreç haline geldi.Bu zorlukların üstesinden gelmek için, öncelikle projenin gereksinimlerinin doğru şekilde belirlendi ve tasarlandı. Ardından, her bir sınıfın işlevleri ve görevleri belirlendi ve bu sınıfların birbirleriyle uyumlu hale getirilmesi için gerekli bağlantılar kuruldu.

