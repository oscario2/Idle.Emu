using System;
using Idle.Emu.Infrastructure.Base;
using Idle.Emu.Shared.Interfaces.Domain.Derived;

namespace Idle.Emu.Infrastructure.Repositories
{
    public class HeroRepository : RepositoryBase<string, IPlayerAggregate>
    {
        private static readonly Lazy<PlayerRepository> Lazy
            = new Lazy<PlayerRepository>(() => new PlayerRepository());

        public static PlayerRepository Instance
            => Lazy.Value;
    }
}