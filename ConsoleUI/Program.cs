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
            //CarGet();
            //CarDelete();
            //CarGetDatilsDTO();
            //CarAdd();
            //CarUpdate();
            //CarGetAll();

            //BrandAdd();
            //BrandDelete();
            //BrandUpdate();
            //BrandGet();
            //BrandGetAll();

            //ColorAdd();
            //ColorDelete();
            //ColorUpdate();
            //ColorGet();
            //ColorGetAll();
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /* CAR GET ALL */
            try
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Arabalar getirilmeye çalışırklen bir hata oluştu");

            }
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /* CAR UPDATE */
            try
            {
                carManager.Update(new Car
                {
                    Id = 8,
                    BrandId = 5,
                    ColorId = 1,
                    ModelYear = "11/02/2021",
                    Description = "Tam bir fiyat performans aracıdır.",
                    DailyPrice = 299999
                });

                Console.WriteLine("Araba başarıyla güncellendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Araba güncellenmeye çalışırken bir hata oluştu");
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /* CAR ADD */
            try
            {
                carManager.Add(new Car
                {
                    BrandId = 1,
                    ColorId = 1,
                    Description = "Çok güzel bir arabadır",
                    DailyPrice = 420000,
                    ModelYear = "01/01/2021"
                });

                Console.WriteLine("Araba başarıyla veritabanına eklendi");
            }
            catch (Exception)
            {

                Console.WriteLine("Araba oluşturulurken hata oluştu");
            }
        }

        private static void CarGetDatilsDTO()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            /* CAR DTO */
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Marka: {0}, Renk: {1}, Açıklama: {2}, Fiyat: {3}", car.BrandName, car.ColorName, car.Description, car.DailyPrice);
            }
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            /* CAR DELETE */
            try
            {
                carManager.Delete(new Car
                {
                    Id = 9
                });

                Console.WriteLine("Araba başarıyla silindi");
            }
            catch (Exception)
            {
                Console.WriteLine("Araba silinmeye çalışırken bir hata oluştu");
            }
        }

        private static void CarGet()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /* CAR GET */
            try
            {
                Console.WriteLine(carManager.GetById(8).Data.Description);

            }
            catch (Exception)
            {
                Console.WriteLine("Marka getirilmeye çalışırken bir hata oluştu");
            }


        }

        private static void BrandGet()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            /* BRAND GET */
            try
            {
                Console.WriteLine(brandManager.Get(1).Data.Name);

            }
            catch (Exception)
            {
                Console.WriteLine("Marka getirilmeye çalışırken bir hata oluştu");
            }
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            /* BRAND ADD */
            try
            {
                brandManager.Add(new Brand { Name = "Audi" });
                brandManager.Add(new Brand { Name = "Aston Martin" });
                brandManager.Add(new Brand { Name = "Porche" });

                Console.WriteLine("Marka başarıyla veritabanına eklendi");
            }
            catch (Exception)
            {

                Console.WriteLine("Marka oluşturulurken hata oluştu");
            }
        }
        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            /* BRAND UPDATE */
            try
            {
                brandManager.Update(new Brand
                {
                    Id = 2,
                    Name = "Aston Martin"
                });

                Console.WriteLine("Marka başarıyla güncellendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Marka güncellenmeye çalışırken bir hata oluştu");
            }
        }
        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            /* BRAND DELETE */
            try
            {
                brandManager.Delete(new Brand
                {
                    Id = 1
                });


                Console.WriteLine("Marka başarıyla silindi");
            }
            catch (Exception)
            {
                Console.WriteLine("Marka silinmeye çalışırken bir hata oluştu");
            }
        }
        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            /* BRAND GET ALL */
            try
            {
                var sayac = 0;
                foreach (var brand in brandManager.GetAll().Data)
                {
                    sayac++;
                    Console.WriteLine("{0}. Marka: {1}", sayac, brand.Name);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Markalar getirilmeye çalışırken bir hata oluştu");
            }
        }

        private static void ColorGet()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            /* COLOR GET */
            try
            {
                Console.WriteLine(colorManager.Get(1).Data.Name);

            }
            catch (Exception)
            {
                Console.WriteLine("Renk getirilmeye çalışırken bir hata oluştu");
            }

        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            /* COLOR ADD */
            try
            {
                colorManager.Add(new Color { Name = "Turuncu" });
                colorManager.Add(new Color { Name = "Siyah" });
                colorManager.Add(new Color { Name = "Mavi" });
                colorManager.Add(new Color { Name = "Kırmızı" });
                colorManager.Add(new Color { Name = "Sarı" });

                Console.WriteLine("Renk başarıyla veritabanına eklendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Renk eklemeye çalışırken bir hata oluştu");
            }
        }
        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            /* COLOR UPDATE */
            try
            {
                colorManager.Update(new Color
                {
                    Id = 3,
                    Name = "Sarı"
                });

                Console.WriteLine("Renk başarıyla güncellendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Renk güncellenmeye çalışırken bir hata oluştu");
            }
        }
        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            /* COLOR DELETE */
            try
            {
                colorManager.Delete(new Color
                {
                    Id = 2
                });

                Console.WriteLine("Renk başarıyla silindi");
            }
            catch (Exception)
            {
                Console.WriteLine("Renk silinmeye çalışırken bir hata oluştu");
            }
        }
        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            /* COLOR GET ALL */
            try
            {
                var sayac = 0;
                foreach (var color in colorManager.GetAll().Data)
                {
                    sayac++;
                    Console.WriteLine("{0}. Renk: {1}", sayac, color.Name);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Renkler getirilmeye çalışırken bir hata oluştu");
            }
        }
    }
}
