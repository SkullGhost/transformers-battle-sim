using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Interface;

namespace transformers_battle_sim.Models.Transformer.Impl
{
    public class Transformer : ITransformer
    {
        //Transformer specific stuff
        public void Transform(string newMode)
        {
            //Change mode if this transformer is capable
            foreach(IMode thisMode in m_modes)
            {
                if(thisMode.GetModeName() == newMode)
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
        public string GetName()
        {
            return m_name;
        }
        public void SetName(string newName)
        {
            m_name = newName;
        }
        public string GetFaction()
        {
            return m_faction;
        }
        public void SetFaction(string newFaction)
        {
            m_faction = newFaction;
        }
        public int GetWins()
        {
            return m_win_count;
        }
        public void SetWins(int newWins)
        {
            m_win_count = newWins;
        }
        public int GetLosses()
        {
            return m_loss_count;
        }
        public void SetLosses(int newLosses)
        {
            m_loss_count = newLosses;
        }
        public double GetWinRatio()
        {
            int total_matches = m_win_count + m_loss_count;

            if (total_matches != 0)
            {
                return m_win_count / total_matches;
            }

            return 0; //If total matches is zero
        }

        private List<IMode> m_modes;
        IMode m_current_mode;

        private string m_name;
        private string m_faction;
        private int m_win_count;
        private int m_loss_count;
    }
}
