using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using  Aspose.Barcode.Live.Demos.UI.Helpers;
using  Aspose.Barcode.Live.Demos.UI.Resources;

namespace  Aspose.Barcode.Live.Demos.UI.Models
{
	public class BarcodeTypePreview
	{
		public string TypeName { get; set; }
		public string BarcodeTypeImgBase64 { get; set; }
		public string TypeDescription { get; set; }
		public string DefaultCodetext { get; set; }
		public string TypeTitle { get; set; }
		public string WikiUrl { get; set; }
		public string GroupName { get; set; }
		public string GroupTitle { get; set; }
		public string GroupShortDescription { get; set; }
	}

	public class BarcodeGenerateViewModel
	{
		public List<BarcodeTypePreview> BarcodeTypes { get; set; }
		public List<string> ImageFormats { get; set; }
		public string BarcodeGenerateAppTitle { get; set; }
		public string BarcodeGenerateAppTitleSub { get; set; }
		public string BarcodeGeneratePageTitle { get; set; }
		public string BarcodeGenerateMetaDescription { get; set; }
		public string BarcodeGenerateMetaKeywords { get; set; }
		public string JsonLdBreadcrumbLists { get; set; }

		private static List<BarcodeTypePreview> initBarcodeTypes(HttpContextBase httpContext)
		{
			var resources = new List<BarcodeTypePreview>();
			string ResourcesFile = httpContext.Server.MapPath("~/App_Data/BarCode/barcodes_EN.xml");
			XmlDocument xd = new XmlDocument();
			if (ResourcesFile.Trim() != "")
			{
				xd.Load(ResourcesFile);
			}

			XmlNodeList xl = xd.SelectNodes("barcodes/code");
			foreach (XmlNode n in xl)
			{
				var e = new BarcodeTypePreview()
				{
					TypeName = n.Attributes["name"].Value,
					TypeTitle = n.SelectSingleNode("title").InnerText.Trim(),
					BarcodeTypeImgBase64 = n.SelectSingleNode("preview").InnerText,
					DefaultCodetext = n.SelectSingleNode("defaultText").InnerText,
					TypeDescription = HttpUtility.HtmlDecode(n.SelectSingleNode("description").InnerText.Trim()),
					WikiUrl = n.SelectSingleNode("url").InnerText.Trim(),
					GroupName = n.Attributes["groupName"].Value,
					GroupTitle = n.Attributes["groupTitle"].Value,
					GroupShortDescription = n.SelectSingleNode("groupShortDescription").InnerText.Trim()
				};
				resources.Add(e);
			}

			return resources;
		}

		public static BarcodeGenerateViewModel Create(HttpContextBase httpContext, string groupName)
		{
			var res = Create(httpContext);

			var preselectedTypes = res.BarcodeTypes.Where(x => x.GroupName == groupName).ToList();

			if (preselectedTypes.Count == 0)
			{
				return null;
			}

			string selectedTypeUrl = preselectedTypes[0].GroupName;

			var typesList = preselectedTypes.Select(x => x.TypeTitle).Aggregate((x, y) => x + ", " + y);
			var groupDescription = preselectedTypes[0].GroupShortDescription;

			if (preselectedTypes.Count < 2)
			{
				res.BarcodeGenerateAppTitleSub = String.Format(AppStrings.BarcodeTypedGenerateAppTitleSub, preselectedTypes[0].GroupTitle);
			}
			else
			{
				res.BarcodeGenerateAppTitleSub = String.Format(AppStrings.BarcodeTypedGenerateAppTitleSub2, preselectedTypes[0].GroupTitle, typesList);
			}

			if (!String.IsNullOrEmpty(groupDescription))
			{
				res.BarcodeGenerateAppTitleSub += " " + groupDescription;
			}

			res.BarcodeGenerateAppTitle = String.Format(AppStrings.BarcodeTypedGenerateAppTitle, preselectedTypes[0].GroupTitle);
			res.BarcodeGeneratePageTitle = String.Format(AppStrings.BarcodeTypedGeneratePageTitle, preselectedTypes[0].GroupTitle);
			res.BarcodeGenerateMetaDescription = String.Format(AppStrings.BarcodeTypedGenerateMetaDescription, preselectedTypes[0].GroupTitle);
			res.BarcodeGenerateMetaKeywords = String.Format(AppStrings.BarcodeTypedGenerateMetaKeywords, typesList);
			preselectedTypes.Reverse();
			foreach (var typePreview in preselectedTypes)
			{
				res.BarcodeTypes.Remove(typePreview);
				res.BarcodeTypes.Insert(0, typePreview);
			}

			res.JsonLdBreadcrumbLists = PrepareJsonLdBreadcrumbList(selectedTypeUrl);

			return res;
		}

		public static BarcodeGenerateViewModel Create(HttpContextBase httpContext)
		{
			var res = new BarcodeGenerateViewModel();

			res.BarcodeTypes = initBarcodeTypes(httpContext);
			res.BarcodeGenerateAppTitle = AppStrings.BarcodeGenerateAppTitle;
			res.BarcodeGenerateAppTitleSub = AppStrings.BarcodeGenerateAppTitleSub;
			res.BarcodeGeneratePageTitle = AppStrings.BarcodeGeneratePageTitle;
			res.BarcodeGenerateMetaDescription = AppStrings.BarcodeGenerateMetaDescription;
			res.BarcodeGenerateMetaKeywords = AppStrings.BarcodeGenerateMetaKeywords;
			res.ImageFormats = new List<string>
			{
				"PNG", "JPEG", "TIFF", "BMP", "GIF", "SVG", "EMF"
			};
			res.JsonLdBreadcrumbLists = PrepareJsonLdBreadcrumbList("");

			return res;
		}

		private static string PrepareJsonLdBreadcrumbList(string selectedTypeUrl)
		{
			var str = new StringBuilder();
			// BreadcrumbLists
			void listItem(int position, string name, string url, string image = null)
			{
				str.Append("{");
				str.Append("\"@type\": \"ListItem\",");
				str.Append($"\"position\": {position},");
				str.Append($"\"name\": \"{name}\",");
				str.Append($"\"item\": \"{url}\"");
				str.Append("}");
			}
			str.Append("{");
			str.Append("\"@context\": \"https://schema.org\",");
			str.Append("\"@type\": \"BreadcrumbList\",");
			str.Append("\"itemListElement\": [");
			listItem(1, "barcode", "https://products.aspose.app/barcode/family", "https://joomla-asposeapp.dynabic.com/templates/asposeapp/images/product-family/aspose-barcode-app.png");
			str.Append(",");
			listItem(2, "generate", "https://products.aspose.app/barcode/generate", "https://www.aspose.cloud/templates/asposeapp/images/products/logo/aspose_generate-app.png");
			if (selectedTypeUrl.Trim() != "")
			{
				str.Append(",");
				listItem(3, selectedTypeUrl, $"https://products.aspose.app/barcode/generate/{selectedTypeUrl}", "https://www.aspose.cloud/templates/asposeapp/images/products/logo/aspose_generate-app.png");
			}

			str.Append("]}");
			return str.ToString();
		}

	}
}
