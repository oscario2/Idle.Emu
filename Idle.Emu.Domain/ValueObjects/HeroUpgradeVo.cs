using Idle.Emu.Domain.Records;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Domain.Derived;

namespace Idle.Emu.Domain.ValueObjects
{
    /// <summary>
    /// exphero.lua
    /// </summary>
    public class HeroUpgradeVo : IValueObject
    {
        public bool GetCanAfford(ICommodityVo gold, ICommodityVo spirit)
        {
            // validate that gold and spirit is enough to upgrade
            return true;
        }
    }
}