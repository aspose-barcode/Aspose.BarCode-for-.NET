using Newtonsoft.Json;
using System.Linq;

namespace Aspose.Barcode.Live.Demos.UI.Models
{
    public class HowTo:SeoElement
    {
        public HowTo(string name, string description, string briefTitle)
        {
			Name = name;
			Description = description;
			Supply = new HowToSupply[] {new HowToSupply(briefTitle) };
		}

		public HowTo(HowToModel model, string description, string briefTitle, string videoUrl)
		{
			int i = 1;
			Steps = model.List.Select(x => new HowToStep()
			{
				Position = i++.ToString(),
				Name = x.Name,
				Image = new ImageObject() { Url = new URL() { Id = x.ImageUrl ?? videoUrl } },
				Text = x.Text,
				Url = new URL() { Id = videoUrl }
			}).ToArray();
			Description = description;
			Name = model.Title;
			Supply = new HowToSupply[] { new HowToSupply(briefTitle) };
		}

		[JsonProperty("@type")]
		public override string Type { get; set; } = "HowTo";

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("image")]
		public ImageObject Image { get; set; } = new ImageObject()
		{
			Url = new URL() { Id = "https://products.aspose.app/img/howto.png" },//https://joomla-asposeapp.dynabic.com/templates/asposeapp/images/product-family/aspose-pdf-app.png" },
			Width = "280",
			Height = "200"
		};

		[JsonProperty("estimatedCost")]
		public MonetaryAmount EstimatedCost { get; set; } = new MonetaryAmount();

		[JsonProperty("description")]
		public string Description { get; set; } 

		[JsonProperty("totalTime")]
		public string TotalTime { get; set; } = "PT1M";

		[JsonProperty("tool")]
		public HowToTool Tool { get; set; } = new HowToTool();

		[JsonProperty("supply")]
		public HowToSupply[] Supply { get; set; }

		[JsonProperty("step")]
		public HowToStep[] Steps { get; set; } 
	}

	public class HowToStep:SeoElement
	{
		[JsonProperty("@type")]
		public override string Type { get; set; } = "HowToStep";

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("position")]
		public string Position { get; set; }

		[JsonProperty("url")]
		public URL Url { get; set; }

		[JsonProperty("image")]
		public ImageObject Image { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class HowToTool: SeoElement
	{
		[JsonProperty("@type")]
		public override string Type { get; set; } = "HowToTool";

		[JsonProperty("name")]
		public string Name { get; set; } = "A Web browser";
	}

	public class HowToSupply
	{
        public HowToSupply(string name)
        {
			Name = name;
        }

		[JsonProperty("@type")]
		public string Type { get; set; } = "HowToSupply";

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class ImageObject:SeoElement
	{
		[JsonProperty("@type")]
		public override string Type { get; set; } = "ImageObject";

		[JsonProperty("url")]
		public URL Url { get; set; } 

		[JsonProperty("height")]
		public string Height { get; set; }

		[JsonProperty("width")]
		public string Width { get; set; }
	}

	public class MonetaryAmount:SeoElement
	{
		[JsonProperty("@type")]
		public override string Type { get; set; } = "MonetaryAmount";

		[JsonProperty("currency")]
		public string Currency { get; set; } = "USD";

		[JsonProperty("value")]
		public string Value { get; set; } = "0";
	}

	public class URL : SeoElement
	{
		[JsonProperty("@type")]
		public override string Type { get; set; } = "URL";

		[JsonProperty("@id")]
		public string Id { get; set; } 

		//[JsonProperty("name")]
		//public string Url { get; set; }

	}
}
