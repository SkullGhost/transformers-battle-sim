using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transformers_battle_sim.Models.Character.Interface
{
    public interface ICharacter
    {
        string GetName();
        void SetName(string newName);
        string GetFaction();
        void SetFaction(string newFaction);
        int GetWins();
        void SetWins(int newWins);
        int GetLosses();
        void SetLosses(int newLosses);
        double GetWinRatio();

    }
}
