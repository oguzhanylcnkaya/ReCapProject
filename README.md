# Araç Kiralama Projesi (Backend)

---

## Proje Hakkında Bilgiler

- Araç Kiralama Projesinin Backend tarafı .Net Core, Frontend tarafı ise Angular ile oluşturulmuştur.
- Backend kodlarına [bu linkten](https://github.com/oguzhanylcnkaya/ReCapProject) ulaşabilirsiniz.
- Frontend kodlarına [bu linkten](https://github.com/oguzhanylcnkaya/ReCapProjectFrontEnd) ulaşabilirsiniz.

### Backend

Bu projenin backend tarafında .Net Core kullanılmıştır. Proje katmanlı mimari tekniğine göre oluşturulmuştur. Entities katmanında veritabanına karşılık olarak gelecek varlıklar oluşturulmuştur. DataAccess katmanında entities katmanındaki varlıkların veritabanlarına bağlanması için gerekli kodlamalar yapılmıştır. ORM olarak Entity Framework kullanılmıştır. Ama proje SOLİD prensiplerine göre oluşturuşlduğu için bir veritabanı değişikliğine kolay adapte olabilecek niteliktedir. Business katmanında gerekli iş kodları yazılmıştır. Web api katmanına ise api tarafı kodlanmıştır

### Kullanılan Teknolojiler
---
- .Net Core 3.1
- MSSQL
- Autofac
- Entity Framework
- JWT
- Wep Api
- Katmanlı Mimari
- OOP
- AOP
- Fluent Validation
