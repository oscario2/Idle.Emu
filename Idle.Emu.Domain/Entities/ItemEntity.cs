using Idle.Emu.Domain.Base;
using Idle.Emu.Shared.Interfaces.Domain;

namespace Idle.Emu.Domain.Entities
{
    /// <summary>
    /// has unique id
    /// </summary>
    public sealed class ItemEntity : EntityBase
    {
        public string Name { get; }
        public string Brief { get; }
        public string Explain { get; }

        private ItemEntity(int id, string name, string brief, string explain) : base(id)
        {
            Name = name;
            Brief = brief;
            Explain = explain;
        }

        // from persistence
        private ItemEntity(int id) : base(id)
        {
            
        }

        public static ItemEntity Create(int id)
        {
            // TODO: "application layer" get item info/stats from repository
            // TODO: ^ map from persistence to entity if exists
            return new ItemEntity(id);
        }
    }
}