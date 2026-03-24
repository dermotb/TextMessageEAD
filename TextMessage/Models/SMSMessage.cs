using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TextMessage.Models
{
    public class SMSMessage
    {
        [Required(ErrorMessage ="To Number must not be blank!")]
        [StringLength(10, MinimumLength =10, ErrorMessage ="Number must be 10 digits long")]
        [RegularExpression(@"^\d{10}$", ErrorMessage ="Number must consist of just 10 digits")]
        [DisplayName("To:")]
        public string ToNumber { get; set; }

        [Required(ErrorMessage ="Message cannot be blank")]
        [StringLength(140, ErrorMessage ="Message maximum limit is 140 characters")]
        [DisplayName("Message Content:")]
        public string Content { get; set; }
    }
}
