using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class AuthToken
	{
		[JsonPropertyName("token")]
		public string? Token { get; set; }
	}
}
