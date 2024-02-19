# Başlangıç Seviyesi .Net Core Patikası => C# Projeleri

Bu repo [kodluyoruz](https://kodluyoruz.org/) Başlangıç Seviyesi .Net Core Patikası C# Projeleri içermektedir.

Patika.dev hesabım -> [click](https://app.patika.dev/@yazilimyazici) !


## Kolay Seviye Projeler

### 1. Ortalama Hesaplama

Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

Dikkat Edilmesi Gereken Noktalar :

- Kod tekrarından kaçınılmalı
- Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.

---

### 2. Üçgen Çizme

Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.

Dikkat Edilmesi Gereken Noktalar :

- Kod tekrarından kaçınılmalı
- Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.

---

### 3. Daire Çizme

Kullanıcıdan alınan yarıçapa göre console'a Daire çizen uygulamayı yazınız.

Dikkat Edilmesi Gereken Noktalar :

- Kod tekrarından kaçınılmalı
- Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.

---

### 4. Algoritma

Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

- Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

- Output: Algritma Algortma Algoritma lgoritma

---

### 5. Karakter Tersten Yazdırma

Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.

- Örnek: Input: Merhaba Hello Question

- Output: erhabaM elloH uestionQ

## Orta Seviye Projeler

### 1. Alan Hesaplama

C# Console uygulaması oluşturarak aşağıdaki gereksinimleri karşılayan uygulamayı yazınız.

- İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
- Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
- Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
- Hesap sonucunu anlaşılır şekilde geri döndürmeli.

Dikkat Edilmesi Gereken Noktalar :

- Kod tekrarından kaçınılmalı
- Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.

---

### 2. Integer İkililerin Toplamı

Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

- Örnek Input: 2 3 1 5 2 5 3 3

- Output: 5 6 7 81

---

### 3. Mutlak Kare Alma

Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

- Örnek: Input: 56 45 68 77

- Output: 33 101

---

### 4. Karakter Değiştirme

Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

- Örnek: Input: Merhaba Hello Algoritma x

- Output: aerhabM oellH algoritmA x

---

### 5. Sessiz Harf

Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

- Örnek: Input: Merhaba Umut Arya

- Output: True False True

## Zor Seviye Projeler

### 1. Voting Uygulaması

Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir. Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir. Oylama sırasında öncelikle kullanıcının username'i istenmelidir. Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir. Kategoriler isteğe bağlı olarak belirlenebilir.

Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri

Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.

Kullanılması gereken teknikler:

- Kategoriler pre-defined kullanılabilir.

---

### 2. ATM Uygulaması

Uygulama ilk çalıştığında kullanıcıdan yamak istediği işlemi öğrenmelidir. Bunlar ATM üzerinden yapılabilecek temem işlemledir. Para çekme, para yatırma, ödeme yapma vs.. İsteğe bağlı olarak genişletilebilir. Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.

Uygulamada bir de gün sonu seçeneği olmalıdır. Gün sonu alınmak istendiğinde, gün içerisinde yapılan transaction ların logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir. Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.

Kullanılması gereken teknikler:

- Dosyaya Yazma
- Dosyadan Okuma
- İşlem listesi pre-defined olarak kullanılabilir.

---

### 3. Barcode Generator/Reader

3rd party barcode kütüphaneleri kullanarak barcode üreten bunu client'ın bilgisayarında bir lokasyona kaydeden. Daha sonra da barcode'u okuyabilen bir console uygulaması yazınız.

Kullanılması gereken teknikler:

- Console Application
- Import 3rd Party Library
- Dosyaya Yazma
- Dosyadan Okuma
=======
Patika.dev hesabım -> [click](https://app.patika.dev/@yazilimyazici) !

