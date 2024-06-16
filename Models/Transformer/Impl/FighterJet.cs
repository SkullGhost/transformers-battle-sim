using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class FighterJet : IMode
    {
        public string GetModeName()
        {
            return "Fighter Jet";
        }
        public MovementType GetMovementType()
        {
            return MovementType.FLYING;
        }
        public double GetMoveSpeed()
        {
            return 500;
        }

        public double GetAttackPower()
        {
            return 5;
        }
    }
}
