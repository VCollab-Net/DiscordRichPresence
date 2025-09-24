using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DiscordRPC.RPC.Payload
{
	/// <summary>
	/// The payload that is sent by the client to discord for events such as setting the rich presence.
	/// <para>
	/// SetPrecense
	/// </para>
	/// </summary>
	internal class ArgumentPayload : IPayload
	{
		/// <summary>
		/// The data the server sent too us
		/// </summary>
		[JsonPropertyName("args")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public JsonObject Arguments { get; set; }

		public ArgumentPayload() { Arguments = null; }
		public ArgumentPayload(long nonce) : base(nonce) { Arguments = null; }

		/// <summary>
		/// Sets the obejct stored within the data.
		/// </summary>
		/// <param name="obj"></param>
		public void SetObject<TArgument>(TArgument obj)
		{
			Arguments = JsonSerializer.SerializeToNode(
                obj,
                ((JsonTypeInfo<TArgument>) JsonSourceGeneration.Default.GetTypeInfo(obj.GetType()))!
            )!.AsObject();
		}

		/// <summary>
		/// Gets the object stored within the Data
		/// </summary>
		/// <typeparam name="TArgument"></typeparam>
		/// <returns></returns>
		public TArgument GetObject<TArgument>()
		{
			return Arguments.Deserialize(((JsonTypeInfo<TArgument>) JsonSourceGeneration.Default.GetTypeInfo(typeof(TArgument)))!);
		}

		public override string ToString()
		{
			return "Argument " + base.ToString();
		}
	}
}

