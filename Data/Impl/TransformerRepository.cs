using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transformers_battle_sim.Data.Interface;
using transformers_battle_sim.Models.Character.Interface;
using transformers_battle_sim.Models.Transformer.Impl;
using Microsoft.EntityFrameworkCore;

namespace transformers_battle_sim.Data.Impl
{
    //Inherits from IRepository interface but also from DbContext to interact with SQL
    public class TransformerRepository: DbContext, IRepository
    {

        public TransformerRepository(DbContextOptions<TransformerRepository> options)
            : base(options)
        {
        }

        private DbSet<Transformer> Transformer { get; set; }
        private DbSet<Mode> Mode { get; set; }

        public void AddCharacter(ICharacter newCharacter)
        {
            Transformer.Add((Transformer)newCharacter);
            this.SaveChanges();
        }

        public void RemoveCharacter(ICharacter deletedCharacter)
        {
            Transformer.Remove((Transformer)deletedCharacter);
            this.SaveChanges();
        }

       public  ICharacter RetrieveCharacter(Guid Id)
       {
            var transformer = Transformer.Find(Id);

            return transformer;
       }

        public List<ICharacter> GetCharacterList()
        {
            var transformerList = Transformer.ToList();
            List<ICharacter> newList = new List<ICharacter>();
            //Add them to generic list
            foreach(Transformer tf in transformerList)
            {
                newList.Add(tf);
            }
            return newList;
        }
        public void RecordBattle(List<ICharacter> winners, List<ICharacter> losers)
        {
            //TODO

            //Fetch all the winners from the DB and increment their win count
            //foreach(Transformer tf in winners)
            //{
            //    fetch from DB and update count
            //}

            //Fetch all the losers from the DB and increment their loss count

            //this.SaveChanges();
        }
    }
}
