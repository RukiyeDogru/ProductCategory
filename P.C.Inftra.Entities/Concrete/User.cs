﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Inftra.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
