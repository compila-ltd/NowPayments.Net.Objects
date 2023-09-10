using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class AuthToken
	{
		[JsonPropertyName("token")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? Token { get; set; }
		[JsonPropertyName("status")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool? Status { get; set; }
		[JsonPropertyName("statusCode")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public int? StatusCode { get; set; }
		[JsonPropertyName("code")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? Code { get; set; }
		[JsonPropertyName("message")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? Message { get; set; }
	}
}
