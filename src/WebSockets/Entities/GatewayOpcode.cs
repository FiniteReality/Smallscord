namespace Smallscord.WebSockets.Entities
{
	public enum GatewayOpcode
	{
		Dispatch = 0,
		Heartbeat = 1,
		Identify = 2,
		StatusUpdate = 3,
		VoiceStateUpdate=4,
		VoiceServerPing = 5,
		Resume = 6,
		Reconnect = 7,
		RequestGuildMembers = 8,
		InvalidSession = 9,
		Hello = 10,
		HeartbeatAck = 11
	}
}