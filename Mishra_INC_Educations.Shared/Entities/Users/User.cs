using System;
using System.Collections.Generic;
using System.Text;

namespace Mishra_INC_Educations.Shared.Entities.Users
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public long MobileNo { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string TemporaryPassword { get; set; }

    }
}
