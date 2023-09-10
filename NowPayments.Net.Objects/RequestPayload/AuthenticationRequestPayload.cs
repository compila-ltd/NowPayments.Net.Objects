using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects.RequestPayload
{
	public class AuthenticationRequestPayload
	{
		[JsonPropertyName("email")]
		public string Email { get; set; } = string.Empty;
		[JsonPropertyName("password")]
		public string Password { get; set; } = string.Empty;
	}
}
