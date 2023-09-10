using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class EstimatedPrice
	{
		[JsonPropertyName("currency_from")]
		public string? CurrencyFrom { get; set; }
		[JsonPropertyName("currency_to")]
		public string? CurrencyTo { get; set; }
		[JsonPropertyName("amount_from")]
		public decimal AmountFrom { get; set; }
		[JsonPropertyName("estimated_amount")]
		public decimal EstimatedAmount { get; set; }
	}
}
