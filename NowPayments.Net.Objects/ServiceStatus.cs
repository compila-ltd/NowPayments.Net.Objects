using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class ServiceStatus
	{
		[JsonPropertyName("message")]
		public string Message { get; set; } = "OK";
	}
}
