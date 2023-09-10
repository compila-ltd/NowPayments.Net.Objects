using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class Payment
	{
		[JsonPropertyName("payment_id")]
		public long PaymentId { get; set; }
		[JsonPropertyName("invoice_id")]
		public string? InvoiceId { get; set; }
		[JsonPropertyName("payin_extra_id")]
		public string? PayInExtraId { get; set; }
		[JsonPropertyName("order_id")]
		public string? OrderId { get; set; }
		[JsonPropertyName("order_description")]
		public string? OrderDescription { get; set; }
		[JsonPropertyName("payout_hash")]
		public string? PayoutHash { get; set; }
		[JsonPropertyName("payin_hash")]
		public string? PayInHash { get; set; }
		[JsonPropertyName("burning_percent")]
		public string? BurningPercent { get; set; }
		[JsonPropertyName("type")]
		public string? Type { get; set; }
		[JsonPropertyName("payment_extra_ids")]
		public List<long>? PaymentExtraIds { get; set; }
		[JsonPropertyName("payment_status")]
		public string? PaymentStatus { get; set; }
		[JsonPropertyName("pay_address")]
		public string? PayAddress { get; set; }
		[JsonPropertyName("price_amount")]
		public decimal PriceAmount { get; set; }
		[JsonPropertyName("price_currency")]
		public string? PriceCurrency { get; set; }
		[JsonPropertyName("pay_amount")]
		public decimal PayAmount { get; set; }
		[JsonPropertyName("actually_paid")]
		public decimal ActuallyPaid { get; set; }
		[JsonPropertyName("pay_currency")]
		public string? PayCurrency { get; set; }
		[JsonPropertyName("created_at")]
		public DateTime CreatedAt { get; set; }
		[JsonPropertyName("updated_at")]
		public DateTime UpdatedAt { get; set; }
		[JsonPropertyName("purchase_id")]
		public long PurchaseId { get; set; }
		[JsonPropertyName("outcome_currency")]
		public string? OutcomeCurrency { get; set; }
		[JsonPropertyName("outcome_amount")]
		public decimal OutcomeAmount { get; set; }
	}
}
