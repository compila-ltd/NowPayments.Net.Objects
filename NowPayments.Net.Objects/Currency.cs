using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class Currency
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }
		[JsonPropertyName("code")]
		public string? Code { get; set; }
		[JsonPropertyName("name")]
		public string? Name { get; set; }
		[JsonPropertyName("enable")]
		public bool Enable { get; set; }
		[JsonPropertyName("wallet_regex")]
		public string? WalletRegex { get; set; }
		[JsonPropertyName("priority")]
		public int Priority { get; set; }
		[JsonPropertyName("extra_id_exists")]
		public bool ExtraIdExists { get; set; }
		[JsonPropertyName("extra_id_regex")]
		public string? ExtraIdRegex { get; set; }
		[JsonPropertyName("logo_url")]
		public string? LogoUrl { get; set; }
		[JsonPropertyName("track")]
		public bool Track { get; set; }
		[JsonPropertyName("cg_id")]
		public string? CgId { get; set; }
		[JsonPropertyName("is_maxlimit")]
		public bool IsMaxlimit { get; set; }
		[JsonPropertyName("network")]
		public string? Network { get; set; }
		[JsonPropertyName("smart_contract")]
		public string? SmartContract { get; set; }
		[JsonPropertyName("network_precision")]
		public string? NetworkPrecision { get; set; }
		[JsonPropertyName("explorer_link_hash")]
		public string? ExplorerLinkHash { get; set; }
		[JsonPropertyName("precision")]
		public int Precision { get; set; }
		[JsonPropertyName("ticker")]
		public string? Ticker { get; set; }
		[JsonPropertyName("is_defi")]
		public bool IsDefi { get; set; }
		[JsonPropertyName("is_popular")]
		public bool IsPopular { get; set; }
		[JsonPropertyName("is_stable")]
		public bool IsStable { get; set; }
		[JsonPropertyName("available_for_to_conversion")]
		public bool AvailableForToConversion { get; set; }
	}
}