using App.Core.AdminEntity;
using App.Core.CustomerEntity;
using App.Infra.Security;
using App.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.EFCore.Configs;

//public static class UserConfigs
//{
//    public static void Seed(ModelBuilder modelBuilder)
//    {
//        IPasswordHasher passwordHasher = new PasswordHasher();

//        modelBuilder.Entity<Admin>().HasData(
//            new Admin("navid", "navid@gmail.com", passwordHasher.HashPassword("123456")) { Id = 1 },
//            new Admin("admin", "admin", passwordHasher.HashPassword("admin")) { Id = 2 }
//            );

//        modelBuilder.Entity<Customer>().HasData(
//            new Customer("hasan", "hasan@gmail.com") { Id = 10 },
//            new Customer("amir", "amir@gmail.com") { Id = 11 },
//            new Customer("ali", "ali@gmail.com") { Id = 12 },
//            new Customer("parsa", "parsa@gmail.com") { Id = 13 },
//            new Customer("babak", "babak@gmail.com") { Id = 14 },
//            new Customer("sara", "sara@gmail.com") { Id = 15 }
//            );
//    }
//}
