using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Core.Entities.Concretes
{
    public class User:IEntity
    {
        public int UserId{ get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int ImageId { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash{ get; set; }
    }
}
