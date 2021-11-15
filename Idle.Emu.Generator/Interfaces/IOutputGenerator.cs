using System.Collections.Generic;
using Idle.Emu.Generator.Records;

namespace Idle.Emu.Generator.Interfaces
{
    internal interface IOutputGenerator
    {
        /// <summary>
        /// file extension e.g "cs" for ".cs"
        /// </summary>
        string Extension { get; }

        /// <summary>
        /// namespace to be featured in .proto file
        /// </summary>
        string GetProtoNamespace(string nms);

        /// <summary>
        /// generate enum for each event id
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        IEnumerable<string> ToEnum(IEnumerable<EventMap> events);

        /// <summary>
        /// generate code of desired language
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        string ToCode(List<EventMap> events);
    }
}