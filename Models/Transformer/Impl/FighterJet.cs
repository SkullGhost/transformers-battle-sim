using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class FighterJet : Mode
    {
        public FighterJet()
        {
            ModeName = "Fighter Jet";
            MovementType = MovementType.FLYING;
            MovementSpeed = 500;
            AttackPower = 5;
        }

    }
}
