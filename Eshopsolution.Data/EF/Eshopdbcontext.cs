using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshopsolution.Data.EF
{
    public class Eshopdbcontext : DbContext

    {
        public Eshopdbcontext([NotNullAttribute] DbContextOptions options) : base(options)
        {
            options.UseSqlSever("");
        }
    }
}
