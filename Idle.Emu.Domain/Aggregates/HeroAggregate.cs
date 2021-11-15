using Idle.Emu.Domain.Entities;
using Idle.Emu.Domain.Records;
using Idle.Emu.Domain.ValueObjects;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Domain.Derived;
using Newtonsoft.Json;

namespace Idle.Emu.Domain.Aggregates
{
    /// <summary>
    /// persistence will have all the base stats
    /// our aggregate is dynamically constructed depending on equipment 
    /// </summary>
    public class HeroAggregate : IHeroAggregate
    {
        public int Id { get; }
        
        // owner of this hero instance, injected IPlayerAggregate from "application" layer which queries the repository
        private readonly IPlayerAggregate _player;

        // id for video
        private readonly int _attackId;

        // branches
        private readonly HeroInfoVo _info;
        private readonly HeroStarVo _star;
        private readonly HeroUpgradeVo _upgrade;
        
        private HeroAggregate(int attackId, HeroInfoVo info)
        {
            _attackId = attackId;

            _info = info;
            _star = null;
            _upgrade = null;
        }

        /// <summary>
        /// return status code
        /// </summary>
        /// <param name="up"></param>
        public void SetLevelIncrement(int up = 1)
        {
            // can player afford to upgrade hero
            if (!_upgrade.GetCanAfford(_player.GetGold(), _player.GetSpirit())) return;

            // hero level capped, must add another star first
            if (_star.GetNeedStar(_info.GetLevel())) return;

            // increment
            _info.SetLevelIncrement(up);
        }

        public void SetStarIncrement()
        {
            var level = _info.GetLevel();
            
            //
            if (!_star.GetNeedStar(level)) return;
            
            //
            if (!_star.GetCanAfford(level, _player.GetGold(), _player.GetStones())) return;
            
            //
            _star.SetIncrementStar(level);
        }

        /// <summary>
        /// forward to "_info" which does all validation
        /// </summary>
        /// <param name="equip"></param>
        public void SetEquip(EquipEntity equip)
        {
            _info.SetEquip(equip);
        }


        /// <summary>
        /// application will query repository for a saved
        /// </summary>
        /// <returns></returns>
        public static HeroAggregate Create(int attackId, HeroInfoVo info)
        {
            // TODO: verify 'info' properties
            return new HeroAggregate(attackId, info);
        }
        
    }
}