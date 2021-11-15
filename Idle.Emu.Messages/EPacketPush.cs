// ReSharper disable IdentifierTypo
namespace Idle.Emu.Messages
{
    /// <summary>
    /// from netClient.lua
    /// </summary>
    public enum EPacketPush
    {
        OnMailData = 5001,
        OnChatData = 7001,
        OnFriendsData = 10041,
        OnFriendsBossData = 23061,
        OnFriendsArenaData = 260101,
        OnGuildData = 13001,
        OnSmsgData = 30181
    }
}