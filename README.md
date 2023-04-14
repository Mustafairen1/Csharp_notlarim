# Csharp_notlarim

## 1. 2022 güncellemesi içeriği
Müfredat boyunca yeni proje oluşturduğunuz zaman sağ tarafında  (.net framework) işlemi yapacağız.

### 2. Visual Studio indirme ve kurulum
**adım 1**
 google'a girip Visual studio 2022 yazıp en üstten çıkan linke girerek proffesonal'i indirin.
("ben daha çok beğendiğimden community indirdim.")

**adım 2**
Visual Studio'u türkçe kullanmaktan kaçının, İngilizce kullanın, çünkü programlamanın evrensel dili İngilizce'dir.

### 3. Visual studio genel bakış
Visual Studio Microsoft'un geliştirdiği bir programlama dili derleyicisidir.
#### Derleyici nedir?

Bizim yazdığımız kodları makine diline çevirip sonra onlarıda anlaşılır formatta karşımıza çıkaran programlardır.
## 2. Temel araç kullanımları.
### 4. Merhaba dünya

**adım 1**
new project/Csharp/WindowsFormsApplication seçiyoruz.

**adım 2**
Masaüstüne yeni klasör oluşturuyoruz.
ismini udemy projeler yapıyoruz ("zorunlu değil")

**adım 3**
proje ismi belirliyoruz örneğin "arac_kullanimlari"
sonrada projeyi oluştur diyoruz.

Dipnot: mümkün olduğunca türkçe karakter kullanmamaya özen gösterin.

**adım 4**
Sol tarafta ToolBox var onu açıyoruz.
Form'un üstüne sağ tık yapıp özelliklere tıklayabiliriz, veya daha kısa yol tercihi olarak özelliklerine gitmek istediğimiz herhangi birşeyin üzerine tıklayıp F4 basarakta özelliklerine gidebiliriz.

Şimdi dünya genelinde tüm projelerin başlangıcı merhaba dünya'dır, bizde merhaba dünya ile başlayacağız.

**adım 5**
Formumuzu birazcık büyüterek başlıyoruz.
Formumuzun "form1" adını değiştirmekle başlıyoruz. "ilk kod" olaraktan değişiyoruz.
Formumuzun arkaplanını değişelim bunun için  formun özelliklerinde "backcolor" bölümünü kullanarak değişebiliriz. 
mesela turuncu rengini kullanabilirsiniz.

**adım 6**
Formumuza araç kutusundan 1 buton ekliyoruz, butonun ismini özelliklerden değişelim, "tıklayın" yapalım, ve font kısmından yazısını büyütelim (yine özelliklerden ulaşabiliriz.)
Şimdi bu butona görev verelim, örneğin tıkladığımızda ekranda bir meşaj kutusu belirmeli.

##### Button nedir?
button türkçeye çevirildiğinde düğme olarak geçer, ve üzerine 
bastığınızda veya basılı tuttuğunuzda
olayları tetiklemek için kullanılan bir araçtır, kısaca web sitelerinde girişlerde kullanılabiliyor, programlardaki arayüzlerde kullanılıyor, yani kendisine tıkladığınızda verdiğiniz görevi yerine getirmek için çalışan araçlardır. 

**adım 7**
button 1'e çift tıklayın bizim için önemli olan button click 1'in altındaki { } bölümü, bu butona bastığımızda ne olsun diye belirlediğimiz yerdir.
 {

 }
şeklinde görünür.

şimdi yazdırmaya başlayalım, mesela meşaj kutusunda birşey göstersin

    `MessageBox.show("Merhaba dünya");`
    
   yazalım ve şimdi start basıp deneyelim, butona bastığımızda merhaba dünya satırımızın çalıştığını görüyoruz, ve bu günki ders bitti.
   

##### bunlar neyi ifade ediyor?
şimdi "message=meşaj  "box=kutu "show=göster demek, yani MeşajKutusu.göster
("") ise ekrana yansıtacağımız yazının girileceği yerdir. ; ise program satırımızı kapatmamıza yarayan bir koddur.


### 5. label ve textbox kullanımı 



