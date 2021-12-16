using System.ComponentModel.DataAnnotations;

namespace SmsMicroService.Api.Controllers
{
    public class SmsRequest
    {
        [Required(ErrorMessage = "Sms body is required")]
        public string Body { get; set; }
        [Required(ErrorMessage = "Sms body is required")]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}