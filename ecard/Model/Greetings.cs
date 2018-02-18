using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
    public class Greetings
    {
        /*
         * ID   int 
         * FriendName str
         * friendemail str
         * subject str
         * message str
         * sendername str 
         * senderemail str
         * 
         * */

        [Key]
        public int? ID { get; set; }

        [DisplayName("Your friend's name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "Name must be between 2 and 100 characters for the name")]
        public string FriendName { get; set; }

        [DisplayName("Your friend's email")]
        [Required(ErrorMessage = "Required Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string FriendEmail { get; set; }

        [DisplayName("Subject")]
        [Required(ErrorMessage = "Subject Required")]
        public string Subject { get; set; }

        [DisplayName("Message")]
        [Required(ErrorMessage = "Message Required")]
        public string Message { get; set; }

        [DisplayName("SenderName")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "Name must be between 2 and 100 characters for the name")]
        public string SenderName { get; set; }

        [DisplayName("SenderEmail")]
        [Required(ErrorMessage = "Required Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string SenderEmail { get; set; }
    }
}
