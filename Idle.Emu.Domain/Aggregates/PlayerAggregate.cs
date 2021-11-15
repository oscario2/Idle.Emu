using System.Collections.Generic;
using Idle.Emu.Domain.Entities;
using Idle.Emu.Domain.ValueObjects;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Domain.Derived;

namespace Idle.Emu.Domain.Aggregates
{
    public sealed class PlayerAggregate : IPlayerAggregate
    {
        public int Id { get; }
        
        // dictionary of HeroEntity, GuildAggregate, MailEntity
        public BagEntity Bag { get; }

        private PlayerAggregate(int id)
        {
            Id = id;
        }
        
        public ICommodityVo GetGold()
        {
            throw new System.NotImplementedException();
        }

        public ICommodityVo GetSpirit()
        {
            throw new System.NotImplementedException();
        }

        public ICommodityVo GetStones()
        {
            throw new System.NotImplementedException();
        }


        // "application" layer queries repository for a PlayerPersistence by ID
        // if player exists in repo, "application" will just map it to "entity"
        // this "create" gets called if no hero is found in the repository
        public PlayerAggregate Create(int id)
        {
            return new PlayerAggregate(id);
        }

    }
}