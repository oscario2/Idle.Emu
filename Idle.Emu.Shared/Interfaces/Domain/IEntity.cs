namespace Idle.Emu.Shared.Interfaces.Domain
{
    /// <summary>
    /// needs to be unique hence id
    /// </summary>
    public interface IEntity
    {
        public int Id { get; init; }
    }
}