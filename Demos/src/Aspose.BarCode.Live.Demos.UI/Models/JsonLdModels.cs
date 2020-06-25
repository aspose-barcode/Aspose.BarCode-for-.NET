using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Aspose.Barcode.Live.Demos.UI.Models.Common;

namespace  Aspose.Barcode.Live.Demos.UI.Models
{
	public class JsonLdModels
	{
		public static string PrepareJsonLdProduct(string title, string imageUrl, string metaDescription)
		{
			var str = new StringBuilder();
			// Product
			str.Append("{");
			str.Append("\"@context\": \"https://schema.org\",");
			str.Append("\"@type\": \"SoftwareApplication\",");
			str.Append("\"creator\": { \"name\": \"Aspose\", \"url\": \"https://www.aspose.com/\"}, ");
			str.Append($"\"name\": \"{title}\",");
			str.Append($"\"image\": \"{imageUrl}\",");
			str.Append($"\"applicationCategory\": \"web-application\",");
			str.Append($"\"downloadUrl\": \"https://www.nuget.org/packages/Aspose.Barcode\",");
			str.Append($"\"operatingSystem\": \"Windows, iOS, Linux, Android\",");
			str.Append($"\"description\": \"{metaDescription}\",");
			str.Append($"\"softwareVersion\": \"20.5.0\",");
			str.Append("\"softwareHelp\": \"https://docs.aspose.com/display/barcodenet/Home\",");
			str.Append("\"softwareRequirements\": \"https://docs.aspose.com/display/barcodenet/System+Requirements\",");
			str.Append("\"offers\": { \"@type\": \"Offer\", \"price\": \"0.00\", \"priceCurrency\": \"USD\"},");
			str.Append("\"aggregateRating\": {");
			str.Append("\"@type\": \"AggregateRating\",");
			str.Append("\"worstRating\": \"1\",");
			str.Append("\"bestRating\": \"5\",");
			str.Append("\"ratingValue\": \"4.7\",");
			str.Append("\"reviewCount\": \"72\",");
			str.Append($"\"ratingCount\": \"{DateTime.Now.ToString("yyMMdd")}\"");
			str.Append("}}");

			return str.ToString();
		}

		public static string PrepareJsonLdHowTo(HowToSectionModel howToModel, string imageUrl, string title,
			string titleSub, string imageFolder)
		{
			var str = new StringBuilder();
			// HowTo
			str.Append("{");
			str.Append("\"@context\": \"https://schema.org\",");
			str.Append("\"@type\": \"HowTo\",");
			str.Append($"\"name\": \"{howToModel.Title}\",");
			str.Append($"\"image\": \"{imageUrl}\",");
			str.Append($"\"description\": \"{titleSub}\",");
			str.Append("\"totalTime\": \"PT2M\",");
			str.Append("\"tool\": [{ \"@type\": \"HowToTool\", \"name\":\"A Web browser\"}],");
			str.Append("\"supply\": [{ \"@type\": \"HowToSupply\", ");
			str.Append($"\"name\":\"{title}\"");
			str.Append("}],");
			str.Append("\"step\": [");
			for (int i = 1; i <= howToModel.HowToLines.Count; i++)
			{
				var howToLineContent = howToModel.HowToLines[i - 1];
				var howToLineName = howToModel.HowToNames[i - 1];
				str.Append("{");
				str.Append("\"@type\": \"HowToStep\",");
				str.Append($"\"text\": \"{howToLineContent.Replace("\"", "'")}\",");
				str.Append($"\"name\": \"{howToLineName.Replace("\"", "'")}\",");
				//str.Append($"\"url\": \"{howToLineContent.UrlPath}\",");
				str.Append($"\"image\": \"https://products.aspose.app/img/barcode/{imageFolder}/Step{i}.png\"");
				if (i < howToModel.HowToLines.Count)
					str.Append("},");
				else
					str.Append("}");
			}

			str.Append("]");
			str.Append("}");
			return str.ToString();
		}

	}
}
