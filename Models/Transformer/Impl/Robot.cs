using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class Robot : IMode
    {
        public string GetModeName()
        {
            return "Robot";
        }
        public MovementType GetMovementType()
        {
            return MovementType.BIPEDAL;
        }
        public double GetMoveSpeed()
        {
            return 40;
        }

        public double GetAttackPower()
        {
            return 7;
        }
    }
}
