using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kek.DATA.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string Fullname { get; set; } = string.Empty;
        public string Address { get; set; } =string.Empty;
        public int UserTypeId { get; set; }
        public string UserImage { get; set; } = string.Empty;
    }
}
