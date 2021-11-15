using Idle.Emu.Domain.Base;
using Idle.Emu.Domain.Enums;
using Idle.Emu.Domain.Records;
using Idle.Emu.Domain.ValueObjects;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Infrastructure;

namespace Idle.Emu.Domain.Entities
{
    public class HeroEntity : EntityBase
    {
        private readonly EHeroJob _job;
        private readonly EHeroGroup _group;
        
        public int AttackId { get; } // for video frame

        private readonly HeroInfoVo _info;
        private readonly HeroStarVo _star;

        private HeroEntity(int id) : base(id)
        {
            
        }
        
        public void AddLevel(int up = 1)
        {
            if (_star.GetNeedStar(_info.GetLevel())) 
                return;
            
            _info.SetLevelIncrement(up);
        }
        
        // equipvo
        public void AddEquip()
        {
            
        }
        
        public static HeroEntity Create(int id, EHeroJob job, int quality, int maxStar, int tier)
        {
            return new HeroEntity(0);
        }
    }
}