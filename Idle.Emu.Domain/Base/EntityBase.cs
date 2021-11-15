using Idle.Emu.Shared.Interfaces.Domain;

namespace Idle.Emu.Domain.Base
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; init; }

        protected EntityBase(int id)
        {
            Id = id;
        }
        
        public override bool Equals(object obj)
        {
            return Equals(obj as EntityBase);
        }

        private bool Equals(IEntity obj)
        {
            return obj != null && obj.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}