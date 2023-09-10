using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects.RequestPayload
{
	internal class AuthenticationRequestPayload
	{
		[JsonPropertyName("email")]
		public string Email { get; set; } = string.Empty;
		[JsonPropertyName("password")]
		public string Password { get; set; } = string.Empty;
	}
}
