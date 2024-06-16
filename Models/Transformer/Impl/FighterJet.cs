﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class FighterJet : IMode
    {
        public FighterJet()
        {
            ModeName = "Fighter Jet";
            MovementType = MovementType.FLYING;
            MovementSpeed = 500;
            AttackPower = 5;
        }
        public Guid Id { get; set; }
        public string ModeName { get; set; }
        public MovementType MovementType { get; set; }
        public double MovementSpeed { get; set; }
        public double AttackPower { get; set; }
    }
}
