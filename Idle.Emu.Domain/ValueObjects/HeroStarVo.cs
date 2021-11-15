using System.Collections.Generic;
using System.Linq;
using Idle.Emu.Domain.Records;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Domain.Derived;
using Newtonsoft.Json;

namespace Idle.Emu.Domain.ValueObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HeroStarVo : IValueObject
    {
        // dynamic; excluded from serialization
        private int _current;
        private List<int> _stars;
        
        // static; serialized for e.g persistence
        [JsonProperty] private int _maxStar; // max hero stars (using creation circle)
        [JsonProperty] private readonly Dictionary<int, HeroTierVoProps> _prices;
        

        private HeroStarVo(IEnumerable<HeroTierVoProps> props)
        {
            _current = 0;
            _maxStar = 0;

            _prices = props.ToDictionary(k => k.Level, v => v);
            _stars = _prices.Keys.ToList();
        }

        #region Set
        public void SetIncrementStar(int level)
        {
            _current = _stars.IndexOf(level) + 1;
        }

        #endregion

        #region Get
        public int GetCurrentStar()
        {
            return _current;
        }

        /// <summary>
        /// hero must evolve before leveling any further
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public bool GetNeedStar(int level)
        {
            return _prices.ContainsKey(level);
        }

        public bool GetCanAfford(int level, ICommodityVo gold, ICommodityVo stones)
        {
            if (!GetNeedStar(level)) return false;

            return
                gold.Amount == _prices[level].Gold.Amount &&
                stones.Amount == _prices[level].Stones.Amount;
        }
        #endregion
        
        public static HeroStarVo Create(IEnumerable<HeroTierVoProps> props)
        {
            return new HeroStarVo(props);
        }
    }
}