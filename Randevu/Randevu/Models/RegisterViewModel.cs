using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Randevu.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Belirtiniz")]
        [Display(Name = "Kullanıcı Adınız")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen  Adınızı Belirtiniz")]
        [Display(Name = " Adınız")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Belirtiniz")]
        [Display(Name = "Soyadınız")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        [Display(Name = "Şifreniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Emailinizi Belirtiniz")]
        [Display(Name = "Emailiniz")]
        [EmailAddress(ErrorMessage = "Lütfen Email Alanını Kontrol Ediniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Randevu Rengi Belirtiniz")]
        [Display(Name = "Randevu Rengi")]
        public string Color { get; set; }
        [Display(Name = "Personelim")]
        public bool Personel { get; set; }
    }
}
