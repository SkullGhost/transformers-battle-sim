using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class Robot : Mode
    {
        public Robot()
        {
            ModeName = "Robot";
            MovementType = MovementType.BIPEDAL;
            MovementSpeed = 40;
            AttackPower = 7;
        }

    }
}
