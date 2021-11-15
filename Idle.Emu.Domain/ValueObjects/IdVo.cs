using Idle.Emu.Shared.Interfaces.Domain;

namespace Idle.Emu.Domain.ValueObjects
{
    /// <summary>
    /// general id object for heroes, items and equips
    /// </summary>
    public class IdVo : IValueObject
    {
        public int Id { get; }

        private IdVo()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IdVo);
        }

        private bool Equals(IdVo obj)
        {
            return obj != null && obj.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static IdVo Create(int id)
        {
            return new IdVo();
        }
    }
}