# Çok Katmanlı C# Web API Projesi (Entity Framework ile)

Bu proje, C# ile geliştirilmiş, Entity Framework kullanan çok katmanlı bir Web API örneğidir. Proje katmanları şunlardır:

- **API Katmanı**: HTTP isteklerini karşılar, dış dünyaya veri sunar.
- **Business Katmanı**: İş kurallarını ve iş mantığını içerir.
- **Data Access Katmanı (DAL)**: Veritabanı işlemlerini gerçekleştirir (EF Core).
- **Entities Katmanı**: Veri modellerini/tiplerini barındırır.
