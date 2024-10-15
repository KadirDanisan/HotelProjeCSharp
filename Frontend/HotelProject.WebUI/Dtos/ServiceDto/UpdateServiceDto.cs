using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Servis ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması giriniz")]
        [StringLength(250, ErrorMessage = "Hizmet Açıklaması en fazla 250 karakter olabilir")]
        public string Description { get; set; }
    }
}
