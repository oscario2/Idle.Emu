using System;
using System.Collections.Generic;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Infrastructure;

namespace Idle.Emu.Infrastructure.Base
{
    public abstract class RepositoryBase<T, TR> : IRepository<T, TR>
        where T : IConvertible
        where TR : IAggregate
    {
        private readonly Dictionary<T, TR> _units = new Dictionary<T, TR>();

        public virtual IEnumerable<T> GetKeys()
        {
            return _units.Keys;
        }

        public virtual bool Has(T key)
        {
            return _units.ContainsKey(key);
        }

        public virtual TR Get(T key)
        {
            return !_units.ContainsKey(key) ? default : _units[key];
        }

        public virtual bool Set(T key, TR item)
        {
            return _units.TryAdd(key, item);
        }
    }
}