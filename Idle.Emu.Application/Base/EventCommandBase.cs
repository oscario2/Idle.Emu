using System;

namespace Idle.Emu.Application.Base
{
    public abstract class EventCommandBase<T>
        where T :  new()
    {
        private static readonly Lazy<T> Lazy
            = new Lazy<T>(() => new T());

        public static T Instance
            => Lazy.Value;
    }
}