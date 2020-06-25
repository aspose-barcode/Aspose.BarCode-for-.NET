using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.Barcode.Live.Demos.UI.Resources;
using Aspose.Barcode.Live.Demos.UI.Services;

namespace Aspose.Barcode.Live.Demos.UI.Models.Common
{
	public class AppProductSectionModel
	{
		public string Anchor { get; set; } = "features";
		public IEnumerable<string> AppFeatures { get; set; }
		public string Product { get; set; }
		public string PageProductTitle { get; set; }
		public string AppName { get; set; }


		#region Barcode
		public static AppProductSectionModel BarcodeRecognize => new AppProductSectionModel
		{
			Product = AppStrings.BarcodeProductName,
			AppName = AppStrings.BarcodeRecognizeAppName,
			PageProductTitle = AppStrings.BarcodeRecognizeProductSectionTitle,
			AppFeatures = new List<string>
			{
				AppStrings.BarcodeRecognizeProductSectionFeature1,
				AppStrings.BarcodeRecognizeProductSectionFeature2
			}
		};

		public static AppProductSectionModel BarcodeGenerate => new AppProductSectionModel
		{
			Product = AppStrings.BarcodeProductName,
			AppName = AppStrings.BarcodeGenerateAppName,
			PageProductTitle = AppStrings.BarcodeGenerateProductSectionTitle,
			AppFeatures = new List<string>
			{
				AppStrings.BarcodeGenerateProductSectionFeature1,
				AppStrings.BarcodeGenerateProductSectionFeature2
			}
		};
		#endregion Barcode


	}
}
