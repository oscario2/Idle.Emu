namespace Idle.Emu.Shared.Interfaces.Domain.Derived
{
    public interface IPlayerAggregate : IAggregate
    {
        public ICommodityVo GetGold();
        public ICommodityVo GetSpirit();
        public ICommodityVo GetStones();
    }
}