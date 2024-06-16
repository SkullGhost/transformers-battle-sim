using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class Tank : IMode
    {
        public string GetModeName()
        {
            return "Tank";
        }
        public MovementType GetMovementType()
        {
            return MovementType.TREADS;
        }
        public double GetMoveSpeed()
        {
            return 45;
        }

        public double GetAttackPower()
        {
            return 8;
        }
    }
}
