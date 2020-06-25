using Newtonsoft.Json;

namespace Aspose.Barcode.Live.Demos.UI.Models
{
    public abstract class SeoElement
	{
		[JsonProperty("@context")]
		public virtual string Context { get; set; } = "https://schema.org";

		[JsonProperty("@type")]
		public virtual string Type { get; set; }
	}

	public class Thing: SeoElement
	{
		[JsonProperty("@type")]
		public override string Type { get; set; } = "Thing";

		[JsonProperty("name")]
		public virtual string Name { get; set; }

		[JsonProperty("alternateName")]
		public virtual string AlterName { get; set; }

		[JsonProperty("discription")]
		public virtual string Discription { get; set; }

		[JsonProperty("image")]
		public virtual ImageObject Image { get; set; }
	}
}
