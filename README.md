# 1. 2022 güncellemesi içeriği
## 1. 2022 güncellemesi içeriği
Müfredat boyunca yeni proje oluşturduğunuz zaman sağ tarafında  (.net framework) işlemi yapacağız.
### 2. Visual Studio indirme ve kurulum
**adım 1**
 google'a girip Visual studio 2022 yazıp en üstten çıkan linke girerek proffesonal'i indirin.
("ben daha çok beğendiğimden community indirdim.")

**adım 2**
Visual Studio'u türkçe kullanmaktan kaçının, ingilizce kullanın, çünkü programlamanın evrensel dili ingilizcedir.
### 3. Visual studio genel bakış
Visual Studio Microsoft'un geliştirdiği bir programlama dili derleyicisidir.
#### Derleyici nedir?
bizim yazdığımız kodları makine diline çevirip sonra onlarıda anlaşılır formatta karşımıza çıkaran programlardır.
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

dipnot: mümkün olduğunca türkçe karakter kullanmamaya özen gösterin.

**adım 4**
sol tarafta ToolBox var onu açıyoruz.
form'un üstüne sağ tık yapıp özelliklere tıklayabiliriz, veya daha kısa yol tercihi olarak özelliklerine gitmek istediğimiz herhangi birşeyin üzerine tıklayıp F4 basarakta özelliklerine gidebiliriz.

şimdi dünya genelinde tüm projelerin başlangıcı merhaba dünya'dır, bizde merhaba dünya ile başlayacağız.

**adım 5**
Formumuzu birazcık büyüterek başlıyoruz.
Formumuzun "form1" adını değiştirmekle başlıyoruz. "ilk kod" olaraktan değişiyoruz.

Formumuzun arkaplanını değişelim bunun için  formun özelliklerinde "backcolor" bölümünü kullanarak değişebiliriz. 
mesela turuncu rengini kullanabilirsiniz.

**adım 6**
formumuza araç kutusundan 1 buton ekliyoruz, butonun ismini özelliklerden değişelim, "tıklayın" yapalım, ve font kısmından yazısını büyütelim (yine özelliklerden ulaşabiliriz.)

şimdi bu butona görev verelim, örneğin tıkladığımızda ekranda bir meşaj kutusu belirmeli.

##### button nedir?
button türkçeye çevirildiğinde düğme olarak geçer, ve üzerine 
bastığınızda veya basılı tuttuğunuzda
olayları tetiklemek için kullanılan bir araçtır, kısaca web sitelerinde girişlerde kullanılabiliyor, programlardaki arayüzlerde kullanılıyor, yani kendisine tıkladığınızda verdiğiniz görevi yerine getirmek için çalışan araçlardır. 

**adım 7**
button 1'e çift tıklayın bizim için önemli olan button click 1'in altındaki { } bölümü, bu butona bastığımızda ne olsun diye belirlediğimiz yerdir.
 {

 }
şeklinde görünür.

şimdi yazdırmaya başlayalım, mesela meşaj kutusunda birşey göstersin

    MessageBox.show("Merhaba dünya");
    
   yazalım ve şimdi start basıp deneyelim, butona bastığımızda merhaba dünya satırımızın çalıştığını görüyoruz, ve bu günki ders bitti.
   
##### bunlar neyi ifade ediyor?
şimdi "message=meşaj  "box=kutu "show=göster demek, yani MeşajKutusu.göster
("") ise ekrana yansıtacağımız yazının girileceği yerdir. ; ise program satırımızı kapatmamıza yarayan bir koddur.
<<<<<<< Updated upstream
### 5. label ve textbox kullanımı 



=======
### 5. label ve textbox kullanımı
**adım 1**
1 tane label oluşturalım, label'in fontunu biraz büyütelim.
1 tanede buton oluşturalım, önceki butonu sağ üste alalım, yeni butonuda label'in yanına eşit ve simetrik olacak şekilde alalım ve büyütelim, formun ismini değişip "araç kullanımları" yapalım, ve arkaplan renginide pembe yapalım, böylece her yeni programda bir değişiklik olsun.
**adım 2**
label'i "adınız" olarak değiştirelim, buttonu'da "yazdır" olarak değiştirelim.
ve adınız'ın yanına 1 label daha oluşturup fontunu "Bold" yani kalın olarak değiştirelim.
**adım 3**
şimdi biz bu botuna bastığımızda label2'e adımızı girmesini sağlayalım.

    label2.text="Baran";
evet yazdır butonuna bastığımızda tırnak içerisindeki yazı label2'e geçiyor.

**adım 4**
şimdi bunu tatlı bir uygulamaya çevirelim, 1 tane daha buton ekliyoruz ve 6 tanede label ekliyoruz, form'mumuzu biraz daha büyütüp butonu aşağıya üstede 6 tane label'imizi karşı karşıya diziyoruz, ve 6 labeli aynı anda seçiyoruz fontunu değiştiriyoruz.
şimdi butonun ismini bilgi getir yapıyoruz, arkaplan renginide kafanıza göre değişiyorsunuz.
###### dipnot: ama arkaplana katien uyumlu bir renk olmalı, yoksa gözünüz üzülebilir."

şimdi
label 6 adı
label 7 soy adı
label 8 mesleğini getireceğiz

ona görede sol tarafındaki labelleri şöyle değiştirmeliyiz

label 3 / adınız:
label 4 / soyadınız:
label 5/ mesleğiniz:

şimdi 3 4 5 labellerini seçip sağ kısma hizalıyoruz.

label 6 7 8'i de biraz sağ kaydırıyoruz ki, çirkin gözükmesinler.

şimdi kodları yapalım

    label6.text="Emel";
    label7.text="Öztürk";
    label8.text="Öğretmen";

böylece  bilgi getire tıkladığımızda 3 tane label'e aynı anda veri yazdırabiliyoruz.




##### label nedir?
label türkçede etiket karşılığı okarak çevirebiliceğimiz bir araçtır, bize bilgiler sağlar.

örnek: bir mağzaya gittik mesela koton mağzası, 2 kişi karşılıklı olarak duruyoruz kiyafetin renginden tut herşeyini bilebilirsiniz, fakat fiyatını asla bilemezsiniz, işte burdada etiketler size yardımcı olur ve fiyatını yazar, aynı şey internet içinde geçerlidir, programlar içinde geçerlidir.

**adım 5**
şimdi bir textbox ekliyoruz, sonrada altınada 1 tane buton ekliyoruz.
butonun ismini aktar yapıyoruz.
  

       textbox1.text="Yazılım mühendisliği";

bu şekildede normalde klavye ile veri alınan yere bir buton yardımıyla veri yazdırabiliyoruz, fakat bu textbox'a bizim yazdığımız yazıyı bir label'e yazdırmak için şunu yapabiliriz.

       label9.text=textbox1.text;

şimdi nereye yazdırıcaksanız o bölüm sol taraftta
yani label9 şu an text box'tan yazı verileceği yer   yazacağımız bölge de sağda olmalı yani textbox1

textbox'a birşey yazdığınızda aktar bastığınızda veri label'e gidicektir, ama boş bir yazı ile bastığınızda o veri yine label'e gider, ama kaybolmaz null değer olarak yazılır, yani bilinmeyen değer olarak yazılır.

##### textbox nedir?
textbox türkçede metin kutusu olarak geçiyor.

textbox ile klavyeden veri girebiliyorsunuz, mesela kullanım alanları şu şekilde olabilir, google üzerinde arama menüsüne klavye ile veri giriyorsunuz, veya instagram, facebook, youtube hesaplarınıza giriş yapabiliyorsunuz.

### 6.ComboBox ve ListBox Araçları kullanımı.
>>>>>>> Stashed changes
