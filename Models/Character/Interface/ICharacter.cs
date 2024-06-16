using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transformers_battle_sim.Models.Character.Interface
{
    public interface ICharacter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public int WinCount { get; set; }
        public int LossCount { get; set; }
        public double GetWinRatio();

    }
}
