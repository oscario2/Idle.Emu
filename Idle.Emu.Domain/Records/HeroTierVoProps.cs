using Idle.Emu.Shared.Interfaces.Domain.Derived;

namespace Idle.Emu.Domain.Records
{
    public record HeroTierVoProps
    {
        public int Level { get; init; }
        public ICommodityVo Gold { get; init; }
        public ICommodityVo Stones { get; init; }
    }
}