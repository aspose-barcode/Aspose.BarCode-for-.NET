using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.Barcode.Live.Demos.UI.Resources;

namespace Aspose.Barcode.Live.Demos.UI.Models.Common
{
	public class HowToSectionModel
	{
		public string Anchor { get; set; } = "howto";

		public string Title { get; set; }
		public List<string> HowToLines { get; set; }
		public List<string> HowToNames { get; set; }

		#region Barcode

		public static HowToSectionModel BarcodeGenerate => new HowToSectionModel
		{
			Title = AppStrings.BarcodeGenerateHowToTitle,
			HowToLines = AppStrings.BarcodeGenerateHowToContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList(),
			HowToNames = AppStrings.BarcodeGenerateHowToNames.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList(),
		};

		public static HowToSectionModel BarcodeRecognize => new HowToSectionModel
		{
			Title = AppStrings.BarcodeRecognizeHowToTitle,
			HowToLines = AppStrings.BarcodeRecognizeHowToContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList(),
			HowToNames = AppStrings.BarcodeRecognizeHowToNames.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList(),
		};

		#endregion Barcode



	}

}
