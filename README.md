# RimuutWebUI and APITest
Ödeme sayfasındaki Calculate oranının son kullanıcı tarafından yapılan aksiyonların otomatize edilmesi ve sayfanın isteklere yanıt verip vermediğini kontrol eden bir projedir  <br /><br />

## Proje Özellikleri
* Xunit Mimarisi kullanılmıştır.
* C# 6.0.net core dilinde yazılmıştır
* Endpoint kontrolü için RestSharp kütüphanesi entegre edilmiştir.
* Regrasyon web otomasyonu için Selenium Web Driver, ChromeWebDriver Kütüphaneleri kullanılmıştır.
* Chrome tarayıcı üzerinden UI Smoke test ve API kontrolü gerçekleşmektedir.
* Url: https://rimuut.com/pricing
* Selenium Web driver ve ChromeWebDriver kütüphaneleri kullanılmıştır
* Assertion için Xunit kütüphanesi kullanılmaktadır.
* Geliştirilmiş Class yapısıyla kurulmuştur.
* Bdd diliyle ilerleyen sürümlerde Clean Code mimarisi kurulacaktır
* İlerleyen sürümlerde, Unit, Integration, API testi gibi katmanlarla proje geliştirilecektir.
* Docker ve Container, Kubernetes mimarileri kullanılarak birbirimden bağımsız işletim sistemleri ve tarayıcıları üzerinde CrossBrowser Testler yapılacaktır
* Veritabanı Mimarisi eklenecektir.

## Task İsterleri(UI)
1. Url: https://rimuut.com/pricing - Urline gider get metoduyla çağırır gelip gelmediğini assert ile kontrol eder hata varsa bildirir yoksa pass der
2. Calculete oranını hesaplamak için fatura oranını "1000" girer
3. Ödeme yöntemini "virtual iban" olarak değiştirir.
4. 1000 değişkenini to stringe çevirir ve son kullanıcının alacağı 951,00(Şuanki kur) karşılaştırır. Doğru ise pass eder yanlış ise hatayı söyler.


## Task İsterleri(API)
1. Url: https://rimuut.com/pricing - Urline gider get metoduyla çağırır gelip gelmediğini assert ile kontrol eder hata varsa bildirir yoksa pass der

## Task İsterleri(UI)
1. Sayfayı açar
2. Calculete oranını hesaplamak için fatura oranını "1000" girer
3. Ödeme yöntemini "virtual iban" olarak değiştirir.
4. 1000 değişkenini to stringe çevirir ve son kullanıcının alacağı 951,00(Şuanki kur) karşılaştırır. Doğru ise pass eder yanlış ise hatayı söyler.
