using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Impl;
using transformers_battle_sim.Data.Impl;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace transformers_battle_sim.Models
{
    public static class TestData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var repo = new TransformerRepository(
            serviceProvider.GetRequiredService<
                DbContextOptions<TransformerRepository>>()))
            {



            }
        }
    }
}
