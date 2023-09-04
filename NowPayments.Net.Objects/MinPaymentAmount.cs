using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class MinPaymentAmount
	{
		[JsonPropertyName("currency_from")]
		public string? CurrencyFrom { get; set; }
		[JsonPropertyName("currency_to")]
		public string? CurrencyTo { get; set; }
		[JsonPropertyName("min_amount")]
		public decimal MinAmount { get; set; }
	}
}
