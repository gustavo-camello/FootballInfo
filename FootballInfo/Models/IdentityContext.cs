using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballInfo.Models
{
    public class IdentityContext: IdentityDbContext<AppUser>
    {
        public IdentityContext()
            : base("InfoContext", throwIfV1Schema: false)
        {
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}