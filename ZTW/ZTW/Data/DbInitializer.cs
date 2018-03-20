using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZTW.Models;

namespace ZTW.Data
{
    public class DbInitializer
    {
        public static void Initialize(WebsiteContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }
            var users = new User[]
            {
                new User{Name="Jan",Surname="Mowiński",Email="j.mow96@gmail.com",DisplayName="janusz2137",RegistrationDate=DateTime.Now,BirthDate= new DateTime(year:1996, month:2, day:24),Password="qwerty"},
            };
            foreach(User user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
    }
}
