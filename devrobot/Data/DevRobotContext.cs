using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devrobot.Models;

namespace devrobot.Data
{
    public class DevRobotContext : DbContext
    {
        public DevRobotContext(DbContextOptions<DevRobotContext> options) : base(options) { }
        public DbSet<devrobot.Models.Autenticacao> Autenticacao { get; set; }
        //public DbSet<Usuario> Usuario { get; set; }


    }
}
