using System.ComponentModel.DataAnnotations;

namespace MyStore.Models
{
    public class LoginVM
    {
        [Display(Name ="Tên đăng nhập")]
        public string UserName { get; set; }
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
    }
}
