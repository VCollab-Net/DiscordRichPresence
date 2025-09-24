using System.Text.Json.Serialization;
using DiscordRPC.RPC.Payload;

namespace DiscordRPC.RPC.Commands
{
    internal class RespondCommand : ICommand
	{
		/// <summary>
		/// The user ID that we are accepting / rejecting
		/// </summary>
		[JsonPropertyName("user_id")]
		public string UserID { get; set; }

		/// <summary>
		/// If true, the user will be allowed to connect.
		/// </summary>
		[JsonIgnore]
		public bool Accept { get; set; }

		public IPayload PreparePayload(long nonce)
		{
			var payload = new ArgumentPayload(nonce)
			{
				Command = Accept ? Command.SendActivityJoinInvite : Command.CloseActivityJoinRequest
			};

            payload.SetObject(this);

            return payload;
        }
	}
}
