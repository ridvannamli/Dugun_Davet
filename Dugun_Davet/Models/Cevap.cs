using System.ComponentModel.DataAnnotations;

namespace Dugun_Davet.Models
{
    public class Cevap
    {
        [Required(ErrorMessage ="Lütfen ad alanını boş bırakmayınız!")]
        public string Ad { get; set; }
        [Required(ErrorMessage ="Lütfen soyad alanını boş bırakmayınız!")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Lütfen email alanını boş bırakmayınız!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen telefon alanını boş bırakmayınız!")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Lütfen bir seçim yapınız!")]
        public bool? DuguneGelecekmi { get; set; }
    }
}
