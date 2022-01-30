
using ClassMethotDemo;


Musteri musteri1 = new Musteri()
{ Name = "Musteri 1", Id = 1111, Description = "ilk Musteri", Price = 30 };

Musteri musteri2 = new Musteri()
{ Name = "Musteri 2", Id = 2222, Description = "2. Musteri", Price = 40 };

Musteri musteri3 = new Musteri()
{ Name = "Musteri 3", Id = 3333, Description = "3. Musteri", Price = 50 };

Musteri musteri4 = new Musteri()
{ Name = "Musteri 4", Id = 4444, Description = "4. Musteri", Price = 60 };

MusteriManager musteriManager = new MusteriManager();

musteriManager.MusteriEkleme(musteri1);
musteriManager.MusteriEkleme(musteri2);
musteriManager.MusteriEkleme(musteri3);
musteriManager.MusteriEkleme(musteri4);


musteriManager.MusteriSilme(musteri1);

musteriManager.Yazdirma();

