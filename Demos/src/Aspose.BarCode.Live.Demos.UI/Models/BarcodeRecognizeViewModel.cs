using  Aspose.Barcode.Live.Demos.UI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace  Aspose.Barcode.Live.Demos.UI.Models
{
	public class BarcodeTypeGroup
	{
		public string GroupName { get; set; }
		public string GroupTitle { get; set; }
		public string GroupShortDescription { get; set; }
		public string FirstTypeInGroupDescription { get; set; }
		public List<BarcodeTypeVariant> Types { get; set; }

	}
	public class BarcodeTypeVariant
	{
		public string TypeName { get; set; }
		public string TypeTitle { get; set; }
	}

	public class BarcodeTypeVariantFlat
	{
		public string GroupName { get; set; }
		public string GroupTitle { get; set; }
		public string GroupShortDescription { get; set; }
		public string TypeName { get; set; }
		public string TypeTitle { get; set; }
		public string TypeDescription { get; set; }
	}

	public class BarcodeRecognizeViewModel
	{
		public List<BarcodeTypeGroup> BarcodeTypes { get; set; }
		public string BarcodeRecognizeAppTitle { get; set; }
		public string BarcodeRecognizeAppTitleSub { get; set; }
		public string BarcodeRecognizePageTitle { get; set; }
		public string BarcodeRecognizeMetaDescription { get; set; }
		public string BarcodeRecognizeMetaKeywords { get; set; }
		public string JsonLdBreadcrumbLists { get; set; }

		private static List<BarcodeTypeGroup> initBarcodeTypes(HttpContextBase httpContext)
		{
			string ResourcesFile = httpContext.Server.MapPath("~/App_Data/BarCode/barcodes_EN.xml");
			XmlDocument xd = new XmlDocument();
			if (ResourcesFile.Trim() != "")
			{
				xd.Load(ResourcesFile);
			}

			XmlNodeList xl = xd.SelectNodes("barcodes/code");
			var types = new List<BarcodeTypeVariantFlat>();
			foreach (XmlNode n in xl)
			{
				var e = new BarcodeTypeVariantFlat
				{
					TypeName = n.Attributes["name"].Value,
					TypeTitle = n.SelectSingleNode("title").InnerText.Trim(),
					TypeDescription = HttpUtility.HtmlDecode(n.SelectSingleNode("description").InnerText.Trim()),
					GroupName = n.Attributes["groupName"].Value,
					GroupTitle = n.Attributes["groupTitle"].Value,
					GroupShortDescription = n.SelectSingleNode("groupShortDescription").InnerText.Trim()
				};
				types.Add(e);
			}

			var resources = (from t in types
							 group t by new { t.GroupName, t.GroupTitle }
				into grp
				select new BarcodeTypeGroup
				{
					GroupName = grp.Key.GroupName,
					GroupTitle = grp.Key.GroupTitle,
					GroupShortDescription = grp.First().GroupShortDescription,
					FirstTypeInGroupDescription = grp.First().TypeDescription,
					Types = grp.Select(x => new BarcodeTypeVariant
					{
						TypeTitle = x.TypeTitle,
						TypeName = x.TypeName
					}).ToList()
				}).ToList();

			return resources;
		}


		public static BarcodeRecognizeViewModel Create(HttpContextBase httpContext)
		{
			var res = new BarcodeRecognizeViewModel();
			res.BarcodeTypes = initBarcodeTypes(httpContext);

			res.BarcodeTypes.Insert(0, new BarcodeTypeGroup
			{
				GroupName = "none",
				GroupTitle = "All Types"
			});

			res.BarcodeRecognizeAppTitle = AppStrings.BarcodeRecognizeAppTitle;
			res.BarcodeRecognizeAppTitleSub = AppStrings.BarcodeRecognizeAppTitleSub;
			res.BarcodeRecognizePageTitle = AppStrings.BarcodeRecognizePageTitle;
			res.BarcodeRecognizeMetaDescription = AppStrings.BarcodeRecognizeMetaDescription;
			res.BarcodeRecognizeMetaKeywords = AppStrings.BarcodeRecognizeMetaKeywords;
			res.JsonLdBreadcrumbLists = PrepareJsonLdBreadcrumbList("");

			return res;
		}

		public static BarcodeRecognizeViewModel Create(HttpContextBase httpContext, string groupName)
		{
			var res = Create(httpContext);

			var selectedGroup = res.BarcodeTypes.SingleOrDefault(x => x.GroupName == groupName);
			if (selectedGroup == null)
			{
				return null;
			}

			var typesList = selectedGroup.Types.Select(x => x.TypeTitle).Aggregate((x, y) => x + ", " + y);
			var groupDescription = selectedGroup.GroupShortDescription;

			if (!String.IsNullOrEmpty(groupDescription))
			{
				res.BarcodeRecognizeAppTitleSub = groupDescription;
			}
			else
			{
				res.BarcodeRecognizeAppTitleSub = String.Format(AppStrings.BarcodeTypedRecognizeAppTitleSub2, typesList);
			}
			res.BarcodeRecognizeAppTitle = String.Format(AppStrings.BarcodeTypedRecognizeAppTitle, selectedGroup.GroupTitle);
			res.BarcodeRecognizePageTitle = String.Format(AppStrings.BarcodeTypedRecognizePageTitle, selectedGroup.GroupTitle);
			res.BarcodeRecognizeMetaDescription = String.Format(AppStrings.BarcodeTypedRecognizeMetaDescription, selectedGroup.GroupTitle);
			res.BarcodeRecognizeMetaKeywords = String.Format(AppStrings.BarcodeTypedRecognizeMetaKeywords, typesList);

			res.BarcodeTypes = new List<BarcodeTypeGroup>
			{
				selectedGroup,
				new BarcodeTypeGroup
				{
					GroupName = "none",
					GroupTitle = "All types"
				}
			};

			string selectedTypeUrl = selectedGroup.GroupName;
			res.JsonLdBreadcrumbLists = PrepareJsonLdBreadcrumbList(selectedTypeUrl);

			return res;
		}

		private static string PrepareJsonLdBreadcrumbList(string defaultType)
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
			listItem(2, "recognize", "https://products.aspose.app/barcode/recognize", "https://www.aspose.cloud/templates/asposeapp/images/products/logo/aspose_recognize-app.png");
			if (!String.IsNullOrEmpty(defaultType))
			{
				str.Append(",");
				listItem(3, defaultType, $"https://products.aspose.app/barcode/recognize/{defaultType}", "https://www.aspose.cloud/templates/asposeapp/images/products/logo/aspose_recognize-app.png");
			}

			str.Append("]}");
			return str.ToString();
		}
	}
}
