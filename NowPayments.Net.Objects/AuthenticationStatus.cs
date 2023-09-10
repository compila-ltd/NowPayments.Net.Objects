using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class AuthenticationStatus
	{
		[JsonPropertyName("isAuthenticated")]
		public bool IsAuthenticated { get; set; }
		[JsonPropertyName("message")]
		public string? Message { get; set; }
	}
}
