# RimuutWebUI and APITest
Fatura Tutarının hesaplanması ve sayfanın isteklere yanıt verip vermediğini kontrol eden bir projedir. 
## Proje Özellikleri
* Xunit Mimarisi kullanılmıştır.
* C# 6.0.net core dilinde yazılmıştır.
* Endpoint kontrolü için RestSharp kütüphanesi entegre edilmiştir.
* Regrasyon web otomasyonu için Selenium Web Driver, ChromeWebDriver Kütüphaneleri kullanılmıştır.
* Chrome tarayıcı üzerinden UI Smoke test ve API kontrolü gerçekleşmektedir.
* Url: "https://rimuut.com/pricing"
* Selenium Web driver ve ChromeWebDriver kütüphaneleri kullanılmıştır.
* Assertion için Xunit kütüphanesi kullanılmaktadır.
* Geliştirilmiş Class yapısıyla kurulmuştur.
* İlerleyen versiyonlarda specflow(bdd) Clean Code mimarisi kurulacaktır.
* İlerleyen sürümlerde, Unit, Integration, API testi gibi çoklu katmanlı mimari yapısı entegre edilecektir.
* İlerleyen süreçlerde Docker, Kubernetes teknolojileri kullanılarak birbirimden bağımsız Cross Browser ve OS testleri koşacaktır.
* Veritabanı Mimarisi eklenecektir.

## Task İsterleri(API)
1. Url: "https://rimuut.com/pricing" 
2. Urline gider get metoduyla çağırır gelip gelmediğini assert ile kontrol eder hata varsa bildirir yoksa pass der.

## Task İsterleri(UI)
1. Sayfayı açar. - "https://rimuut.com/pricing"
2. Calculete oranını hesaplamak için fatura oranını "1000" girer.
3. Ödeme yöntemini "virtual iban" olarak değiştirir.
4. 1000 değişkenini to stringe çevirir ve son kullanıcının alacağı 951,00(Şuanki kur) karşılaştırır. Doğru ise pass eder yanlış ise hatayı söyler.
