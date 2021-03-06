﻿namespace ConsoleForum.Entities.Users
{
    using ConsoleForum.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Administrator : User
    {
        public Administrator(int id, string name, string password, string email)
            : base(id, name, password, email)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " (Administrator)";
        }
    }
}
