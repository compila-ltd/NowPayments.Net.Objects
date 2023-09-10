using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects.RequestPayload
{
	public class PaymentRequestPayload
	{
		[JsonPropertyName("price_amount")]
		public decimal PriceAmount { get; set; }
		[JsonPropertyName("price_currency")]
		public string PriceCurrency { get; set; } = "usd";
		[JsonPropertyName("pay_amount")]
		public decimal PayAmount { get; set; }
		[JsonPropertyName("pay_currency")]
		public string PayCurrency { get; set; } = "btc";
		[JsonPropertyName("ipn_callback_url")]
		public string? IPNCallbackUrl { get; set; }
		[JsonPropertyName("order_id")]
		public string? OrderId { get; set; }
		[JsonPropertyName("order_description")]
		public string? OrderDescription { get; set; }
		[JsonPropertyName("purchase_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public long PurchaseId { get; set; } = 0;
		[JsonPropertyName("payout_address")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? PayoutAddress { get; set; }
		[JsonPropertyName("payout_currency")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? PayoutCurrency { get; set; }
		[JsonPropertyName("payout_extra_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? PayoutExtraId { get; set; }
		[JsonPropertyName("is_fixed_rate")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public bool IsFixedRate { get; set; } = false;
		[JsonPropertyName("is_fee_paid_by_user")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public bool IsFeePaidByUser { get; set; } = false;
	}

	public class PaymentRequestPayload_Sandbox : PaymentRequestPayload
	{
		[JsonPropertyName("case")]
		public string? Case { get; set; }
	}
}
