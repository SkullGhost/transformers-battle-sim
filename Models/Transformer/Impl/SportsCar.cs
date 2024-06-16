using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class SportsCar : IMode
    {
        public SportsCar()
        {
            ModeName = "Sports Car";
            MovementType = MovementType.WHEELS;
            MovementSpeed = 120;
            AttackPower = 4;
        }
        public Guid Id { get; set; }
        public string ModeName { get; set; }
        public MovementType MovementType { get; set; }
        public double MovementSpeed { get; set; }
        public double AttackPower { get; set; }
    }
}
