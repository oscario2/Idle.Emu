namespace Idle.Emu.Domain.Records
{
    public record HeroStatsVoProps
    {
        public int Health { get; init; }
        public int Attack { get; init; }
        public int Armor { get; init; }
        public int Speed { get; init; }
    }
}