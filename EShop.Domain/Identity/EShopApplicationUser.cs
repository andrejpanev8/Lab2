﻿using EShop.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.Identity
{ 
    public class EShopApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Ticket> MyTickets { get; set; }
    }
}
