using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Dtos
{
    public class UserDetailDto:IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClaimName { get; set; }
    }
}
