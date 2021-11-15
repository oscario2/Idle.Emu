using Idle.Emu.Shared.Interfaces.Domain.Derived;

namespace Idle.Emu.Domain.ValueObjects
{
    public class GoldVo : ICommodityVo
    {
        public int Amount { get; }

        public GoldVo(int amount)
        {
            Amount = amount;
        }
    }
}