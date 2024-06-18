using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Models.Transformer.Impl;
using transformers_battle_sim.Data.Impl;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace transformers_battle_sim.Models
{
    public static class TestData
    {
        
        public static void Initialize(TransformerRepository repo)
        {
            var existingTfList = repo.GetCharacterList();
            //Populate test data if there are no transformers in the DB
            if(existingTfList.Count == 0)
            {
                string AUTOBOT = "Autobot";
                string DECEPTICON = "Decepticon";

                Transformer.Impl.Transformer starscream = new Transformer.Impl.Transformer();
                starscream.Name = "Starscream";
                starscream.Faction = DECEPTICON;
                starscream.Modes.Add(new Robot());
                starscream.Modes.Add(new FighterJet());

                repo.AddCharacter(starscream);

                Transformer.Impl.Transformer sideswipe = new Transformer.Impl.Transformer();
                sideswipe.Name = "Sideswipe";
                sideswipe.Faction = AUTOBOT;
                sideswipe.Modes.Add(new Robot());
                sideswipe.Modes.Add(new SportsCar());

                repo.AddCharacter(sideswipe);

                Transformer.Impl.Transformer megatron = new Transformer.Impl.Transformer();
                megatron.Name = "Megatron";
                megatron.Faction = DECEPTICON;
                megatron.Modes.Add(new Robot());
                megatron.Modes.Add(new Tank());

                repo.AddCharacter(megatron);

                Transformer.Impl.Transformer blitzwing = new Transformer.Impl.Transformer();
                blitzwing.Name = "Blitzwing";
                blitzwing.Faction = DECEPTICON;
                blitzwing.Modes.Add(new Robot());
                blitzwing.Modes.Add(new FighterJet());
                blitzwing.Modes.Add(new Tank());

                repo.AddCharacter(blitzwing);
            }
        }
    }
}
