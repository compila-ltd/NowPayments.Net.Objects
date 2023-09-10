using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class CurrenciesList
	{
		[JsonPropertyName("currencies")]
		public List<string>? Currencies { get; set; }
	}

	public class FullCurrenciesList

	{
		[JsonPropertyName("currencies")]
		public List<Currency>? Currencies { get; set; }
	}

	public class CheckedCurrenciesList
	{
		[JsonPropertyName("selectedCurrencies")]
		public List<string>? Currencies { get; set; }
	}
}
