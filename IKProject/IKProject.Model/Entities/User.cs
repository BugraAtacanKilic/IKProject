using IKProject.Core.Entity;
using IKProject.Model.Enums;
using System;

namespace IKProject.Model.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            IsActive = false;

        }
       
        public string Mail { get; set; }                // Email Adresi     
        public string Password { get; set; }            // Şifre
        public string Name { get; set; }                // Ad
        public string Surname { get; set; }             // soyad
        public string TC { get; set; }                  // Tc kimlik
        public DateTime BirthDate { get; set; }         //Doğum tarihi  
        public string Title { get; set; }               //  Uzmanlık
        public DateTime StartDate { get; set; }         // İşe Başlangıç Tarihi  Company
        public DateTime? EndDate { get; set; }          // İşten Çıkış Tarihi  Company
        public string PhoneNumber { get; set; }         // Telefon Numarası
        public string Adress { get; set; }              // Kişisel Adres
        public string PhotoUrlPath { get; set; }        // Kişisel Fotoğraf       
        public DateTime SendEmailTime { get; set; }      // 16:40 22 03 2022 addDay(1)
        public bool EmailActiveUser { get; set; } = false;  //true  Email kontrolü gerçekleştirme işlemi detaylar işlemler.

        
       




        public int CompanyID { get; set; }              
        public Company Company { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public int RolTypeID { get; set; }
        public RolType RolType { get; set; }



    }
}
