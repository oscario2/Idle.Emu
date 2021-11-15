using System.Collections.Generic;
using Idle.Emu.Domain.ValueObjects;

namespace Idle.Emu.Domain.Entities
{
    /// <summary>
    /// can be owned by player or reward
    /// </summary>
    public sealed class BagEntity
    {
        public Dictionary<int, ItemEntity> Items { get; }

        private BagEntity()
        {
            Items = new Dictionary<int, ItemEntity>();
        }

        public void AddItem()
        {
            
        }

        public void RemoveItem()
        {
            
        }

        public static BagEntity Create()
        {
            return new BagEntity();
        }
            
    }
}