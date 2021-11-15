using System.Collections.Generic;
using Idle.Emu.Domain.Entities;
using Idle.Emu.Domain.Enums;
using Idle.Emu.Domain.Records;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Infrastructure;
using Newtonsoft.Json;

namespace Idle.Emu.Domain.ValueObjects
{
    /// <summary>
    /// from attr.lua
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class HeroInfoVo : IValueObject
    {
        // dynamic; excluded from serialization
        private int _level;

        private HeroSkinVo _skin;
        private Dictionary<EHeroEquipPos, EquipEntity> _equip;

        // static; serialized for e.g persistence
        [JsonProperty] private readonly int _maxLevel;
        [JsonProperty] private readonly int _quality; // hero stars

        [JsonProperty] private readonly HeroStatsVoProps _base;
        [JsonProperty] private readonly HeroStatsVoProps _grow;

        public HeroInfoVo(int maxLevel, int quality, HeroStatsVoProps @base, HeroStatsVoProps grow)
        {
            _maxLevel = maxLevel;
            _quality = quality;

            _base = @base;
            _grow = grow;

            _level = 0;
            _skin = null;
            _equip = null;
        }

        #region Set

        public void SetLevelIncrement(int add = 1)
        {
            var max = _maxLevel - _level;
            if (add <= max) _level += add;
            else _level = _maxLevel;
        }

        public void SetSkin(HeroSkinVo skin)
        {
            _skin = skin;
        }

        public void SetEquip(EquipEntity equip)
        {
            // do any equip validation here
            _equip[equip.Pos] = equip;
        }

        #endregion

        #region Get

        public int GetLevel()
        {
            return _level;
        }

        public int GetPower()
        {
            return 100;
        }

        public double GetHealth()
        {
            return (_base.Health + (_level - 1) * _grow.Health) * (1 + _quality + 0.2);
        }

        public double GetAttack()
        {
            // TODO: account for skin + pet + equipment + buffs (from e.g guild and if e.g fire vs forest)
            return (_base.Attack + (_level - 1) * _grow.Attack) * (1 + _quality + 0.2);
        }

        public int GetArmor()
        {
            return (_base.Armor + (_level - 1) * _grow.Attack);
        }

        public double GetSpeed()
        {
            return (_base.Speed + (_level - 1) * _grow.Speed) * (1 + _quality + 0.1);
        }

        #endregion
    }
}