using Business.Concrete;
using Core.Entities.Concrete;
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

            //UserAdd();
            //UserDelete();
            //UserUpdate();
            //UserGetAll();
            //UserGet();

            //CustomerAdd();
            //CustomerDelete();
            //CustomerUpdate();
            //CustomerGetAll();
            //CustomerGet();

            RentalAdd();
            //RentalDelete();
            //RentalUpdate();
            //RentalGetAll();
            //RentalGet();
        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = new DateTime(2021, 2, 23)
            });
            Console.WriteLine(result.Message);
            
        }
        private static void RentalDelete()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Delete(new Rental
            {
                Id = 5
            });
            Console.WriteLine(result.Message);

        }
        private static void RentalUpdate()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Update(new Rental
            {
                Id = 7,
                CarId = 1004,
                CustomerId = 3,
                RentDate = new DateTime(2021, 02,10),
                ReturnDate = DateTime.Today
                
            });
            Console.WriteLine(result.Message);

        }
        private static void RentalGetAll()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();
            foreach (var rent in result.Data)
            {
                Console.WriteLine("Araba Kiralama Tarihi: {0} \n Araba Teslim Tarihi: {1}", rent.RentDate, rent.ReturnDate);
                Console.WriteLine("---------------------------------");
            }

        }
        private static void RentalGet()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Get(1).Data;

            Console.WriteLine("Araba Kiralama Tarihi: {0} \n Araba Teslim Tarihi: {1}", result.RentDate, result.ReturnDate);

        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            try
            {
                //userManager.Add(new User
                //{
                //    FirstName = "Oğuzhan",
                //    LastName = "Yalçınkaya",
                //    Email = "oguzhanyalcinkayaa@gmail.com",
                //    Password = "123456789"
                //});
                //userManager.Add(new User
                //{
                //    FirstName = "Emin",
                //    LastName = "Meral",
                //    Email = "eminmeral@gmail.com",
                //    Password = "123456789"
                //});
                //userManager.Add(new User
                //{
                //    FirstName = "Ebru",
                //    LastName = "Arslan",
                //    Email = "ebru@gmail.com",
                //    Password = "123456789"
                //});
                //userManager.Add(new User
                //{
                //    FirstName = "Batuhan",
                //    LastName = "Yıldız",
                //    Email = "batu@gmail.com",
                //    Password = "123456789"
                //});
                //userManager.Add(new User
                //{
                //    FirstName = "Candan",
                //    LastName = "Sumaktaş",
                //    Email = "candan@gmail.com",
                //    Password = "123456789"
                //});

                Console.WriteLine("Kullanıcı eklendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Kullanıcı eklenirken bir hata oluştu");
            }
            
        }
        private static void UserDelete()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            try
            {
                userManager.Delete(new User { Id = 5 });

                Console.WriteLine("Kullanıcı silindi");
            }
            catch (Exception)
            {
                Console.WriteLine("Kullanıcı silinirken bir hata oluştu");
            }

        }
        private static void UserUpdate()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            try
            {
                //userManager.Update(new User
                //{
                //    Id = 4,
                //    FirstName = "Engin",
                //    LastName = "Demiroğ",
                //    Email = "sdfsdfdsfdsdsf",
                //    Password = "15484sddfds"
                //});

                Console.WriteLine("Kullanıcı güncellendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Kullanıcı güncellenirken bir hata oluştu");
            }

        }
        private static void UserGetAll()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            try
            {
                foreach (var user in userManager.GetAll().Data)
                {
                    Console.WriteLine("Kullanıcı Adı: {0} Kullanıcı Soyadı: {1}", user.FirstName, user.LastName);
                }
         
            }
            catch (Exception)
            {
                Console.WriteLine("Kullanıcı güncellenirken bir hata oluştu");
            }

        }
        private static void UserGet()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            try
            {
                Console.WriteLine("Kullanıcı Adı: {0} Kullanıcı Soyadı: {1}",userManager.Get(1).Data.FirstName, userManager.Get(1).Data.LastName);
            }
            catch (Exception)
            {
                Console.WriteLine("Kullanıcı getirilirken bir hata oluştu");
            }

        }


        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            try
            {
                customerManager.Add(new Customer
                {
                    UserId = 1,
                    CompanyName = "Hello Human Yazılım Şirketi"
                });
                customerManager.Add(new Customer
                {
                    UserId = 2,
                    CompanyName = "Hello World Yazılım Şirketi"
                });
                customerManager.Add(new Customer
                {
                    UserId = 3,
                    CompanyName = "Hello Banana Yazılım Şirketi"
                });
                customerManager.Add(new Customer
                {
                    UserId = 4,
                    CompanyName = "Hello Creator Yazılım Şirketi"
                });
                customerManager.Add(new Customer
                {
                    UserId = 5,
                    CompanyName = "Hello Mars Yazılım Şirketi"
                });

                Console.WriteLine("Müşteri eklendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Müşteri eklenirken bir hata oluştu");
            }

        }
        private static void CustomerDelete()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            try
            {
                customerManager.Delete(new Customer { Id = 4 });

                Console.WriteLine("Müşteri silindi");
            }
            catch (Exception)
            {
                Console.WriteLine("Müşteri silinirken bir hata oluştu");
            }

        }
        private static void CustomerUpdate()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            try
            {
                customerManager.Update(new Customer
                {
                    Id = 1,
                    UserId = 1,
                    CompanyName = "Yazılımcı Abinin Yeri"
                });

                Console.WriteLine("Müşteri güncellendi");
            }
            catch (Exception)
            {
                Console.WriteLine("Müşteri güncellenirken bir hata oluştu");
            }

        }
        private static void CustomerGetAll()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            try
            {
                foreach (var customer in customerManager.GetAll().Data)
                {
                    Console.WriteLine("Müşteri Şirket Adı: {0}", customer.CompanyName);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Müşteriler getirilirken bir hata oluştu");
            }

        }
        private static void CustomerGet()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            try
            {
                Console.WriteLine("Müşteri Şirket Adı: {0}", customerManager.Get(1).Data.CompanyName);
            }
            catch (Exception)
            {
                Console.WriteLine("Müşteri getirilirken bir hata oluştu");
            }

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
                    Description = "Audi turuncu araba",
                    DailyPrice = 420000,
                    ModelYear = "01/01/2021"
                });
                carManager.Add(new Car
                {
                    BrandId = 2,
                    ColorId = 2,
                    Description = "Siyah Auston Martin, cillop gibi araba",
                    DailyPrice = 420000,
                    ModelYear = "01/01/2021"
                });
                carManager.Add(new Car
                {
                    BrandId = 3,
                    ColorId = 3,
                    Description = "Mavi Porche, tam bir asil arabası :D",
                    DailyPrice = 420000,
                    ModelYear = "01/01/2021"
                });
                carManager.Add(new Car
                {
                    BrandId = 4,
                    ColorId = 4,
                    Description = "Kırmızı Tofaş, fakir ama gururlu arabası",
                    DailyPrice = 420000,
                    ModelYear = "01/01/2021"
                });
                carManager.Add(new Car
                {
                    BrandId = 5,
                    ColorId = 5,
                    Description = "Sarı Tesla, iyi arabadır",
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
                brandManager.Add(new Brand { Name = "Tofaş" });
                brandManager.Add(new Brand { Name = "Tesla" });
                brandManager.Add(new Brand { Name = "Ford" });

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
