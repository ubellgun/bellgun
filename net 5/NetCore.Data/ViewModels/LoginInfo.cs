using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Data.ViewModels
{
    public class LoginInfo
    {[Required(ErrorMessage ="아이디를 입력하세요")]
        [MinLength(6, ErrorMessage = "6자리 이상")]
        [Display(Name ="사용자 아이디")]
        public string UserId { get; set; }
        [Required(ErrorMessage ="비밀번호를 입력하세요")]
        [MinLength(6, ErrorMessage = "6자리 이상")]
        [Display(Name ="비밀번호")]
        public string Password { get; set; }
    }
}
