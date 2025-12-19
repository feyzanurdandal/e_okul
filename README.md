# E-Okul Yönetim Sistemi

Bu proje, bir okulun temel yönetim süreçlerini dijital ortamda takip etmek için geliştirilmiş bir **C# Windows Forms** masaüstü uygulamasıdır. 
Öğrenci, öğretmen, ders ve not yönetimi gibi işlemleri kolaylaştırmayı amaçlar.

##  Özellikler

Uygulama içerisinde aşağıdaki temel modüller yer almaktadır:

* **Öğrenci Yönetimi:** Öğrenci kayıtlarını ekleme, silme ve güncelleme işlemleri.
* **Öğretmen Paneli:** Öğretmen bilgilerinin yönetimi ve sistem erişimi.
* **Not Sistemi:** Sınav notlarının girilmesi, ortalamaların hesaplanması ve listelenmesi.
* **Ders & Kulüp İşlemleri:** Okul bünyesindeki derslerin ve sosyal kulüplerin organizasyonu.
* **Veri Yönetimi:** DataSet ve ADO.NET kullanılarak SQL Server ile entegre çalışma.

##  Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET Framework (Windows Forms)
* **Veritabanı:** SQL Server (DataSet mimarisi)
* **IDE:** Visual Studio

##  Kurulum ve Çalıştırma

Projeyi yerel bilgisayarınızda denemek için:

1.  Repoyu bilgisayarınıza klonlayın:
    ```bash
    git clone [https://github.com/kullanici-adiniz/e_okul.git](https://github.com/kullanici-adiniz/e_okul.git)
    ```
2.  `e_okul.sln` dosyasını Visual Studio ile açın.
3.  `App.config` içerisindeki **Connection String** bölümünü kendi SQL Server bağlantı adresinizle güncelleyin.
4.  Projeyi **Build** edip çalıştırın.

## 📄 Lisans

Bu proje [MIT](LICENSE) lisansı altında sunulmaktadır.
