using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NowPayments.Net.Objects
{
	public class CurrenciesList
	{
		[JsonPropertyName("currencies")]
		public List<string>? Currencies { get; set; }
	}
}
