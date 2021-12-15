using System.ComponentModel.DataAnnotations;

namespace meetup_2_asp_net_core.Models
{
    public class NewCommentRequest
    {
        [Required]
        [MaxLength(10)]
        [MinLength(0)]
        // [StringLength(100)]
        public string Message { get; set; }
    }
}
