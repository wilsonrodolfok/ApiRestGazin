using ARG.Dominio;
using Microsoft.EntityFrameworkCore;
using System;

namespace ARG.Infraestrutura
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options) : base(options)
        {         
        }
        public DbSet<Desenvolvedores> Desenvolvedores { get; set; }
        public DbSet<Niveis> Niveis { get; set; }
    }
}
