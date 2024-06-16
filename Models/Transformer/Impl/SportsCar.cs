using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class SportsCar : IMode
    {
        public string GetModeName()
        {
            return "Sports Car";
        }
        public MovementType GetMovementType()
        {
            return MovementType.WHEELS;
        }
        public double GetMoveSpeed()
        {
            return 120; 
        }

        public double GetAttackPower()
        {
            return 4;
        }
    }
}
