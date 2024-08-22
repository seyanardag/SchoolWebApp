# SchoolWebApp
Projede bir okulun öğrenci kayıtlarının tutulduğu SchoolWeb isimli küçük bir demo web uygulaması yapılmıştır. Projeye ait ekran görüntüleri bu sayfa sonuuna eklenmiştir.
Projede Kullanılan Teknolojiler;

•	C#

•	AspNet Core 8.0

•	n-Tier Architecture

•	Repository Design Pattern

•	Asp.Net Core WebApi

•	AutoMapper

•	Swagger

•	Entity Framework Core – LinQ

•	QueryFilter

•	EF Core - Identity

•	DTO

•	Code-First

•	MsSQL 

•	Html, Css, Bootstrap

•	SweetAlert

•	ViewComponent

•	PartialView



Projede nTier Achitecture kullanılmıştır. Öğretmenin yetkili olduğu kabul edilen projede TeacherLayout olarak tek bir layout kullanılmıştır.  

Projenin frontend tarafında bootstrap kaynaklı hazır bir admin template’i kullanılmış ve bu templete özelleştirilmiş, gereksiz görülen kısımlar silinmiş, bazı kısımlarda da eklemeler yapılarak projeye uygun hale getirilmiştir. 

Backend tarafında nTier Architecture kullanılmış, katmanlar net ve açık şekilde ayrılmış, hiyerarşik ve uygun olarak referanslandırılmıştır. Bağımlılıklar üst katmandan alt katmana olarak, alt katmanın üst katmana bağımlı olmayacağı şekilde yapılandırılmıştır. SOLID prensiplerine uyulmasına azami gayret gösterilmiştir. Clean-code kullanılmış, bazı bölümler daha sonra projenin geliştirilmesi veya değiştirilmesine fayda sağlamak kapsamında yorum satırına alınarak yerinde bırakılmıştır. PartialView’ler ve ViewComponent yapısı kullanılarak modüler bir tasarım yapılmıştır. İş mantığı katmanları başta olmak üzere projenin çoğu yerinde ve gerekli görülen yerlerde açıklama satırları eklenmiştir. Code-first ile yazılmıştır. Projenin ilk kez kullanacak kişiye kolaylık sağlanması açısından hem Student tablosu seed edilmiş, hem de Identity kütüphanesine ait 1 adet admin kullanıcı seed edilmiş, giriş işlemlerinin kolay olması açısından login sayfasındaki input değerlerine varsayılan olarak uygun kullanıcı adı ve şifreler girilmiştir.

Projede softDelete ve ardDelete özellikle istendiğinden bu kısımda entity’e özgü metodlar yazılarak bu işlemlerin mimariye uygun şekilde gerçekleşmesi sağlanmıştır. QueryFilter kullanılarak silinmiş öğrencilerin normal sorgularda sonuçlar içinde gelmesi engellenmiş, silinen öğrencilerin işlemleri için ise bu kural safdışı bırakılarak işlemler gerçekleştirilebilmiştir. Silinen öğrencilerin listesi ve bunlara özgü işlemler (tamamen silme ve silmeyi geri alma gibi) kullanıcı seviyesinde ayrı bir kısımda sunulmuştur.

Kullanıcının yanlışlıkla yapabileceği önemli işlemler sweetAlert ile onay alınma sonrası gerçekleştirilmektedir. 

Projede öğrenci fotoğrafları eklendiğinde projenin “WebUI\wwwroot\images\studentImages” yoluna kaydedilmekte, softdelete ile silinen kayıtların fotoğrafları halen tutulurken hardDelete ile silinen kayıtların fotoğrafları gereksiz alan kullanımının önüne geçmek kapsamında tamamen silinmektedir. Güncelleme işlemlerinde de eski fotoğraf silinmektedir. Profil fotoğrafları da komşu klasörde (images\ userImages) tutulmaktadır. 

Projenin Login ve Register sayfaları için hazır bootstrap template’i özelleştirilmiştir. Projenin yetkilendirme kapsamında güvenliği Identity kütüphanesi ile sağlanmıştır. Yeni kullanıcıların sisteme kaydolması ve daha sonra profillerini güncelleyebilmesi için gerekli formlar oluşturulmuştur. 

Yanlış URL girilmesi vb. durumlar için özelleştirilmiş hata sayfası kullanılmıştır. 

Projeye ait ekran görüntüleri;
![3](https://github.com/user-attachments/assets/be38d061-3901-4620-a601-9edbe23626c4)
![4](https://github.com/user-attachments/assets/ba585ba9-ef00-43ee-9d5a-2e504e594856)
![5](https://github.com/user-attachments/assets/256fcdfd-6b00-41cb-ba9c-a27678487860)
![7](https://github.com/user-attachments/assets/4de6b5f3-5b10-4a94-a6df-9ecf43647592)
![8](https://github.com/user-attachments/assets/af18f41f-bef6-4a56-acfa-d92e533b8705)
![9](https://github.com/user-attachments/assets/557d7b23-ec2c-4a85-a901-40f20db61434)
![10](https://github.com/user-attachments/assets/1485abda-fc4d-4a08-8046-70586aa8ef44)
![11](https://github.com/user-attachments/assets/83b3108b-0cbc-4033-ad1f-f757141d550d)
![2](https://github.com/user-attachments/assets/da901915-62b6-400e-bf00-ddc40ca78ede)
![1](https://github.com/user-attachments/assets/1e7e2aa3-0071-4cc9-9c17-4611cd7bae0b)

