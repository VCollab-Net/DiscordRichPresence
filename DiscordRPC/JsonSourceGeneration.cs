using System.Text.Json.Serialization;
using DiscordRPC.IO;
using DiscordRPC.Message;
using DiscordRPC.RPC.Commands;
using DiscordRPC.RPC.Payload;

namespace DiscordRPC;

/// <inheritdoc cref="JsonSerializerContext" />
[JsonSourceGenerationOptions()]
[JsonSerializable(typeof(IPayload))]
[JsonSerializable(typeof(Command))]
[JsonSerializable(typeof(PresenceCommand))]
[JsonSerializable(typeof(RespondCommand))]
[JsonSerializable(typeof(ArgumentPayload))]
[JsonSerializable(typeof(EventPayload))]
[JsonSerializable(typeof(ClosePayload))]
[JsonSerializable(typeof(ServerEvent))]

[JsonSerializable(typeof(CloseMessage))]
[JsonSerializable(typeof(ConnectionEstablishedMessage))]
[JsonSerializable(typeof(ConnectionFailedMessage))]
[JsonSerializable(typeof(ErrorMessage))]
[JsonSerializable(typeof(JoinMessage))]
[JsonSerializable(typeof(JoinRequestMessage))]
[JsonSerializable(typeof(MessageType))]
[JsonSerializable(typeof(PresenceMessage))]
[JsonSerializable(typeof(ReadyMessage))]
[JsonSerializable(typeof(SpectateMessage))]
[JsonSerializable(typeof(SubscribeMessage))]
[JsonSerializable(typeof(UnsubscribeMessage))]

[JsonSerializable(typeof(ActivityType))]
[JsonSerializable(typeof(Assets))]
[JsonSerializable(typeof(Button))]
[JsonSerializable(typeof(Party))]
[JsonSerializable(typeof(RichPresence))]
[JsonSerializable(typeof(RichPresenceResponse))]
[JsonSerializable(typeof(Secrets))]
[JsonSerializable(typeof(StatusDisplayType))]
[JsonSerializable(typeof(Timestamps))]
[JsonSerializable(typeof(User))]

[JsonSerializable(typeof(Handshake))]
internal partial class JsonSourceGeneration : JsonSerializerContext
{

}