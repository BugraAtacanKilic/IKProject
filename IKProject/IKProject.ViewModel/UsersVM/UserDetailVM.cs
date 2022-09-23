using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.ViewModel.UsersVM
{
    public class UserDetailVM
    {

        public int ID { get; set; }

        [Display(Name = "Ad Soyad")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }

        [Display(Name = "E-posta")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "TC Kimlik")]
        [DataType(DataType.PhoneNumber)]
        public string TCKimlik { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Ünvan")]
        public string Unvan { get; set; }

        [Display(Name = "Departman")]
        public string Departman { get; set; }

        [Display(Name = "İşe Giriş Tarihi")]
        public DateTime StartDate { get; set; }

        [Display(Name = "İşten Çıkış Tarihi")]
        public string EndDate { get; set; }

        [Display(Name = "Aktif / Pasif")]
        public string IsActive { get; set; }
        public string PhotoPath { get; set; }

        public string CompanyName { get; set; }

        public int CompanyID { get; set; }
        public string CompanyPhoto { get; set; }

        public short ActiveUsersLimit { get; set; }

        public short ActiveUsersNo { get; set; }

        public int RolTypeID { get; set; }

    }
}
