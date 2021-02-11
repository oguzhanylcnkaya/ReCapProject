using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
     
            CarMethod();

            //BrandMethod();

            //ColorMethod();
        }

        private static void CarMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka: {0}, Renk: {1}, Açıklama: {2}, Fiyat: {3}", car.BrandName, car.ColorName, car.Description, car.DailyPrice);
            }

            /* CAR ADD */
            //try
            //{
            //    carManager.Add(new Car { 
            //        BrandId = 1, 
            //        ColorId = 1, 
            //        Description = "Araba 1", 
            //        DailyPrice = 200000,
            //        ModelYear = "30/07/2020"
            //    });
            //    carManager.Add(new Car
            //    {
            //        BrandId = 2,
            //        ColorId = 2,
            //        Description = "Araba 2",
            //        DailyPrice = 500000,
            //        ModelYear = "30/07/2020"
            //    });
            //    carManager.Add(new Car
            //    {
            //        BrandId = 3,
            //        ColorId = 3,
            //        Description = "Araba 3",
            //        DailyPrice = 750000,
            //        ModelYear = "30/07/2020"
            //    });
            //    carManager.Add(new Car
            //    {
            //        BrandId = 4,
            //        ColorId = 4,
            //        Description = "Araba 4",
            //        DailyPrice = 67354,
            //        ModelYear = "30/07/2020"
            //    });
            //    carManager.Add(new Car
            //    {
            //        BrandId = 4,
            //        ColorId = 5,
            //        Description = "Araba 5",
            //        DailyPrice = 181000,
            //        ModelYear = "30/07/2020"
            //    });

            //    Console.WriteLine("Araba başarıyla veritabanına eklendi");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Araba oluşturulurken hata oluştu");
            //}

            /* CAR UPDATE */
            //try
            //{
            //    carManager.Update(new Car
            //    {
            //        Id = 8,
            //        BrandId = 5,
            //        ColorId = 1,
            //        ModelYear = "11/02/2021",
            //        Description = "Araba güncellendi",
            //        DailyPrice = 299999               
            //    });

            //    Console.WriteLine("Araba başarıyla güncellendi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Araba güncellenmeye çalışırken bir hata oluştu");
            //}

            /* CAR DELETE */
            //try
            //{
            //    carManager.Delete(new Car
            //    {
            //        Id = 9
            //    });

            //    Console.WriteLine("Araba başarıyla silindi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Araba silinmeye çalışırken bir hata oluştu");
            //}

            /* CAR GET ALL */
            //try
            //{
            //    foreach (var car in carManager.GetAll())
            //    {
            //        Console.WriteLine(car.Description);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Arabalar getirilmeye çalışırklen bir hata oluştu");

            //}

            /* CAR GET */
            //try
            //{
            //    Console.WriteLine(carManager.GetById(8).Description);

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Marka getirilmeye çalışırken bir hata oluştu");
            //}


        }

        private static void BrandMethod()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            /* BRAND ADD */
            //try
            //{
            //    brandManager.Add(new Brand { Name = "Audi" });
            //    brandManager.Add(new Brand { Name = "Aston Martin" });
            //    brandManager.Add(new Brand { Name = "Porche" });

            //    Console.WriteLine("Marka başarıyla veritabanına eklendi");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Marka oluşturulurken hata oluştu");
            //}

            /* BRAND UPDATE */
            //try
            //{
            //    brandManager.Update(new Brand
            //    {
            //        Id = 2,
            //        Name = "Aston Martin"
            //    });

            //    Console.WriteLine("Marka başarıyla güncellendi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Marka güncellenmeye çalışırken bir hata oluştu");
            //}

            /* BRAND DELETE */
            //try
            //{
            //    brandManager.Delete(new Brand
            //    {
            //        Id = 1
            //    });


            //    Console.WriteLine("Marka başarıyla silindi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Marka silinmeye çalışırken bir hata oluştu");
            //}

            /* BRAND GET ALL */
            //try
            //{
            //    var sayac = 0;
            //    foreach (var brand in brandManager.GetAll())
            //    {
            //        sayac++;
            //        Console.WriteLine("{0}. Marka: {1}", sayac, brand.Name);
            //    }

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Markalar getirilmeye çalışırken bir hata oluştu");
            //}

            /* BRAND GET */
            //try
            //{
            //    Console.WriteLine(brandManager.Get(1).Name);

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Marka getirilmeye çalışırken bir hata oluştu");
            //}
        }

        private static void ColorMethod()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            /* COLOR ADD */
            //try
            //{
            //    colorManager.Add(new Color { Name = "Turuncu" });
            //    colorManager.Add(new Color { Name = "Siyah" });
            //    colorManager.Add(new Color { Name = "Mavi" });
            //    colorManager.Add(new Color { Name = "Kırmızı" });
            //    colorManager.Add(new Color { Name = "Sarı" });

            //    Console.WriteLine("Renk başarıyla veritabanına eklendi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Renk eklemeye çalışırken bir hata oluştu");
            //}

            /* COLOR UPDATE */
            //try
            //{
            //    colorManager.Update(new Color
            //    {
            //        Id = 3,
            //        Name = "Sarı"
            //    });

            //    Console.WriteLine("Renk başarıyla güncellendi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Renk güncellenmeye çalışırken bir hata oluştu");
            //}

            /* COLOR DELETE */
            //try
            //{
            //    colorManager.Delete(new Color
            //    {
            //        Id = 2
            //    });

            //    Console.WriteLine("Renk başarıyla silindi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Renk silinmeye çalışırken bir hata oluştu");
            //}

            /* COLOR GET ALL */
            //try
            //{
            //    var sayac = 0;
            //    foreach (var color in colorManager.GetAll())
            //    {
            //        sayac++;
            //        Console.WriteLine("{0}. Renk: {1}", sayac, color.Name);
            //    }

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Renkler getirilmeye çalışırken bir hata oluştu");
            //}

            /* COLOR GET */
            //try
            //{
            //    Console.WriteLine(colorManager.Get(1).Name);

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Renk getirilmeye çalışırken bir hata oluştu");
            //}

        }
    }
}
