using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects.RequestPayload
{
	public class EstimatePriceRequestPayload
	{
		[JsonPropertyName("amount")]
		public decimal Amount { get; set; }
		[JsonPropertyName("currency_from")]
		public string CurrencyFrom { get; set; } = string.Empty;
		[JsonPropertyName("currency_to")]
		public string CurrencyTo { get; set; } = string.Empty;
		public string ToQueryString => $"amount={Amount}&currency_from={CurrencyFrom}&currency_to={CurrencyTo}";
	}
}
