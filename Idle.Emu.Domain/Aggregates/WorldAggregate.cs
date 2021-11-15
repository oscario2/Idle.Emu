using System.Collections.Generic;
using Idle.Emu.Domain.ValueObjects;
using Idle.Emu.Shared.Interfaces.Domain;

namespace Idle.Emu.Domain.Aggregates
{
    public sealed class WorldAggregate : IAggregateRoot
    {
        public int Id { get; }
        
        public Dictionary<IdVo, PlayerAggregate> Players { get; }

    }
}