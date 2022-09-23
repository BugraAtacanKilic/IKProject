using IKProject.ViewModel.Custom_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.ViewModel.UsersVM
{
    public class UserUpdateVM
    {
        public int ID { get; set; }

        [Display(Name = "İsim", Prompt = "İsim Giriniz.")]
        //[DataType(DataType.Text)]
        //[Required(ErrorMessage = "Lütfen İsim Giriniz.")]
        //[RegularExpression("^[A-Za-z ĞğÜüÇçÖöİıŞş]{3,29}$", ErrorMessage = "Lütfen geçerli bir isim giriniz")]
        public string Name { get; set; }                // Ad

        [Display(Name = "Soyisim", Prompt = "Soyisim Giriniz.")]
        //[DataType(DataType.Text)]
        //[Required(ErrorMessage = "Lütfen Soyisim Giriniz.")]
        //[RegularExpression("^[A-Za-z ĞğÜüÇçÖöİıŞş][A-Za-z]{3,29}$", ErrorMessage = "Lütfen geçerli bir Soyisim giriniz")]
        public string Surname { get; set; }             // soyad



        [Display(Name = "Doğum Tarihi", Prompt = "Doğum Tarihi Giriniz.")]
        //[Required(ErrorMessage = "Lütfen Doğum Tarihi Giriniz.")]
        //[DataType(DataType.Date)]
        //[BirthDate]
        public DateTime BirthDate { get; set; }         //Doğum tarihi


        [Display(Name = "Ünvan", Prompt = "Ünvan Bilgisi Giriniz.")]
        //[DataType(DataType.Text)]
        //[Required(ErrorMessage = "Lütfen Ünvan Bilgisi Giriniz.")]
        //[RegularExpression("^[A-Za-z ĞğÜüÇçÖöİıŞş]{3,29}$", ErrorMessage = "Lütfen geçerli bir Ünvan giriniz")]
        public string Title { get; set; }               //  Uzmanlık

        [Display(Name = "Başlangıç Tarihi", Prompt = "Başlangıç Tarihi Giriniz.")]
        //[Required(ErrorMessage = "Lütfen İşe Giriş Tarihi Giriniz.")]
        [DataType(DataType.Date)]
        //[StartDate]
        public DateTime StartDate { get; set; }         // İşe Başlangıç Tarihi  Company    

        [Display(Name = "Çıkış Tarihi", Prompt = "Çıkış Tarihi Giriniz.")]
        [Required(ErrorMessage = "Lütfen İşten Çıkış Tarihi Giriniz.")]
        [DataType(DataType.Date)]       
        public DateTime EndDate { get; set; }         // İşe Başlangıç Tarihi  Company   

        [Display(Name = "Telefon", Prompt = "x(xxx)-(xxx)-(xxxx)")]
        //[DataType(DataType.PhoneNumber, ErrorMessage = "Lütfen geçerli bir Telefon numarası giriniz.")]
        //[Required(ErrorMessage = "Lütfen Telefon Bilgisi Giriniz.")]
        //[RegularExpression("^[0][5]+$", ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz")]
        public string PhoneNumber { get; set; }         // Telefon Numarası

        [Display(Name = "Adres", Prompt = "Adres Giriniz.")]
        [DataType(DataType.Text)]
        //[Required(ErrorMessage = "Lütfen Adres Bilgisi Giriniz.")]
        //[MinLength(10, ErrorMessage = "Lütfen geçerli bir adres bilgisi giriniz.")]

        public string Adress { get; set; }


        [Display(Name = "Departman")]
        public int DepartmentID { get; set; }
        [Display(Name="Aktiflik Durumu")]
        public bool IsActive { get; set; }



    }
}
