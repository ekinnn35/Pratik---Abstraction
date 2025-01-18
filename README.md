Abstraction Example Project
Proje Açıklaması
Bu proje, nesne tabanlı programlama (OOP) prensiplerinden biri olan abstraction (soyutlama) kavramını göstermek için hazırlanmıştır. Projede, bir şirketin çalışanlarını temsil eden sınıflar ve bu sınıfların soyutlama prensibine uygun olarak davranışlarını nasıl gerçekleştirdiği gösterilmektedir.

Sınıflar
BaseCalisan (Soyut Sınıf)
Ortak özellikler ve davranışları tanımlar.
Özellikler:
Ad, Soyad, Departman
Soyut Metot:
Gorev() - Her çalışan sınıfı kendi görevini bu metotla tanımlar.
Ortak Metot:
CalisanBilgileri() - Çalışanın genel bilgilerini ekrana yazdırır.
YazilimGelistirici
BaseCalisan sınıfından türetilmiştir.
Görevi: "Yazılım geliştirici olarak çalışıyorum." mesajını ekrana yazdırır.
ProjeYoneticisi
BaseCalisan sınıfından türetilmiştir.
Görevi: "Proje yöneticisi olarak çalışıyorum." mesajını ekrana yazdırır.
SatisTemsilcisi
BaseCalisan sınıfından türetilmiştir.
Görevi: "Satış temsilcisi olarak çalışıyorum." mesajını ekrana yazdırır.
Proje Yapısı
Proje aşağıdaki dosya ve klasör yapısına göre düzenlenmiştir:

bash
Kopyala
Düzenle
AbstractionExample/
├── Base/
│   └── BaseCalisan.cs        # Soyut sınıf, çalışanların ortak özelliklerini ve davranışlarını tanımlar.
├── Calisanlar/
│   ├── YazilimGelistirici.cs # Yazılım Geliştirici sınıfı.
│   ├── ProjeYoneticisi.cs    # Proje Yöneticisi sınıfı.
│   └── SatisTemsilcisi.cs    # Satış Temsilcisi sınıfı.
└── Program.cs                # Uygulamanın çalıştırılabilir ana dosyası.
Nasıl Çalıştırılır?
Projeyi bir C# geliştirme ortamında (örneğin, Visual Studio) açın.
Tüm dosyaların doğru klasör yapısına yerleştirildiğinden ve aynı namespace kullanıldığından emin olun.
Program.cs dosyasını çalıştırın.
Konsol ekranında çalışanların bilgilerini ve görevlerini görebilirsiniz.
ullanılan OOP Prensibi
Abstraction (Soyutlama):
Ortak özellik ve davranışlar BaseCalisan sınıfında soyutlanmıştır.
Alt sınıflar, kendi özel görevlerini Gorev() metodunu override ederek gerçekleştirmiştir.
