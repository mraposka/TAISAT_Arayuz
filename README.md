# TaisatMARM-99
MARM-99 MODEL UYDU ARAYUZ PROGRAMI

Bu program 2022-2023 yılları arasında başvurulan Teknofest Model Uydu yarışmasında Taisat Marm-99 takımı için geliştirilmektedir.

Programın amacı uçuş süreci boyunca bazı verileri görselleştirmek ve gerektiği durumlarda sürece mudahale edebilmektir.

UYDUNUN ÖZELLİKLERİ
Model uydu, taşıyıcı ve payload olmak üzere iki ana bileşenden oluşur. Payload uçuşun belli bir bölümünde taşıyıcının içerisinde bulunur. Hem payload hemde taşıyıcının üzerinde bulunan sensörlerden veri alınır.

### OPERASYON KONSEPTİ

1. Uydu roketle birlikte fırlatılır.

2. Belli bir yüksekliğe ulaşıldığında uydu roketten otonom bir şekilde ayrılacaktır. 

3. Uydu belli bir irtifaya alçaldığında taşıyıcısımdan otonom bir şekilde ayrılacaktır. Eğer ayrılma gerçekleşmezse arayüz üzerindeki bir buton ile manuel bir şekilde ayrılma gerçekleştirilir. 

4. Uçuş süresi boyunca hem taşıyıcıdan hem de payloadtan elde edilecek bütün veriler arayüze canlı olarak aktarılacaktır.

5. Uçuş boyunca gerçekleşecek olası hatalar işlenip arayüzde göterilecektir.


### ARAYÜZÜN ÖZELLİKLERİ
Uydudan gelen verilerin görselleştirildiği bir programdır. Gelen veriler arayüzde işlenir ve kullaıcıya gösterilir. Bazı hata durumlarını kullanıcıya bildirir. Tek sayfadan oluşan arayüz veri alımı yaparken veri gönderimi de yapabilecek kapasitede olmalıdır.

### GÖREV
Uçuş görevinde verilerin tranferinden ayrı olarak hakem heyetinin vereceği 500kb boyutundaki video payloada gönderilecektir. Ayrıca ekstra puan kazandıracak bonus görev olarak da payloada gönderilen video başka bir yer istasyonu bilgisayarına geri gönderilecektir.(zorunlu değil)
Bunlardan ayrı olarak gelen veriler belirtilen formatta hakem heyetinin verdiği belleğe kaydedilmesi gereklidir.

### ARAYUZ BİLEŞENLERI
Kamera: kullanilan kutuphane bilgisayara takilan dahili ve harici kameralari algilayip belirlenen alanda gosterir. Ayrica ayni kutuphane sayesinde goruntuyu istenilen konuma kayıt edebiliyoruz.

### Harita
İnternet bağlantısı olmadan çalışması için gmap internet bağlantısı var iken Google API kullanıyorum.

### 3D Uydu Hareketi Simulasyonu 
Uydudan gelen açı bilgilerinin 3d simule edildiği yerdir. Unity ile yaptığım uygulamaya UDP portundan açı bilgilerini ileterek çalışmasını sağlıyorum.

### Grafikler
Gelen verilerin grafiksel olarak gösterimini sağlıyor. Her hangi bir kütüphaneye gerek duymuyor. Ama gösterilen bütün değerler backgroundworker kullanılarak arkaplanda yapılıyor.

### Verilerin Kaydedilmesi
Gelen veriler hem bilgisayara hemde hakem heyetinin verdiği belleğe kaydedilmesi gerekiyor. Veriler canlı olarak gelirken aynı anda bilgisayara kayıt ediliyor.

### Tablo Görünümü
Arayüzün alt tarafında bulunan bölgede gelen verilerin tablo halinde gösterimi yapılacaktır. Burada CSV kütüphanesini kullanılarak aynı veriler excel formatında dışarıya aktarılıyor.

### Telemetri Verileri
Arayüzün sol tarafında gelen verilerin doğrudan sayısal olarak gösterimi yapılmaktadır.

### ARAS
Taşıyıcı-görev yükü iniş hızları, taşıyıcı basınç bilgisi, görev yükü konum bilgisi ve ayrılma durumu algoritma tarafından denetlenerek belirtilen görev durumları yer istasyonu arayüzüne görsel olarak yansıtabilmektedir. Ayrıca görevlerin hata kodları yer istasyonu arayüzü ve görev yükü SD kartı telemetri dosyasına kayıt edilmektedir.

### Manuel Deploy Butonu
Bu buton eğer payload taşıyıcıdan otonom olarak ayrılmazsa kullanıcının basması durumunda manuel olarak ayrılmayı gerçekleştirecektir. Butona basıldığı durumda seri porttan veri gönderecek ve uydu içerisinde işlenip ayrılma gerçekleştirilecek.

### Video Gönderimi
Uydu üzerinde bulunan Raspberry Pi Zero 2 cihazımıza video gönderiyoruz. Daha sonra bonus görev için Raspberry Pi gelen videoyu başka bir yer istasyonu bilgisayarına gönderiyor.

### Status Verileri 
Gorevin hangi asamasinda oldugunu kullaniciya bildiren bir sistemdir.
