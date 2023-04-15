# 1. 2022 güncellemesi içeriği
## 1. 2022 güncellemesi içeriği
Müfredat boyunca yeni proje oluşturduğunuz zaman sağ tarafında  (.net framework) işlemi yapacağız.
### 2. Visual Studio indirme ve kurulum
**Adım 1**
 Google'a girip Visual studio 2022 yazıp en üstten çıkan linke girerek proffesonal'i indirin.
("Ben daha çok beğendiğimden community indirdim.")

**Adım 2**
Visual Studio'u türkçe kullanmaktan kaçının, ingilizce kullanın, çünkü programlamanın evrensel dili ingilizcedir.
### 3. Visual studio genel bakış
Visual Studio Microsoft'un geliştirdiği bir programlama dili derleyicisidir.
#### Derleyici nedir?
Bizim yazdığımız kodları makine diline çevirip sonra onlarıda anlaşılır formatta karşımıza çıkaran programlardır.
## 2. Temel araç kullanımları.
### 4. Merhaba dünya

**Adım 1**
New project/Csharp/WindowsFormsApplication seçiyoruz.

**Adım 2**
Masaüstüne yeni klasör oluşturuyoruz.
ismini udemy projeler yapıyoruz ("zorunlu değil")

**Adım 3**
Proje ismi belirliyoruz örneğin "arac_kullanimlari"
sonrada projeyi oluştur diyoruz.

Dipnot: mümkün olduğunca türkçe karakter kullanmamaya özen gösterin.

**Adım 4**
Sol tarafta ToolBox var onu açıyoruz.
form'un üstüne sağ tık yapıp özelliklere tıklayabiliriz, veya daha kısa yol tercihi olarak özelliklerine gitmek istediğimiz herhangi birşeyin üzerine tıklayıp F4 basarakta özelliklerine gidebiliriz.

Şimdi dünya genelinde tüm projelerin başlangıcı merhaba dünya'dır, bizde merhaba dünya ile başlayacağız.

**Adım 5**
Formumuzu birazcık büyüterek başlıyoruz.
Formumuzun "form1" adını değiştirmekle başlıyoruz. "ilk kod" olaraktan değişiyoruz.

Formumuzun arkaplanını değişelim bunun için  formun özelliklerinde "backcolor" bölümünü kullanarak değişebiliriz. 
mesela turuncu rengini kullanabilirsiniz.

**Adım 6**
Formumuza araç kutusundan 1 buton ekliyoruz, butonun ismini özelliklerden değişelim, "tıklayın" yapalım, ve font kısmından yazısını büyütelim (yine özelliklerden ulaşabiliriz.)

Şimdi bu butona görev verelim, örneğin tıkladığımızda ekranda bir meşaj kutusu belirmeli.

##### Button nedir?
Button türkçeye çevirildiğinde düğme olarak geçer, ve üzerine 
bastığınızda veya basılı tuttuğunuzda
olayları tetiklemek için kullanılan bir araçtır, kısaca web sitelerinde girişlerde kullanılabiliyor, programlardaki arayüzlerde kullanılıyor, yani kendisine tıkladığınızda verdiğiniz görevi yerine getirmek için çalışan araçlardır. 

**Adım 7**
Button 1'e çift tıklayın bizim için önemli olan button click 1'in altındaki { } bölümü, bu butona bastığımızda ne olsun diye belirlediğimiz yerdir.
 {

 }
Şeklinde görünür.

Şimdi yazdırmaya başlayalım, mesela meşaj kutusunda birşey göstersin

    MessageBox.show("Merhaba dünya");
    
   Yazalım ve şimdi start basıp deneyelim, butona bastığımızda merhaba dünya satırımızın çalıştığını görüyoruz, ve bu günki ders bitti.
   
##### Bunlar neyi ifade ediyor?
Şimdi "message=meşaj  "box=kutu "show=göster demek, yani MeşajKutusu.göster
("") ise ekrana yansıtacağımız yazının girileceği yerdir. ; ise program satırımızı kapatmamıza yarayan bir koddur.
### 5. label ve textbox kullanımı
**Adım 1**
1 tane label oluşturalım, label'in fontunu biraz büyütelim.
1 tanede buton oluşturalım, önceki butonu sağ üste alalım, yeni butonuda label'in yanına eşit ve simetrik olacak şekilde alalım ve büyütelim, formun ismini değişip "araç kullanımları" yapalım, ve arkaplan renginide pembe yapalım, böylece her yeni programda bir değişiklik olsun.
**Adım 2**
Label'i "adınız" olarak değiştirelim, buttonu'da "yazdır" olarak değiştirelim.
ve adınız'ın yanına 1 label daha oluşturup fontunu "Bold" yani kalın olarak değiştirelim.
**Adım 3**
Şimdi biz bu botuna bastığımızda label2'e adımızı girmesini sağlayalım.

    label2.text="Baran";
Evet yazdır butonuna bastığımızda tırnak içerisindeki yazı label2'e geçiyor.

**Adım 4**
Şimdi bunu tatlı bir uygulamaya çevirelim, 1 tane daha buton ekliyoruz ve 6 tanede label ekliyoruz, form'mumuzu biraz daha büyütüp butonu aşağıya üstede 6 tane label'imizi karşı karşıya diziyoruz, ve 6 labeli aynı anda seçiyoruz fontunu değiştiriyoruz.
şimdi butonun ismini bilgi getir yapıyoruz, arkaplan renginide kafanıza göre değişiyorsunuz.
###### Dipnot: Ama arkaplana katien uyumlu bir renk olmalı, yoksa gözünüz üzülebilir."

Şimdi
label 6 adı
label 7 soy adı
label 8 mesleğini getireceğiz

Ona görede sol tarafındaki labelleri şöyle değiştirmeliyiz

label 3 / adınız:
label 4 / soyadınız:
label 5/ mesleğiniz:

Şimdi 3 4 5 labellerini seçip sağ kısma hizalıyoruz.

Label 6 7 8'i de biraz sağ kaydırıyoruz ki, çirkin gözükmesinler.

Şimdi kodları yapalım

    label6.text="Emel";
    label7.text="Öztürk";
    label8.text="Öğretmen";

Böylece  bilgi getire tıkladığımızda 3 tane label'e aynı anda veri yazdırabiliyoruz.




##### Label nedir?
Label türkçede etiket karşılığı okarak çevirebiliceğimiz bir araçtır, bize bilgiler sağlar.

Örnek: Bir mağzaya gittik mesela koton mağzası, 2 kişi karşılıklı olarak duruyoruz kiyafetin renginden tut herşeyini bilebilirsiniz, fakat fiyatını asla bilemezsiniz, işte burdada etiketler size yardımcı olur ve fiyatını yazar, aynı şey internet içinde geçerlidir, programlar içinde geçerlidir.

**Adım 5**
Şimdi bir textbox ekliyoruz, sonrada altınada 1 tane buton ekliyoruz.
butonun ismini aktar yapıyoruz.
  

       textbox1.text="Yazılım mühendisliği";

Bu şekildede normalde klavye ile veri alınan yere bir buton yardımıyla veri yazdırabiliyoruz, fakat bu textbox'a bizim yazdığımız yazıyı bir label'e yazdırmak için şunu yapabiliriz.

       label9.text=textbox1.text;

Şimdi nereye yazdırıcaksanız o bölüm sol taraftta yani label9 şu an text box'tan yazı verileceği yer   yazacağımız bölge de sağda olmalı yani textbox1 Textbox'a birşey yazdığınızda aktar bastığınızda veri label'e gidicektir, ama boş bir yazı ile bastığınızda o veri yine label'e gider, ama kaybolmaz null değer olarak yazılır, yani bilinmeyen değer olarak yazılır.

##### Textbox nedir?
Textbox türkçede metin kutusu olarak geçiyor.

Textbox ile klavyeden veri girebiliyorsunuz, mesela kullanım alanları şu şekilde olabilir, google üzerinde arama menüsüne klavye ile veri giriyorsunuz, veya instagram, facebook, youtube hesaplarınıza giriş yapabiliyorsunuz.

### 6.ComboBox ve ListBox Araçları kullanımı.
Şimdi ComboBox'u seçip form'umuza ekliyoruz, üzerine 1 tık atıyoruz, ve hemen ComboBox'un sağ üstündeki play benzeri işarete basıyoruz, orda ComboBox Tasks, yani ComboBox seçimleri adlı pencere açılır, o pencerenin altında Edit İtems yani Öğe düzenle'e tıklıyoruz, tıkladıktan sonra String Collection Editor, yani String koleksiyon düzenliyicisidir.

**Adım 1**
Şimdi içerisine örneğin illeri yazalım

Adana 
Adıyaman 
Afyonkarahisar 
Ağrı 
Amasya 
Ankara 
Antalya 
Artvin 
Aydın 
Balıkesir
Bilecik 
Bingöl 
Bitlis 
Bolu 
Burdur 
Bursa 
Çanakkale 
Çankırı 
Çorum 
Denizli 
Ve geri kalan 56 tane ili ekleyebiliriz.

Veya bir buton yardımıylada ComboBox'a ekleme yapabiliriz, 1 tane button oluşturuyoruz ve üzerine doğrudan çift tıklıyoruz, şimdi kodları yazalım

    comboBox1.İtems.Add("Antalya");
    
Bu örnekte olduğu gibi bu işlem ComboBox'a Antalya'yı ekleyecektir.
**Adım2**
Şimdi textbox ve button ile ComboBox'a yazı ekleyeceğiz,  etiket amaçlı 1 tane label oluşturuyoruz, labeli textbox 'un yanına ekleyip, İL: yazıyoruz, buttonuda textbox'un aşağısına hizalı şekilde yerleştiriyoruz, butonu ekle olarak adlandırıyoruz, ve çift tıklıyoruz, şimdi kodları yazıyoruz.

    cobmoBox1.İtems.Add(textBox1.Text);
    
    
    Burda textbox1'den gelen metin öğesini ComboBox'a ekle görevini vermiş oluyoruz.

**Adım3**
ListBox ekleyelim birtane, yine aynı şekil üstüne 1 kere basıp ListBox üzerindeki sağ üstte bulunan küçük butona basıyoruz, bu seferde oraya meslekleri ekliyoruz.

Doktor
Öğretmen
Mühendis
Yazılım
Hemşire
Gibi tüm meslekler.

Şimdi aşağısına 1 tanede buton ekliyoruz, ve ComboBox'a yaptığımız gibi ListBox'a kodla veri ekliyelim, sonrada TextBox ile aynı şekilde ekleyelim, buton ismini bu sefer adlandırmayacağım ben, button2 olarak kalsın.

    listBox1.İtems.add("Veteriner");

Evet bu butona bastığımda artık Veteriner'i istediğim kadar ListBox'a ekleyebiliceğim, normalde birden fazla yapmak istiyorsak aynı komutu alt alta yerleştirerek sadece ("") içindekini değişebiliriz.

    listBox1.İtems.add("Veteriner");
    listBox1.İtems.add("Doktor");
    listBox1.İtems.add("Muhasebeci");
    listBox1.İtems.add("Antrenör");
   
   Evet bu şekilde ekleyebiliyoruz,
   

   **Adım4**
   Şimdi 1 tane daha label button ve textbox oluşturuyoruz, ve label'i Meslek: olarak adlandırıyoruz, tabi ben yine butonu adlandırmayacağım button3 olarak kalsın. şimdi bu seferki amacım butona bastığımda textboxtaki veriyi Listbox'a eklesin.

     listBox1.İtems.add(textBox3.Text);
     
Böylece textbox'a yazdıklarım, örneğin müdür yazdığımda mesleklerin bulunduğu ListBox'a gidecektir, böylece bu dersimde burada kapanmış oluyor, şimdi visual studio ile yapım işlemine geçip github'a yükleyeceğim.


    


##### string nedir?
Üstünde arimetrik işlemler yapılmayacak alfabetik verilerdir.
##### ComboBox nedir?
ComboBox mesela örneğin bir sitede liste açarsınız şehir veya ilçe seçin diye menü gelir içindede örneğin adana vesaire bulunur, işte bu tarz işlemlerde ComboBox kullanılır, yani kullanıcıya seçim yapma hakkı tanır.
##### ListBox Nedir?
ListBox'da ComboBox'un açılmış hali gibi düşünün, tek farkı ListBox'ta seçenekler direk geliyor, ComboBox'daki gibi üzerine basınca değil.
###### Mini bilgilendirme:
Eğerki sürekli font ayarlamak istemiyorsanız Formun özelliklerinden varsayılan fontu seçebilirsiniz.

### 7.Maskedtextbox - Picturebox - Datetimepicker Kullanımları.
Daha bitirmedim.