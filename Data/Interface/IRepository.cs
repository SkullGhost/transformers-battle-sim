using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Character.Interface;

namespace transformers_battle_sim.Data.Interface
{
    public interface IRepository
    {
        public void AddCharacter(ICharacter newCharacter);

        public void RemoveCharacter(ICharacter deletedCharacter);

        public ICharacter RetrieveCharacter(Guid Id);

        public List<ICharacter> GetCharacterList();

        public void RecordBattle(List<ICharacter> winners, List<ICharacter> losers);
    }
}
