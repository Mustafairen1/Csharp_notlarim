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

**Extra bilgi**
Eğerki 2 tane textbox üzerinden veri almak istiyorsan

    listBox1.İtems.add(textBox3.Text + " " + textBox4.Text);

    
 Böylece 2 tane textbox'a yazdıklarınız listbox'a gidecektr.

##### String nedir?
Üstünde arimetrik işlemler yapılmayacak alfabetik verilerdir.
##### ComboBox nedir?
ComboBox mesela örneğin bir sitede liste açarsınız şehir veya ilçe seçin diye menü gelir içindede örneğin adana vesaire bulunur, işte bu tarz işlemlerde ComboBox kullanılır, yani kullanıcıya seçim yapma hakkı tanır.
##### ListBox Nedir?
ListBox'da ComboBox'un açılmış hali gibi düşünün, tek farkı ListBox'ta seçenekler direk geliyor, ComboBox'daki gibi üzerine basınca değil.
###### Mini bilgilendirme:
Eğerki sürekli font ayarlamak istemiyorsanız Formun özelliklerinden varsayılan fontu seçebilirsiniz.

### 7.Maskedtextbox - Picturebox - Datetimepicker Kullanımları.

**Adım 1**
Şimdi maskedtextbox dan 3 tane oluşturalım formumuzda
1 Tel no
2 TC no
3 Tarih
4 Saat 

Olacak şekilde oluşturalım. 1 tane button 1 tanede listbox oluşturalım, ve şu komutları girelim 

    listBox.İtems.Add(maskedTextBox1.Text+  " " +  maskedTextBox2.Text+ " " +  maskedTextBox3.Text+ " " +  maskedTextBox4.Text);

Burda listbox yani liste kutusuna masked text box yani maskelenmiş metin kutularına veya kutusuna yazdığımız herşeyi kaydetmesini sağlıyoruz.

**Adım2**
Şimdi 1 tane Picturebox'u formumuza koyuyoruz, ve üzerine geldiğimizde Picturebox'un üzerinde bulunan küçük butona basıyoruz, ve 3 tane seçenek görüyoruz.
1 Choose image (Resim seç) demektir.
2 Dock in Parent Container (formun tamamını kapla) demektir.
3 Size Mode (Boyut modu) demektir, ve bir resmi Picturebox'a tamamen sığdırmak için kullanılır.

Şimdi bir resmi içeriye aktaralım, örnek olarak rastgele bir resim seçtik, ve artık dosyalara extra resim aktarmadan bu resmi kalıcı şekilde programa aktardık.

**Adım3**
Şimdi 1 tane Datetimepicker ekliyoruz ve 1 tanede buton ekliyoruz, ve butona bastığımda Datetimepicker'deki girdiğimiz verileri listbox'a gönderteceğiz.

    listBox1.İtems.Add(dateTimePicker1.Text);

Böylece dateTimePicker'deki veriler listBox'a gönderilicektir.	 

##### Maskedtextbox nedir? 
Maskeli metin kutusu olarak telafuz edilecek bir araçtır, çalışma alanı telefon numarası, tc kimlik no gibi birçok özelliği programınıza eklemesidir.

##### Picturebox nedir? 
Picturebox adından da anlayacağınız gibi bir resim kutusudur.
##### Datetimepicker nedir?
Datetimepicker türkçede Tarih zaman toplayıcı olarak nitelendirilebilir.

### 8. Checkbox Radiobutton Richtextbox Panel ve Groupbox Kullanımları.
**Adım1**
Öncelikle  3 tane Checkbox oluşturmakla  başlayalım, ve 1 tanede groupBox oluşturalım, ve birazcık büyütüp Checkbox'ları içine alalım, groupBox'un ismini örnek olarak Soslar yapalım, 1'ci Checkbox'u Mayonez 2'ci Checkbox'u Ketçap 3'ci Checkbox'u Hardal olacak şekilde ayarlayalım ve Groupbox'un içine simetrik şekilde dizelim, ve group box'u bu 3 Checkbox'a yeticek kadar küçültelim, ve işte bu groupbox hazır şekilde çalışyor, şimdi 1 tane daha araç ekleyeceğiz RadioButton, ve adım2'de anlatımını söyleyeyim.

**Adım2**
Şimdi RadioButton oluşturalım 10 tane, tek tek şunları yazalım. (burdaki sayılar temsilendir, yani eğitim amaçlı)
1 kişilik
2 kişilik
3 kişilik
4 kişilik
5 kişilik
6 kişilik
7 kişilik
8 kişilik
9 kişilik
10 kişilik

Ve bunları sığacak şekilde, aşağıdaki gibi 5'e bölerek dizelim.  (burdaki sayılar temsilendir, yani eğitim amaçlı)
1 kişilik 6 kişilik
2 kişilik 7 kişilik
3 kişilik 8 kişilik
4 kişilik 9 kişilik
5 kişilik 10 kişilik
Böylece kaç kişilik olacağına dahir bir menüde eklemiş oluyoruz.

**Adım3**
1'tane panel oluşturalım, ve oluşturduğumuz RadioButonları içine alıp paneli arkaplana uygun bir renk yapalım, ve bu eğitim böylece bitmiştir, son olarak 2 tane örnek proje yapımı var, onları gösterip Temel araçlar bölümünü tamamen bitirmiş olacağız.
##### CheckBox nedir?
Checkbox türkçede Kontrol kutusu olarak geçer, ve seçilen görevin alınıp alınmadığını kontrol ediyor 2 tane durumu var Checkbox'un ya True(seçili) yada False(seçili değil) şeklinde, yani ortası olmayan durumdur, kullanıcının birden fazla yapacağı seçimlerde daha çok kullanılır, mesela hamburgerinizde ne istersiniz? ketçap mayonez gibisinden.
##### GropBox nedir?
Groupbox türkçede Grup kutusu olarak geçiyor, ve  amacı araçları biraraya almaya yarar.
##### RadioButton nedir?
RadioButton türkçesi Radyo düğmesi olarak geçer, ve buda tek tıklamalık butondur, CheckBox'un aksine bunda 2 tane aynı anda RadioButton seçme gibi bir hakkınız olmayacaktır.
##### Panel nedir?
Panel GroupBox gibi, araçları biraraya almaya yarıyor, ama daha çok tasarımsal uygulamalarda kullanılıyor, mesela groupbox'da renk yokken çizgiler var, ama Panel'de yok, işte bu yüzden Panel tasarımsal yönden iyidir, rengini değişitirirsin falan.
##### RichTextBox nedir?
RichTextBox türkçede ZenginMetinKutusu olarak geçer, yine TextBox gibi metin girişidir, fakat tek farkı enter basarak alt satıra yazı yazabiliyoruz.
### 9. Örnek Proje - Login Paneli Oluşturma (Sadece Tasarım paneli örneğidir, işlevsel değildir.)

**Adım1**
Form1'in adını Kullanıcı Giriş Paneli olarak değiştirmekle başlayalım, 2 label  1 MaskedTextBox oluşturalım, kişinin tc no'su kullanıcı adı olsun. 1 altınada textbox ekleyelim, oda şifremiz olsun, 1'ci labeli TC Kimlik NO: yazalım 2'ci labeli Şifre: yazalım.

**Adım2**
Şimdi 1 tane panel oluşturalım, ve üste alıp büyütelim, bunu kapak yani bir logo gibisinden kullanacağız, 1 tane daha panel oluşturup onuda alta alıp biraz aşağıya doğru inceltelim, bunuda site haritası olarak kullanacağız, örneğin c# paneli 2017 tüm hakları saklıdır gibisinden.

**Adım3**
Üstteki ve alttaki panellerin renklerini pembe yapıyoruz, ve 1 tane button ekliyoruz, ve butonun ismi Giriş Yap olarak adlandırıyoruz, ve Şifremizin sağ alt kısmına pek sırıtmayacak şekilde ekliyoruz, şimdi 1 tanede CheckBox ekleyelim, ve onuda Şifremi Unutum olarak adlandıralım, 1tanede Label oluşturup Online Ders Giriş Paneli olarak adlandıralım, ve internetten lesson png yazıp en beğendiğimizi alalım.

**Adım4**
Şimdi 1 tane PictureBox oluşturalım, ve indirdiğimiz Lesson png'yi içine aktarıp Stretchİmage seçeneğini seçelim, ve boş biyere basalım, ha bu arada illaki internetten almanıza gerek yok, kendinizde 1 tane yapabilirsiniz.

**Adım4**
Şimdi MaskedTextBox'un içindeki sağdaki butona basıp 11 haneli bir değer oluşturalım'ki tc kimlik no girmelik hane oluşsun, şimdi textbox'un üzerine tıklayıp özelliklerden en alta gidiyoruz, ve UseSystemPasswordChar yani Sistem Türkçe Karakterini kullan seçeneğini True yapıyoruz, böylece şifre ekranında şifremizi göremiyorlar, ama unutmayın Karar yapısı kullanmadığımız sürece şu an bu sadece bir görseldir.

### 10 Uçak Bilet Rezervasyon Sistemi (Sadece Tasarım paneli örneğidir, işlevsel değildir.)

**Adım1**
Öncelikle 2 tane GroupBox oluşturarak başlıyoruz, 1'ci GroupBox uçuş bilgilerini tutucağı için Uçuş Bilgileri olarak adlandırıyoruz, 2'ci GroupBox yolcu bilgilerini tutucağı için Yolcu Bilgileri olarak adlandırıyoruz.

**Adım2**
Şimdi Uçuş Bilgileri bölümüne 3 label ve 2 combobox 1 tanede DateTimePicker ekliyoruz,  1ci Label'i Nereden: diye adlandırıyoruz 2ci Labeli Nereye: diye adlandırıyoruz 3'ci labelide Tarih: olarak adlandırıyoruz, Labelleri alt alta ekliyoruz DateTimePicker'i Tarih'in karşısına almakla başlıyoruz, ve combobox'larıda karşı karşıya ekliyoruz, ve 2 combobox'un içinede örnek olarak 5 şehir ekiyoruz.

Ankara 
Bursa 
Adana 
Elazığ 
Samsun
Şimdi normalde Saat'de ekleyebilirdik, fakat isteğe bağlıdır ben eklemeyeceğim.

**Adım3**
Şimdi Yolcu Bilgileri grubunu dizelim, 3 label 1 tane button 1 textbox 2 tanede maskedTextBox oluşturuyoruz, ve uçuş bilgilerindeki gibi Yolcu bilgilerine hizalıyoruz, 1'ci label Yolcu Ad Soyad: 2'ci Label TC: 3'ci Label  Telefon: olarak adlandırıyoruz, butonuda Kaydet olarak adlandırıyoruz ve yeşile boyuyoruz.

**Adım4**
Şimdi üst kısma 1 tane Panel oluşturuyoruz, ve rengini insan rengine yakın yapıyoruz, 1 tanede alt kısma ListBox oluşturuyoruz, şimdi panelin içine 1 tane label oluşturuyoruz, ve ismini Türk Hava Yolları olarak adlandırıyoruz ve internete plane.png veya gif yazıp birtane alıyoruz, ve picturebox ekleyip aldığımız png yi veya gifi içe aktarıyoruz Stretchİmage seçeneğini seçip boş biyere tıklıyoruz, tekrardan uyarayım illaki internetten almamıza gerek yok, kendimizde yapabiliriz, veya parayla yaptırabiliriz, şimdi yazacağımız kodlar sayesinde girdiğimiz bilgiler Listbox'a yansıyacaktır.

    listBox.İtems.Add("Rota: " + comboBox1.Text + " - " comboBox2.Text + " Tarih:" + DateTimePicker1.Text + " Yolcu Bilgileri ~ Ad: "+textBox1.Text + " TC: " + maskedTextBox1.Text + " Telefon: " + maskedTextBox2.Text);
    MessageBox.Show("Yolcu Kaydı Başarıyla yapılmıştır.");
Burada Kaydet butonuna basıldığında ListBox aracımızın içine yukarıda girdiğimiz tüm değerleri girmektedir.

## 3. Değişkenler.
### 11. Değişken nedir & Kavramlar
Değişken ingilizcedeki (Variable) kelimesinden geliyor, ve bellekte tutmanız gereken nesneler objeler diyebiliriz, şimdi örneğin 1 tane mantar pano tahtaları düşünün, üstüne küçük blok not kağıtlarıyla, not yazarsınız onu mantar panosuna asarsınız, bunuda şöyle yaparsınız

1 mantar pano iğnesiyle

2 raptiye ile

3 uhu yapıştırıcı ile

4 bant ile

5 mantar pano arasına sıkıştırma yöntemi ile

Bunları kullanarak kağıtları yapıştırırsınız, burda yapmamız gereken en optimal yoldur, mesela uhu yapıştırıcısı ile yaparsanız bir süre sonra pano arkası zarar görür, bantda aynı şekilde talaş kısmını söker ve kötü bir görüntü oluşturur, sıkıştırmayla ise en ufak bir darbe, veya esinti ile aşağıya düşer, raptiye ise çok deler talaşı kullanışsız hale getirir, bunun için en uygun olanı nedir? mantar pano iğnesidir,

Ozaman bunun bilgisayardaki karşılığınada şöyle diyebiliriz
RAM, yani bilgisayardaki verilerin geçici olarak saklandığı, ve bilgisayar kapatıldıktan sonra verilerin kaybolduğu yok olduğu bellek addresi olarak düşünürsek, değişkenleri  RAM'de tutarken en optimal şekilde tutmanız gerekiyor.

#### Peki C# üzerinde hangi tip değişkenler var?
String değişkeni
İnt değişkeni
Double değişkeni
Char değişkeni 
Gibi basit değişkenlerden başlayıp Float, Byte gibi diğer tüm değişkenlerle devam edeceğiz.
#### 12.String Değişkenler
**Adım1**
Şimdi 1 tane buton oluşturuyoruz 1 tanede label, sonrada şu kodları giriyoruz, ama başlamadan önce Deşişken tanıması için nasıl yol izleyeceğiz
Değişkentürü -> Değişkenadı
Yanlız Değişkenadı verirken şunlara dikkat edin, elinizden geldiğince anlamlı isimler vermeye çalışın, mesela değişken sayı verecekseniz

İnt sayı 1 sayı 2 şekilinde.

Ad soyad verecekseniz
String ad String soyad şeklinde.

Şimdi kodları girelim

    string metin;
    metin = "Merhaba bugün 19 Nisan 2023 Çarşamba";
    label1.Text = metin;
Böylece string metin; ile metin diye bir değer oluşturduk

Metin = "yazınız" ilede oluşturduğumuz metin adlı değeri bir yazıya çevirdik, ve label1'e text metini yazdırdık.

**Adım2**
Şimdide ad soyad ve meslek yazdıracağız.

    string adsoyad,meslek;
    adsoyad = "Eylül Yücedağ";
    meslek = "Öğretmen";
    label1.Text = adsoyad;
    label2.Text = meslek;
    
   Bu şekilde ad soyad ve mesleği yazdırmış oluyoruz.

**Adım3** 
Şimdide Textbox'dan aldığımız veriyi Label'e yazdıracağız.

    string sehir;
    sehir = textBox1.Text;
    label1.Text = sehir;
Böylece zikzak şekilde label 1'e Textbox tan şehir yada herhangi istediğimiz birşeyi butona basınca yazdırmış oluyoruz.

Bu şekilde String'in temelini atmış olduk.

### 13. int Değişkenler
**Adım1** 
Evet 1 tane label ve 1 tane buton oluşturarak yine devam ediyoruz, direkt kodlara geçelim.


    int sayi;
    sayi = 24;
    label1.Text = sayi;
Burda int değerinde bir sayi oluşturup ona bir değer atıyoruz yani 24 değerini atıyoruz, onuda label'e yansıtıyoruz, ama oda ne? label'deki sayi değeri kırmızı çizgi veriyor, pnu çözmek için ise bir String'e çevirici yapmalıyız, yani şu şekilde

    int sayi;
    sayi = 24;
    label1.Text = sayi.ToString();
İşte bu şekilde, butona bastığımızda 24 değeri label'e yansıdı.

**Adım2**
Şimdide 2 tane sayıyı toplam şekilde yansıtacağız, bunun için yine şunlara ihtiyacımız var.

    int sayi1 , sayi2 , toplam;
    sayi1 = 5;
    sayi2 = 4;
    toplam = sayi1 + sayi2;

**Adım3**
Buda biraz daha karmaşık alan kenar ve çevre bilgisidir.

    int kenar, alan, cevre;
    kenar = 10;
    alan = kenar * kenar;
    cevre = kenar * 4;
    label1.Text = "Alan: " + alan+ " Çevre: " + cevre;
    //kısa:10 uzun:20
    //3 sınav notu girilen öğrencinin ortalaması.

### 14. int değişkenler / Klavyeden Veri Girişi
**Adım1**
	Önce form rengini hafif koyu turuncu tonlamalarında ayarlıyoruz, bu derste int değişkeniyle klavyeden arimetrik veri girişi sağlamak, bunun için 2 label 1 button 1 textbox lazım, 1 ci labeli sayı girin: olarak değiştiriyoruz, button'u yazdır: olarak değiştriyoruz ve label 2'yi beyaz renge ayarlıyoruz, amacımız yazdır butonuna basıldığında textbox içine girilmiş değeri beyaz renkteki label'e yazdırmak, ama int formatında.

    int sayi;
    sayi = textBox1.Text;
    label1.Text = sayi.ToString();
Yaptığımızda kırmızı çizgiler çıkıyor, çünkü bu değer int değeri değil string değeridir, yani şöyle yaparak çözüme ulaşabiliriz.

    int sayi;
    sayi = Convert.Toİnt16(textBox1.Text);
    label2.Text = sayi.ToString();
Burda yaptığımız olay string değerine sahip textBox1 aracını int'e çevirdik ve sayi değerine atadık ve string olarakta label2'e aktarıyoruz, yani kısacası textBox1'deki int16 değerine dönüştürüp içindeki yazının sayi değerine verilip ordanda string'e dönüştürüp label2'e göndermesini sağlıyoruz.

**adım2**
Texbox'a girilen sayının küpünü alalım, peki küp ne demek? sayıyı kendisiyle çarpmak demek kaç defa yapalım 3 defa.

    int sayi, sonuc;
    sayi = Convert.Toİnt16(textBox1.Text)
    sonuc = sayi * sayi * sayi;
    label1.Text = sonuc.ToString();


#### bilgilendirme:
Şimdi bu işlem için bazı dönüşüm komutları vardır, şöyleki (C#) CSharp'da 3 tane int dönüşümü vardır.
toint16
toint32
toint64
Ama dünya genelinde en yaygın olanı toint32'dir ve aralıkları şu şekildedir

toint16 - + ve - 32.000 aralığında
toint32 2.buçuk aralığında
toint64 çok daha büyük tam sayılar için kullanılıyor.

### 15. İnt değişkenler pratik örnek arimetik 4 işlem.
**adım1**
Şimdi öncelikle 2 tane label 2 tane textbox 1 tanede butona ihtiyacımız var, labellerden 1'ini sayı 1 2'cisini  sayı 2 olarak adlandırıp textbox ile beraber hizalıyoruz, butonuda hesapla olarak adlandırıyoruz, şimdi kodlarına geçelim.

    int sayi1, sayi2, toplam, carpim, fark, bolum;
    sayi1 = Convert.Toİnt16(textBox1.Text);
    sayi2 = Convert.Toİnt16(textBox2.Text);
    toplam = sayi1 + sayi2;
    carpim = sayi1 * sayi2;
    bolum = sayi1 / sayi2;
    fark = sayi1 - sayi2;
    MessageBox.Shop("Toplam: " + toplam + "\n" +  " Fark: " + fark + "\n" + "Çarpım: " + carpim + " \n" + " Bölüm: " + bolum );

#### Bilgilendirme:
CTRL  k ve d tuşlarına aynı anda basarak kodlarınızı düzenletebilirsiniz.

### 16. Double Değişkenler.
devam edicek.