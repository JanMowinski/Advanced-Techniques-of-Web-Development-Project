﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZTW.Models
{
    public class User
    {
        public long ID { get; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
