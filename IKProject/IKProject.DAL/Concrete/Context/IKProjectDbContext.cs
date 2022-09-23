using IKProject.DAL.Concrete.Context.EntityTypeConfiguration;
using IKProject.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DAL.Concrete.Context
{
    class IKProjectDbContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ikprojesi.database.windows.net;Initial Catalog=IKProjeDB;User ID=azureuser;Password=Scrum123;Connect Timeout=0;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

          

        }

        public DbSet<Company> Companys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<RolType> RolTypes { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RolTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    ID = 1,
                    Name = "Bilgeadam Teknoloji",
                    MailTag = "@bilgeadam.com",
                    LogoPath = @"~\assets\img\Companys\1.png",
                    Description = "Bilgeadam bir teknoloji şirketidir.",
                    ActiveUsersNo = 5,
                    Adress = "Reşitpaşa Mah. Katar Cad. Teknokent ARI 3 No: 4 B3 Sarıyer / İstanbul.",
                    Phone = " 08502016000"                   
                }
                );

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    ID = 1,
                    Name = "İnsan Kaynakları",
                },
                new Department
                {
                    ID = 2,
                    Name = "Yazılım"
                },
                new Department
                {
                    ID = 3,
                    Name = "Pazarlama"
                }
                );
            modelBuilder.Entity<RolType>().HasData(
                new RolType
                {
                    ID = 1,
                    Name = "Admin"
                },
                new RolType
                {
                    ID = 2,
                    Name = "Şirket Yöneticisi"
                },
                new RolType
                {
                    ID = 3,
                    Name = "Çalışan"
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Mail = "hasanserhatbayar@bilgeadam.com",
                    Password = "Abc123.",
                    Name = "Hasan Serhat",
                    Surname = "Bayar",
                    TC = "46195695988",
                    BirthDate = DateTime.Today,                    
                    Title = "Junior Yazılım Uzmanı",
                    StartDate = DateTime.Today,
                    PhoneNumber = "05554443696",
                    Adress = "Kağıthane/İstanbul",
                    PhotoUrlPath = @"~\assets\img\Users\1.jpg",
                    SendEmailTime = DateTime.Today,
                    EmailActiveUser = true,
                    IsActive=true,
                    CompanyID = 1,
                    DepartmentID = 2,
                    RolTypeID = 3
                },
                 new User
                 {
                     ID = 2,
                     Mail = "gamzealtinelli@bilgeadam.com",
                     Password = "Abc123.",
                     Name = "Gamze",
                     Surname = "Altınelli",
                     TC = "45687895321",
                     BirthDate = DateTime.Today,                     
                     Title = "Senior Yazılım Uzmanı",
                     StartDate = DateTime.Today,
                     PhoneNumber = "05456332568",
                     Adress = "Üsküdar/İstanbul",
                     PhotoUrlPath = @"~\assets\img\Users\2.jpg",
                     SendEmailTime = DateTime.Today,
                     EmailActiveUser = true,
                     IsActive = true,
                     CompanyID = 1,
                     DepartmentID = 1,
                     RolTypeID = 2
                 },
                new User
                {
                    ID = 3,
                    Mail = "tanerguler@bilgeadam.com",
                    Password = "Abc123.",
                    Name = "Taner",
                    Surname = "Güler",
                    TC = "45698756235",
                    BirthDate = DateTime.Today,                    
                    Title = "Junior Yazılım Uzmanı",
                    StartDate = DateTime.Today,
                    PhoneNumber = "05442365898",
                    Adress = "Beşiktaş/İstanbul",
                    PhotoUrlPath = @"~\assets\img\Users\3.jpg",
                    SendEmailTime = DateTime.Today,
                    EmailActiveUser = true,
                    IsActive = true,
                    CompanyID = 1,
                    DepartmentID = 2,
                    RolTypeID = 3
                },
                new User
                {
                    ID = 4,
                    Mail = "murathantandogan@bilgeadam.com",
                    Password = "Abc123.",
                    Name = "Murathan",
                    Surname = "Tandoğan",
                    TC = "35698756985",
                    BirthDate = DateTime.Today,                    
                    Title = "Junior",
                    StartDate = DateTime.Today,
                    PhoneNumber = "05325659632",
                    Adress = "Kartal/İstanbul",
                    PhotoUrlPath = @"~\assets\img\Users\4.jpg",
                    SendEmailTime = DateTime.Today,
                    EmailActiveUser = true,
                    IsActive = true,
                    CompanyID = 1,
                    DepartmentID = 2,
                    RolTypeID = 3
                },
                 new User
                 {
                     ID = 5,
                     Mail = "yunussukrugulten@bilgeadam.com",
                     Password = "Abc123.",
                     Name = "Yunus Şükrü",
                     Surname = "Gülten",
                     TC = "12365896321",
                     BirthDate = DateTime.Today,                    
                     Title = "Pazarlama Uzmanı",
                     StartDate = DateTime.Today,
                     PhoneNumber = "05412327852",
                     Adress = "Sarıyer/İstanbul",
                     PhotoUrlPath = @"~\assets\img\Users\5.jpg",
                     SendEmailTime = DateTime.Today,
                     EmailActiveUser = true,
                     IsActive = true,
                     CompanyID = 1,
                     DepartmentID = 3,
                     RolTypeID = 3
                 },
                  new User
                  {
                      ID = 6,
                      Mail = "ahmetmuhsinoglu@bilgeadam.com",
                      Password = "Abc123.",
                      Name = "Ahmet",
                      Surname = "Muhsinoğlu",
                      TC = "754232659852",
                      BirthDate = DateTime.Today,                      
                      Title = "Pazarlama Uzman Yardımcısı",
                      StartDate = DateTime.Today,
                      PhoneNumber = "05345883211",
                      Adress = "Çengelköy/İstanbul",
                      PhotoUrlPath = @"~\assets\img\Users\6.jpg",
                      SendEmailTime = DateTime.Today,
                      EmailActiveUser = true,
                      IsActive = false,
                      CompanyID = 1,
                      DepartmentID = 3,
                      RolTypeID = 3
                  },
                   new User
                   {
                       ID = 7,
                       Mail = "serdaratay@bilgeadam.com",
                       Password = "Abc123.",
                       Name = "Serdar",
                       Surname = "Atay",
                       TC = "25369856325",
                       BirthDate = DateTime.Today,                       
                       Title = "Junior",
                       StartDate = DateTime.Today,
                       PhoneNumber = "05123336598",
                       Adress = "Kadıköy/İstanbul",
                       PhotoUrlPath = @"~\assets\img\Users\7.jpg",
                       SendEmailTime = DateTime.Today,
                       EmailActiveUser = true,
                       IsActive = false,
                       CompanyID = 1,
                       DepartmentID = 2,
                       RolTypeID = 3
                   },
                    new User
                    {
                        ID = 8,
                        Mail = "kaanlokum@bilgeadam.com",
                        Password = "Abc123.",
                        Name = "Kaan",
                        Surname = "Lokum",
                        TC = "45698965321",
                        BirthDate = DateTime.Today,                      
                        Title = "Junior",
                        StartDate = DateTime.Today,
                        PhoneNumber = "05235556321",
                        Adress = "Çekmeköy/İstanbul",
                        PhotoUrlPath = @"~\assets\img\Users\8.jpg",
                        SendEmailTime = DateTime.Today,
                        EmailActiveUser = true,
                        IsActive = false,
                        CompanyID = 1,
                        DepartmentID = 2,
                        RolTypeID = 3
                    }
                );
        }



    }
}
