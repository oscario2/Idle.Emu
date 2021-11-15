namespace Idle.Emu.Generator.Records
{
    public record EventMap
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public int Cmd { get; set; }
        public string Module { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }
}