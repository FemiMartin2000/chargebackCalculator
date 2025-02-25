﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChargeBackproject.Models
{
    public class UserDetailsContext : DbContext
    {
        public UserDetailsContext(): base("DefaultConnection")
        {

        }
        public DbSet<UserDetails> UserDetail { get; set; }
        public DbSet<LoginDetails> LoginDetail { get; set; }

        public DbSet<CustomerDetail> CustomerDetails { get; set; }

        public DbSet<TransactionDetail> TransactionDetails { get; set; }

        public DbSet<ComplaintDetail> ComplaintDetails { get; set; }
    }
}