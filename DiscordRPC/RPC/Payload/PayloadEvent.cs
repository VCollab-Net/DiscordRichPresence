using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DiscordRPC.RPC.Payload
{
	/// <summary>
	/// Used for Discord IPC Events
	/// </summary>
	internal class EventPayload : IPayload
	{
		/// <summary>
		/// The data the server sent too us
		/// </summary>
		[JsonPropertyName("data")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public JsonObject Data { get; set; }

		/// <summary>
		/// The type of event the server sent
		/// </summary>
		[JsonPropertyName("evt")]
		public ServerEvent? Event { get; set; }

        /// <summary>
        /// Creates a payload with empty data
        /// </summary>
		public EventPayload() : base() { Data = null; }

        /// <summary>
        /// Creates a payload with empty data and a set nonce
        /// </summary>
        /// <param name="nonce"></param>
		public EventPayload(long nonce) : base(nonce) { Data = null; }

		/// <summary>
		/// Gets the object stored within the Data
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public T GetObject<T>()
		{
			if (Data == null) return default;
            return Data.Deserialize(((JsonTypeInfo<T>) JsonSourceGeneration.Default.GetTypeInfo(typeof(T)))!);
		}

        /// <summary>
        /// Converts the object into a human readable string
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return "Event " + base.ToString() + ", Event: " + (Event.HasValue ? Event.ToString() : "N/A");
		}
	}


}
