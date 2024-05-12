# Kan Bankası Yönetim Sistemi
Uygulamanın Admin ve Kullanıcı panelleri olmak üzere iki tarafı vardır.

- **Admin Tarafı**: kullanıcı ekleyebilir, güncelleyebilir, silebilirsiniz. Tüm donorleri görüntüleyebilirsiniz. Aynı zamanda kim, hangi kan donor bağışlamış görebilirsiniz.
- **Kullanıcı Tarafı**: Listeden donor seçip transfer edebilirsiniz. Tüm donorleri listeleyebilirsiniz. Listede kan grubu filtrelme vardır.  tek panelde görüntüleyebilirsiniz. Admin panelinden şifrenizi ve kullanıcı adınızı değiştirebilirsiniz.

## Kullanılan Araçlar
- **Nesne Yönelimli Programlama**: Projemiz, nesne yönelimli programlama prensiplerine dayalı olarak geliştirilmiştir, bu da kodun daha anlaşılır ve yeniden kullanılabilir olmasını sağlar.
- **SQLSERVER**: 1. Entity Framework ile Code-First Yaklaşımı:
Entity Framework, .NET geliştiricileri için bir ORM (Object-Relational Mapping) aracıdır ve veritabanı işlemlerini kolaylaştırır. Code-First yaklaşımıyla, sınıflarınızı tanımlayabilir ve Entity Framework, bu sınıflara dayalı olarak veritabanınızı oluşturabilir"SQL Server Veritabanı Projesi"., bu da veritabanı sorgularının daha kolay ve anlaşılır olmasını sağlar.
- **Donor &  Kan Transfer İşlemleri**: Bağışçıların hangi kan grubu bağışladıklarını ve uygun olup omadığı işlevi eklenmiştr.

![solution](![Ekran görüntüsü 2024-05-12 211655](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/db6adbcc-2107-403b-ae56-5fb4ceea46e3)
)
)

## Uygulama İçinden Görüntüler
Aşağıda uygulamadan alınmış ekran görüntüleri bulunmaktadır.

### Ana Sayfa

![anasayfa](![Ekran görüntüsü 2024-05-12 215549](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/fae74798-b8be-4873-a3ad-06f426571057)
)
-Gitmek istediğiniz sayfayı veya yapmak istediğiniz işlemi seçin.

### Kullanıcı Paneli

![musteri](![Ekran görüntüsü 2024-05-12 215843](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/44be4b32-1898-4920-aaa8-5b842f2981bc)
)
-Burada hastanın bilgileri alınarak sisteme yani veritabaına kayıt edilir.

### Admin Paneli

![admin](![Ekran görüntüsü 2024-05-12 215708](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/72101d29-c533-4b22-8f12-472a5e7dcba9)
)
-Sisteme kayıtlı olan çalışanları düzenleyebilir veya silebilirsiniz bununla beraber sisteme yeni çalışan ekleyebilirsiniz.
### Diğer Resimler:
![Ekran görüntüsü 2024-05-12 215852](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/ea6a2038-5541-4b63-bdef-169291f4a935)
-Hasta Listesi sayfası sayfaası sayesinde sisteme kayıt olan hastaları görüntüleyebilir ve bilgileri dünlleyebilir bununla beraber kaydı silebilirsiniz.

![Ekran görüntüsü 2024-05-12 215902](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/ac5ed860-4cdc-4cb6-bbbb-b25d20760eb2)
-Kan Bağışı sayfası üzerinden ad, soyad ve kan grubu bilgilerini sisteme girerek, yukarıdaki donor listesi ve kan stoğu listesine eklendiğini görüntüleyebilirsiniz.

![Ekran görüntüsü 2024-05-12 215920](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/b0b8b484-4369-4ac0-824e-06cb79f738e4)
-Kan Transferi paneli üzerinden uygun olan donor ve stok durumuna bağlı olarak tranfer sağlayabilisiniz hastalara.

![Ekran görüntüsü 2024-05-12 215929](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/ee99f88e-ab44-483b-9867-ee3dbf6801da)
-Kontrol Paneli üzerinden toplam donor ,tranfer ve kullanıcı sayısına erişebilir alt tarafta toplam kan stoğunu görebilirsiniz ayrı ayrı kan grubu olarak.

![Ekran görüntüsü 2024-05-12 215821](https://github.com/Mehmeteyupkahraman/KanBankasiYonetimSistemi/assets/148050747/b45c8715-33e4-47e7-b8d0-2677f57ea7b9)
-Donor Listesi sayfası üzerinden kan gruplarının ve bağış yapanların kime ait olduğunu görebilirsiniz.

