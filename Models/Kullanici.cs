using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArabaApp.Models
{
    public class Kullanici
    {
       [Required(ErrorMessage =" {0} Alanı gereklidir")]
        public string  Ad { get; set; }
        [Required(ErrorMessage ="{0} boş bırakılamaz")]
        public string Soyad { get; set; }

        [Required(ErrorMessage ="Email alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage ="geçerli bir email giriniz")]
        public string EmailAdresi { get; set; }

         [Required(ErrorMessage="Telefon numarası gereklidir")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "geçerli bir numara giriniz.")]
        public string Telefon {get; set;}

        [Required]
        [MaxLength(12)]
        [MinLength(6)]
        public string Sifre {get;set;}
        [Compare("Sifre")]
        public string SifreTekrari {get;set;}
        
    }
}