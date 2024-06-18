using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class Transformer : ITransformer
    {
       public Transformer()
        {
            Modes = new List<Mode>();
        }

        //Transformer specific stuff
        public void Transform(string newMode)
        {
            //Change mode if this transformer is capable
            foreach(Mode thisMode in Modes)
            {
                if(thisMode.ModeName == newMode)
                {
                    m_current_mode = thisMode;
                }
            }
        }

        public IMode GetCurrentMode()
        {
            return m_current_mode;
        }

        //Generic character stuff
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public int WinCount { get; set; }
        public int LossCount { get; set; }
        public double GetWinRatio()
        {
            int total_matches = WinCount + LossCount;

            if (total_matches != 0)
            {
                return WinCount / total_matches;
            }

            return 0; //If total matches is zero
        }

        public List<Mode> Modes { get; set; }
        Mode m_current_mode;

    }
}
