using Idle.Emu.Domain.Enums;
using Idle.Emu.Shared.Interfaces.Domain;

namespace Idle.Emu.Domain.Entities
{
    public class EquipEntity : IEntity
    {
        public int Id { get; init; }
        
        public EHeroEquipPos Pos { get; }
    }
}