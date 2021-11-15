using System.Collections.Generic;
using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Login.Protos;
using Newtonsoft.Json;

namespace Idle.Emu.Application.Events.Auth
{
    /// <summary>
    /// announcements and updates on start
    /// </summary>
    public class PubEvent
        : EventCommandBase<PubEvent>, IEventService<IdleReqPub, IdleRspPub>
    {
        #region Records

        private record PubUpdatesEntryMessage
        {
            [JsonProperty("title")] public string Title { get; set; }

            [JsonProperty("content")] public List<string> Content { get; set; }
        }

        private record PubUpdatesEntry
        {
            [JsonProperty("title")] public string Title { get; set; }

            [JsonProperty("sub")] public List<PubUpdatesEntryMessage> Sub { get; set; }
        }
        
        private record PubUpdates
        {
            [JsonProperty("pub")] public List<PubUpdatesEntry> Pub { get; set; }
        }

        #endregion

        public IdleRspPub Response(IdleReqPub req)
        {
            var pub = new PubUpdates()
            {
                Pub = new List<PubUpdatesEntry>()
                {
                    new PubUpdatesEntry()
                    {
                        Title = "Welcome to the emulator",
                        Sub = new List<PubUpdatesEntryMessage>()
                        {
                            new PubUpdatesEntryMessage()
                            {
                                Title = "1. Here's all your announcements",
                                Content = new List<string>()
                                {
                                    "Works with the latest version"
                                }
                            }
                        }
                    }
                }
            };

            return new IdleRspPub()
            {
                Status = 0, Language = 0, Vsn = 179, Pub = JsonConvert.SerializeObject(pub)
            };
        }
    }
}