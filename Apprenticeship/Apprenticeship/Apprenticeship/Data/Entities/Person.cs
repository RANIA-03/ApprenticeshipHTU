﻿using Microsoft.AspNetCore.Identity;

namespace Apprenticeship.Data.Entities
{
    public class Person : IdentityUser
    {
        public string fristName { get; set; }
        public string secondName { get; set; }
        public string thirdName { get; set; }
        public string lastName { get; set; }
    }
}
