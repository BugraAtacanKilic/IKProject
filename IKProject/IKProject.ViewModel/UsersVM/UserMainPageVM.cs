using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.ViewModel.UsersVM
{
    public class UserMainPageVM
    {
        public int ID { get; set; }
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }
        [Display(Name = "Departman")]
        public string Departman { get; set; }
        [Display(Name = "Ünvan")]
        public string Unvan { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Display(Name = "E-mail Adresi")]
        public string Mail { get; set; }
        public string PhotoPath { get; set; }

    }
}
