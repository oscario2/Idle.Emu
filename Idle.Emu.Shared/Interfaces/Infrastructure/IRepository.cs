using System;
using System.Collections.Generic;
using Idle.Emu.Shared.Interfaces.Domain;

namespace Idle.Emu.Shared.Interfaces.Infrastructure
{
    public interface IRepository<T, TR>
        where T : IConvertible
        where TR : IAggregate
    {
        IEnumerable<T> GetKeys();
        
        bool Has(T key);

        TR Get(T key);

        bool Set(T key, TR item);

    }
}