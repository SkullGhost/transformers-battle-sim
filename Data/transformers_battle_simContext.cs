using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using transformers_battle_sim.Models.Transformer.Impl;

namespace transformers_battle_sim.Data
{
    public class transformers_battle_simContext : DbContext
    {
        public transformers_battle_simContext (DbContextOptions<transformers_battle_simContext> options)
            : base(options)
        {
        }

        public DbSet<transformers_battle_sim.Models.Transformer.Impl.Transformer> Transformer { get; set; }
    }
}
