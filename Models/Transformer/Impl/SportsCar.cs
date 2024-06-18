using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class SportsCar : Mode
    {
        public SportsCar()
        {
            ModeName = "Sports Car";
            MovementType = MovementType.WHEELS;
            MovementSpeed = 120;
            AttackPower = 4;
        }
    }
}
