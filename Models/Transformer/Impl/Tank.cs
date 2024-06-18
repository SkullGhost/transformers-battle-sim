using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class Tank : Mode
    {
        public Tank()
        {
            ModeName = "Tank";
            MovementType = MovementType.TREADS;
            MovementSpeed = 45;
            AttackPower = 8;
        }
    }
}
