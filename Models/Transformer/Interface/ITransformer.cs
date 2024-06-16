using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Character.Interface;

namespace transformers_battle_sim.Models.Transformer.Interface
{
    public interface ITransformer : ICharacter
    {
        void Transform(string mode);

        IMode GetCurrentMode();

    }
}
