
using System;
using BUSINESS_OBJECT.Objects;
namespace BUSINESS_OBJECT.Objects
{
    public class AccountObject
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string PassWord { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Isdeleted { get; set; }
        public Nullable<Guid> RoleId { get; set; }
        public RoleObject Roldeobj { get; set; }
        public bool LoginSuccess { get; set; }
    }
}
