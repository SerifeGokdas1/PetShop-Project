# PetShop Projesi
### Web Uygulaması 
#### ASP.Net Core Entity Framework Code First, N-Tier Layer ile geliştirilmiş. Admin paneli ve kullanıcı paneli olmak üzere iki farklı arayüze sahiptir. Kullanıcılar admin panelinden oluşturulan ürünler ve servisler sayfalarına ulaşabilmektedirler. Site içerisindeki tüm bilgilerin yönetildiği admin panelinde ise yöneticiler, evlat edinenler, hayvanlar, ürünler, servisler ve gönüllüler sayfalarının CRUD işlemlerini gerçekleştirebilmektedir.

> Projenin çıktısını daha detaylı incelemek isterseniz [bu Youtube bağlantısından](https://www.youtube.com/watch?v=bEHQ9L4SJ9Q&ab_channel=Serife
) videoya ulaşabilirsiniz.


### Projenin admin sayfasının Adopter sayfası ve CRUD işlemleri


https://user-images.githubusercontent.com/117410162/221362099-c333a7de-75e2-4e5a-8a2d-4d35265db488.mp4



### Projenin admin sayfasının Animal sayfası çıktısı


https://user-images.githubusercontent.com/117410162/221362189-c36c1efe-4e16-40d8-9158-ebd9b696a7e7.mp4


### Projenin admin sayfasının Product sayfası çıktısı


https://user-images.githubusercontent.com/117410162/221362317-72d7d8d6-a66b-4b60-b7ab-86400ed35327.mp4


### Projenin admin sayfasının Services sayfası çıktısı


https://user-images.githubusercontent.com/117410162/221362396-82839960-58fd-4440-936b-a460afd816c1.mp4


### Projenin admin sayfasının Volunteer sayfası çıktısı

https://user-images.githubusercontent.com/117410162/221362415-091a91d6-398d-45d0-b058-100c59baba08.mp4


## Projenin kodları

#### Bu proje üç katmanlıdır. İlk olarak ASP.Net Web Application (Controller- Models- View) olarak projemi oluşturdum. Daha sonra Solution kısmına sağ tık yapıp Add seçeneğini seçtim ve New Project' tıkladım. Açılan pencerede Class Libary (C# olana) seçtim ve Models katmanını oluşturdum. Aynı işlemleri tekrar ederek Data katmanını da oluşturdum. 

![class libarary](https://user-images.githubusercontent.com/117410162/221371727-862f2f98-4998-4e28-9929-68e878dd7332.jpg)

#### Models katmanına Models adında bir klasör açtım. Models klasörünün içine projemin tablolarının isminde classlar oluşturdum ve classı public yaptıktan sonra kodlarımı yazdım.

![PetShop Model Adopter](https://user-images.githubusercontent.com/117410162/221371819-f3e620cf-b01b-43a8-b144-c7ae928481d6.jpg)

#### Data katmanındaki dependenciese sağ tıklayıp add referenceyi seçtim. Burada Model katmanını seçtim. Bu sayede data katmanını model katmanıyla bağlamış oldum.

![reference](https://user-images.githubusercontent.com/117410162/221371984-c1fe0705-b55f-47fc-aa3c-6eda589489e4.jpg)

#### Data katmanındaki Dependenciese sağ tıklayıp Manage NUget Packages seçtim ve aşağıdaki fotoğraftaki kütüphananeleri ekledim. 

![packages](https://user-images.githubusercontent.com/117410162/221372113-73e659a6-2528-4521-990b-8cbf2c3ed01d.jpg)

#### Data katmanına sağ tıklayıp ApplicationDBContext adında bir class oluşturdum. 

![Uploading PetShop.data applicationdb.jpg…]()

#### Proje katmanındaki dependenciese sağ tıklayıp Add Referenceyi seçtim. Açılan pencerede Data katmanını işaretledim. Bu işlemle birlikte proje katmanıyla data katmanını birbirine bağlamış oldum. Daha sonra proje katmanındaki dependeciese tekrar sağ tıklayıp Manage Nuget Packagesi seçtim ve önceden indirdiğim kütüphanelerin aynısını burada da indirdim.

![data reference](https://user-images.githubusercontent.com/117410162/221372421-5b5d32ad-ca9c-4226-8166-1228165d3597.jpg)

#### Daha sonra proje katmanındaki appsettings.jsonı açtım ve bağlantı kodlarımı yazdım.

![appsettingjson](https://user-images.githubusercontent.com/117410162/221372584-c6c1f602-af53-49d2-98a3-cc6f67383050.jpg)

#### Daha sonra proje katmanındaki Startup.csye gidip ConfigureServices içerisine kodlarımı ekledim.

![startup](https://user-images.githubusercontent.com/117410162/221372642-4e403a4b-16f3-4ff8-8dce-5ce1afa82615.jpg)

#### Tools -> Nuget Package Manager -> Package Manager Consolei seçip console açtım ve Add-migaration CreadDB yazdım. İşlem tamamlandıktan sonra console Update- Database yazdım ve işlemin tamamlanmasını bekledim. 

#### Proje katmanındaki Controller klasörünün içerisine tablo sayım kadar controller açtım ve kodlarını yazdım.


https://user-images.githubusercontent.com/117410162/221372961-b426ffbd-d75c-4acc-8001-8d73ab9967ec.mp4

#### Açtığım controllerdaki actionresultları add view yaptım ve kodlarını yazdım. 

![adopter ındex addview](https://user-images.githubusercontent.com/117410162/221373146-6dca6dd5-e958-4824-a917-dfc5ba3cd620.jpg)

![adopter ındexcshtml](https://user-images.githubusercontent.com/117410162/221373251-f4b2f98e-e737-475a-9f51-3f3049d212cf.jpg)


#### Bu arada proje katmanının içerisine www.root klasörünün içerisine templatelerimi attım ve düzenlemelerini yaptım. 

>Projenin içinde kullanılan eklentiler ve daha detaylı anlatım için [bu Medium bağlantısından](https://medium.com/@serifegokdaas/asp-net-core-entity-framework-code-first-n-tier-layer-web-uygulamas%C4%B1-1f2059323d0b) yazıya ulaşabilirsiniz.

>*Proje hakkında soru sormak veya geri bildirimde bulunmak isterseniz serifegokdaas@gmail.com adresinden benimle iletişime geçebilirsiniz.*



