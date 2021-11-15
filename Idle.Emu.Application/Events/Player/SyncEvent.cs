using System.Collections.Generic;
using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Player
{
    public class SyncEvent
        : EventCommandBase<SyncEvent>, IEventService<IdleReqSync, IdleRspSync>
    {
        public IdleRspSync Response(IdleReqSync req)
        {
            return new IdleRspSync()
            {
                Status = 0,
                Player = new IdlePlayer()
                {
                    Name = "Name",
                    Logo = 29
                },
                Bag = new IdleBag()
                {
                    Items =
                    {
                        new IdleItem()
                        {
                            Id = 40024,
                            Num = 30
                        }
                    },
                    Equips =
                    {
                        new IdleEquip()
                        {
                            Id = 31002,
                            Num = 1
                        }
                    },
                },
                Heroes =
                {
                    new IdleHero()
                    {
                        Hid = 1,
                        Id = 2304,
                        Lv = 1,
                        Star = 0,
                        Visit = false
                    }
                },
                Gacha = new IdleGacha()
                {
                    Item = 27546,
                    Gem = 131561
                },
                HeroIds =
                {
                    new List<int>()
                    {
                        2304
                    }
                },
                Mails =
                {
                    new IdleMail()
                    {
                        Mid = 2,
                        Id = 436,
                        Flag = 2,
                        SendTime = 1634468756,
                        Affix = new IdleBag()
                        {
                            Items =
                            {
                                new IdleItem()
                                {
                                    Id = 734,
                                    Num = 100
                                }
                            }
                        }
                    }
                },
                MidasCd = 0,
                Hook = new IdleHook()
                {
                    Status = 0,
                    HookStage = 5,
                    BossCd = 0,
                    PokerCd = 559,
                    Reward = new IdleBag()
                    {
                        Items =
                        {
                            new IdleItem()
                            {
                                Id = 10,
                                Num = 1136
                            }
                        }
                    },
                    PveStage = 6,
                    Extra = new IdleBag()
                    {
                        Items =
                        {
                            new IdleItem()
                            {
                                Id = 734,
                                Num = 1
                            }
                        }
                    },
                },
                PayNum = {new List<int>() {0}},
                Tutorial = 0,
                Friends = new IdleFriend()
                {
                    Love = 0,
                    Cd = 45161
                },
                Trial = new IdleStrial()
                {
                    Id = 1,
                    Tl = 10,
                    Cd = 1799
                },
                Alogin = new IdleAlogin()
                {
                    Flag = "11",
                    Cd = 45161,
                    Idx = 1,
                    Num = 0,
                    Cd2 = 0
                },
                Acts =
                {
                    new IdleAct()
                    {
                        Id = 1, Status = 0, Cd = 100000000
                    },
                    new IdleAct()
                    {
                        Id = 6293, Cd = 304361
                    }
                },
                Achieve = new IdleSachieve()
                {
                    Num =
                    {
                        new List<int>()
                        {
                            6,
                            0,
                            0,
                            1,
                            0,
                            1,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            2,
                            0,
                            0,
                            0,
                            0,
                            1,
                            0,
                            0,
                            0,
                            0
                        },
                    },
                    Curnum = {new List<int>() {0}}
                },
                Tasks =
                {
                    new IdleTask()
                    {
                        Id = 99,
                        Count = 5,
                        IsClaim = 0
                    }
                },
                TaskCd = 45161,
                Online = new IdleOnline()
                {
                    Id = 2,
                    Cd = 0
                },
                MidasFlag = 0,
                Limitacts =
                {
                    new IdleAct()
                    {
                        Id = 42,
                        Status = 0,
                        Cd = 13260,
                        Limits = 2,
                        Next = 171660
                    }
                },
                SpaceGacha = 1,
                Cds =
                {
                    new IdleCd()
                    {
                        Id = 0,
                        Cd = 0
                    }
                },
                FinalRank = 1,
                Tutorial2 = 7339007,
                Reddot = 1024,
                Subscribed = 0,
                Gsklcode = 0,
                Mact = new IdleMact()
                {
                    Cd = 2590717,
                    SpaceSt = 1,
                    Brave =
                    {
                        new IdleItem()
                        {
                            Id = 24,
                            Num = 0
                        }
                    },
                    Status = 1
                },
                Audit = 0,
                Sact = new IdleSact() { },
                OffCard = 0,
                UseHitem = 0,
                ReSync = new IdleReSync()
                {
                    Role = 3,
                    BindTimes = 3,
                    HelpTimes = 3
                },
                NewMidas =
                {
                    new IdleMidas()
                    {
                        Type = 3,
                        Cd = 45161,
                        Index = 0
                    },
                    new IdleMidas()
                    {
                        Type = 1,
                        Cd = 45161,
                        Index = 0
                    }
                },
                Stele = new IdleStele()
                {
                    Hook = 5,
                    Solo = 0,
                    Crush = 0,
                    Tower = 0,
                    Sealland =
                    {
                        new List<int>()
                        {
                            0, 0
                        }
                    },
                    St = 0
                },
                Token = "N+62719Pk3oEZ0JMoeC5PYOo09Y9vLj96p7WEA=="
            };
        }
    }
}