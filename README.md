# Toplantı Salonu
Üç farklı toplantı odası için(¨orneğin: Oda A,B,C) günlük rezervasyon yapılacak.
Her odanın kendine  özgü rezervasyon saatleri belirlenecek(¨orn. Oda A: 09:00–11:00, 11:30–13:30, vb.).
Kullanıcılar, Windows Form arayüzü üzerinden rezervasyon bilgilerini (oda seçimi, tarih, saat, isim)girecek.
Rezervasyonlar, FileStream kullanılarak yerel dosyaya kaydedilecek.
Aynı saat için rezervasyon yapılmak istendiğinde, sistem dolu olduğunu bildirip en yakın uygun zamanı önerecek.
Özet butonuna tıklandığında, o gün için tüm odaların rezervasyon bilgileri topluca görüntülenecek
