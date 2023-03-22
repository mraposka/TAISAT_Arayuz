# TaisatMARM-99
MARM-99 MODEL UYDU ARAYUZ PROGRAMI

Bu program 2022-2023 yılları arasında başvurulan Teknofest Model Uydu yarışmasında Taisat Marm-99 takımı için geliştirilmektedir.

Programın amacı uçuş süreci boyunca bazı verileri görselleştirmek ve gerektiği durumlarda sürece mudahale edebilmektir.

UYDUNUN ÖZELLİKLERİ
Model uydu, taşıyıcı ve payload olmak üzere iki ana bileşenden oluşur. Payload uçuşun belli bir bölümünde taşıyıcının içerisinde bulunur. Hem payload hemde taşıyıcının üzerinde bulunan sensörlerden veri alınır.

OPERASYON KONSEPTİ

1. Uydu roketle birlikte fırlatılır.

2. Belli bir yüksekliğe ulaşıldığında uydu roketten otonom bir şekilde ayrılacaktır. 

3. Uydu belli bir irtifaya alçaldığında taşıyıcısımdan otonom bir şekilde ayrılacaktır. Eğer ayrılma gerçekleşmezse arayüz üzerindeki bir buton ile manuel bir şekilde ayrılma gerçekleştirilir. 

4. Uçuş süresi boyunca hem taşıyıcıdan hem de payloadtan elde edilecek bütün veriler arayüze canlı olarak aktarılacaktır.

5. Uçuş boyunca gerçekleşecek olası hatalar işlenip arayüzde göterilecektir.


ARAYÜZÜN ÖZELLİKLERİ
Uydudan gelen verilerin görselleştirildiği bir programdır. Gelen veriler arayüzde işlenir ve kullaıcıya gösterilir. Bazı hata durumlarını kullanıcıya bildirir. Tek sayfadan oluşan arayüz veri alımı yaparken veri gönderimi de yapabilecek kapasitede olmalıdır.

GÖREV
Uçuş görevinde verilerin tranferinden ayrı olarak hakem heyetinin vereceği 500kb boyutundaki video payloada gönderilecektir. Ayrıca ekstra puan kazandıracak bonus görev olarak da payloada gönderilen video başka bir yer istasyonu bilgisayarına geri gönderilecektir.(zorunlu değil)
Bunlardan ayrı olarak gelen veriler belirtilen formatta hakem heyetinin verdiği belleğe kaydedilmesi gereklidir.

ARAYUZ BILESENLERI
Kamera: kullanilan kutuphane bilgisayara takilan dahili ve harici kameralari algilayip belirlenen alanda gosterir. Ayrica ayni kutuphane sayesinde goruntuyu istenilen konuma kayit edebiliyoruz. Tek sorun kayit yapilan goruntunun boyutu eger kameranin boyutundan fazla olarak yazdiysak kayit yapmiyor. Onu pencerenin boyutunu ele alarak otomatık bir şekilde ayarlayabiliriz veya bencere boyutunun kameranın boyutundan büyük olmayacağından emin olduğumuz bir boyut tanımlayabiliriz.

Harita: harita için google api yada mapvingis kütüphanesi kullanılabilir. Ben internet bağlantısı olmadan kullanılabildiği için mapvingis kullanmayı düşünüyordum. Şu an haritanın olduğu yerde bir tane picturebox var. Harita kullanılmadan önce o picturebox kaldırılmalıdır.

3d uydu hareketi simulasyonu: haritanın hemen sağ tarafında bulunan bölgede uydudan gelen açı bilgilerinin 3d simule edildiği yerdir. Bu bir kütüphane kullanılarak rahatlıkla yapılabilir. Bununla ilgili kütüphane ve nasıl yapıldığını anlatan videolar var. Linklerini bulduğumda yine buraya ekleyeceğim.

Comport ayarları: singleton kullanılarak yapılıyor. Ayarlanan değerler her seferinde tekrar tekrar ayarlamakla uğraşmamak için bir text dosyasına kaydediliyor. Boylece programi kapatip tekrar actigimizda program text dosyasindan en son ayarlanan comportu otomatik olarak cekip hazirda bulundurur.

Grafikler: gelen verilerin grafiksel olarak gösterimini sağlıyor. Her hangi bir kütüphaneye gerek duymuyor. Ama gösterilen bütün değerler backgroundworker kullanılarak arkaplanda yapılıyor. Ayrıca gelen verilerin sayısı arttıkça grafiklerde aynı anda gösterimi yapılmaya çalışıldığında işlemciye çok fazla yük bindiğini farkettim. Bende ilk 200 veriden sonra gelen her veri için ilk sıradan her seferinde 1 veri siliyorum. Böylece grafikler içerisinde aynı anda en fazla 200 tane veri gösteriliyor.

Verilerin kaydedilmesi: gelen veriler hem bilgisayara hemde hakem heyetinin verdiği belleğe kaydedilmesi gerekiyor. Veriler canlı olarak gelirken aynı anda bilgisayara kayıt edilmesini, ayrıca bütün uçuş bittikten sonra -daha sonra ekleyeceğim bir buton yardımı ile- kaydedilen bütün verilerin tek seferde hakem belleğine aktarılmasını sağlamayı planlıyordum. Henüz bu işlevi yapmadım.

Tablo görünümü: arayüzün alt tarafında bulunan bölgede gelen verilerin tablo halinde gösterimi yapılacaktır. Burada bir kütüphane kullanılarak aynı veriler excel formatında dışarıya aktarılması gerekiyor. Bu işlevi henüz yapmadım.

Telemetri verileri: arayüzün sağ tarafında gelen verilerin doğrudan sayısal olarak gösterimi yapılmaktadır.

Aras: arayüzde telemetri verilerini gösterildiği yerin üst tarafında gösterilen hata kodlarını belirten bölgede uyduda meydana gelen hataların ele alındığı yer mevcuttur. Gelen telemetri formatındaki hata koduna göre ikaz lambaları yanacaktır. Orada lambalar için label kullandım. Renk değişimlerinde sadece labelların arkaplan renkleri değiştirilecek.

Manuel deploy butonu: bu buton eğer payload taşıyıcıdan otonom olarak ayrılmazsa kullanıcının basması durumunda manuel olarak ayrılmayı gerçekleştirecektir. Butona basıldığı durumda seri porttan veri gönderecek ve uydu içerisinde işlenip ayrılma gerçekleştirilecek.

Video gönderimi: hakem heyetinin verdiği video seri portran uyduya gönderilmesi gerekiyor. Henüz bunun nasıl yapılabileceği konusunda bir bilgiye sahip değilim.

Status(durum) verileri: burasi comport ve veri kayit ayarlamalarin yapildigi yerin sol tarafinda bulunan bolge. gorevin hangi asamasinda oldugunu kullaniciya bildiren bir sistemdir. Burayi hanuz yapmadim.
