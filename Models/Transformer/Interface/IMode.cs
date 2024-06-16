using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transformers_battle_sim.Models.Transformer.Interface
{
    //Type of movement could be relevant to battle sim (What type of terrain can this transformer navigate? How fast can they travel?)
    public enum MovementType
    {
        BIPEDAL,
        QUADRUPEDAL,
        WHEELS,
        TREADS,
        FLYING,
        HOVER
    }
    public interface IMode
    {
        public Guid Id { get; set; }
        public string ModeName { get; set; }
        public MovementType MovementType { get; set; }
        public double MovementSpeed { get; set; }
        //Future improvement would have each mode having an array of attacks/weapons available to this mode
        //Having attack be a flat number for now
        public double AttackPower { get; set; }
    }
}
