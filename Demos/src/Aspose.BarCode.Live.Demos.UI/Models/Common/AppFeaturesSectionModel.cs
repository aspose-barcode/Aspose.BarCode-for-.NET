using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.Barcode.Live.Demos.UI.Resources;
using Aspose.Barcode.Live.Demos.UI.Services;

namespace Aspose.Barcode.Live.Demos.UI.Models.Common
{
	public class AppFeaturesSectionModel
	{
		public string Anchor { get; set; } = "features";

		public string Product { get; set; }
		public string ProductFullName { get; set; }

		public string Feature1 { get; set; }
		public string Feature1Description { get; set; }
		public string Feature2 { get; set; }
		public string Feature2Description { get; set; }
		public string Feature3 { get; set; }
		public string Feature3Description { get; set; }


		#region Barcode
		public static AppFeaturesSectionModel BarcodeRecognize => new AppFeaturesSectionModel
		{
			Product = AppStrings.BarcodeProductName,
			ProductFullName = AppStrings.BarcodeProductFullName,
			Feature1 = AppStrings.BarcodeRecognizeFeaturesSectionFeature1,
			Feature1Description = AppStrings.BarcodeRecognizeFeaturesSectionFeature1Description,
			Feature2 = AppStrings.BarcodeRecognizeFeaturesSectionFeature2,
			Feature2Description = AppStrings.BarcodeRecognizeFeaturesSectionFeature2Description,
			Feature3 = AppStrings.BarcodeRecognizeFeaturesSectionFeature3,
			Feature3Description = AppStrings.BarcodeRecognizeFeaturesSectionFeature3Description
		};

		public static AppFeaturesSectionModel BarcodeGenerate => new AppFeaturesSectionModel
		{
			Product = AppStrings.BarcodeProductName,
			ProductFullName = AppStrings.BarcodeProductFullName,
			Feature1 = AppStrings.BarcodeGenerateFeaturesSectionFeature1,
			Feature1Description = AppStrings.BarcodeGenerateFeaturesSectionFeature1Description,
			Feature2 = AppStrings.BarcodeGenerateFeaturesSectionFeature2,
			Feature2Description = AppStrings.BarcodeGenerateFeaturesSectionFeature2Description,
			Feature3 = AppStrings.BarcodeGenerateFeaturesSectionFeature3,
			Feature3Description = AppStrings.BarcodeGenerateFeaturesSectionFeature3Description
		};
		#endregion Barcode


	}
}
