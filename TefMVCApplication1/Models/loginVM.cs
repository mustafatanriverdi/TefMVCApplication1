using System.ComponentModel.DataAnnotations;

namespace TefMVCApplication1.Models
{
    public class loginVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
